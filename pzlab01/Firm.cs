using pzlab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab01
{
    public class Firm
    {
        private static int budget = 10000;
        private List<Employee> employees = new List<Employee>();

        public Firm()
        {
            InitializeEmployees();
        }

        public void Menu(int option)
        {            
            switch (option)
            {
                case 1:
                    ShowAllEmployees();
                    break;
                case 2:
                    ShowAllEmployessOrderBySalary();
                    break;
                case 3:
                    {                        
                        try
                        {
                            Console.WriteLine("Podaj id pracownika: ");
                            int temp = Int32.Parse(Console.ReadLine());
                            ShowEmployeesById(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Wprowadzono nieprawidłowy znak");
                        }                        
                    }
                    break;
                case 4:
                    {                        
                        try
                        {
                            Console.WriteLine("Podaj id pracownika: ");
                            int temp = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj kwotę podwyżki: ");
                            int temp2 = Int32.Parse(Console.ReadLine());
                            GiveBonuse(temp2,temp);
                        }
                        catch
                        {
                            Console.WriteLine("Wprowadzono nieprawidłowy znak");
                        }
                    }
                    break;
                case 5:
                    {
                        try
                        {
                            Console.WriteLine("Podaj kwotę podwyżki: ");
                            int temp = Int32.Parse(Console.ReadLine());
                            GiveBonuseAll(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Wprowadzono nieprawidłowy znak");
                        }
                    }
                    break;
                case 6:
                    SummaryBudget();
                    break;
                case 7:
                    Console.WriteLine("Wyjście");
                    break;
                default:
                    Console.WriteLine("Brak takiej opcji"); 
                    break;
            }
        }
        public void DisplayMenuOptions()
        {
            Console.WriteLine("--------------------MENU-------------------------------");
            Console.WriteLine("1 - Pokaż wszystkich pracowników");
            Console.WriteLine("2 - Pokaż wszystkich pracowników posortowanych");
            Console.WriteLine("3 - Pokaż pracownika po id");
            Console.WriteLine("4 - Daj podwyżke dla pracownika");
            Console.WriteLine("5 - Daj podwyżke dla wszystkich pracowników");
            Console.WriteLine("6 - Wyświetl podsumowanie");
            Console.WriteLine("7 - Wyjście");
        }
        private void ShowAllEmployees()
        {
            employees.ForEach(x => Console.WriteLine(x.ToString()));
        }
        private void ShowAllEmployessOrderBySalary() 
        {
            employees.OrderBy(x => x.EmpSalary).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
        private void ShowEmployeesById(int id)
        {
            try 
            { 
                var emp = employees.First(x => x.EmpID == id);
                Console.WriteLine(emp.ToString());
            }
            catch (InvalidOperationException e)
            { 
                Console.WriteLine("Brak takiego pracownika");
            }
            catch (IOException e) 
            {
                Console.WriteLine(e);
            }
            
        }
        private void GiveBonuse(int amount, int id)
        {
            try
            {
                var emp = employees.First(x => x.EmpID == id);
                emp.GiveBonus(amount);
                Console.WriteLine("Zwiększono pensję pracownika: " + emp);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Brak takiego pracownika");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
        private void GiveBonuseAll(int amount)
        {
            employees.ForEach(x => x.GiveBonus(amount));
        }
        private void SummaryBudget()
        {
            int SalarySum = 0;
            employees.ForEach(x => SalarySum += x.EmpSalary * 12);
            int temp = budget - SalarySum;
       
            Console.WriteLine("Budżet = " + budget);
            Console.WriteLine("Suma rocznych pensji = " + SalarySum);
            Console.BackgroundColor = temp > 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("Różnica = " + temp);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void InitializeEmployees()
        {
            employees.Add(new Analyst(1, "Analityk1", "NazwiskoAnalityk1", 24, 4800, 12, Sex.Female));
            employees.Add(new Analyst(2, "Analityk2", "NazwiskoAnalityk2", 34, 5800, 28, Sex.Female));
            employees.Add(new Analyst(3, "Analityk3", "NazwiskoAnalityk3", 27, 5300, 18, Sex.Male));
            employees.Add(new Programmer(4, "Programista1", "NazwiskoProgramista1", 27, 12300, 5, Sex.Male));
            employees.Add(new Programmer(5, "Programista2", "NazwiskoProgramista2", 32, 15500, 9, Sex.Female));
            employees.Add(new Programmer(6, "Programista3", "NazwiskoProgramista3", 22, 8360, 3, Sex.Male));
            employees.Add(new RemotProgrammer(7, "ProgramistaZdalny1", "NazwiskoProgramistaZdalny1", 26, 8910, 3, 200, Sex.Female));
            employees.Add(new RemotProgrammer(8, "ProgramistaZdalny2", "NazwiskoProgramistaZdalny2", 29, 19460, 9, 250, Sex.Female));
            employees.Add(new RemotProgrammer(9, "ProgramistaZdalny3", "NazwiskoProgramistaZdalny3", 31, 22360, 13, 300, Sex.Male));
            employees.Add(new ProjectManager(10, "Menedzer1", "NazwiskoMenedzer1", 21, 4260, 3, Sex.Male));
            employees.Add(new ProjectManager(11, "Menedzer2", "NazwiskoMenedzer2", 39, 12580, 6, Sex.Male));
            employees.Add(new ProjectManager(12, "Menedzer3", "NazwiskoMenedzer3", 27, 7950, 4, Sex.Male));
        }
    }
}
