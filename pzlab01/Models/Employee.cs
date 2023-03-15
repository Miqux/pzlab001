using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pzlab01.Models;

namespace pzlab01.Models
{
    abstract class Employee
    {
        private int empID;
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private string empLastName;
        public string EmpLastName
        {
            get { return empLastName; }
            set { empLastName = value; }
        }
        private int empAge;
        public int EmpAge
        {
            get { return empAge; }
            set { empAge = value; }
        }
        private int empSalary;
        public int EmpSalary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }
        private Sex sex;

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Employee()
        {

        }
        public Employee(int id, string name, string lastname, int age, int salary, Sex sex)
        {
            EmpID = id;
            EmpName = name;
            EmpLastName = lastname;
            EmpAge = age;
            EmpSalary = salary;
            Sex = sex;
        }
        public virtual void GiveBonus(int amount)
        {
            EmpSalary += amount;
        }
        public override string ToString()
        {
            return $"{EmpName} {EmpLastName}, Wiek: {EmpAge}, Wypłata: {EmpSalary}";
        }
    }
}
