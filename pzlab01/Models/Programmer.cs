using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab01.Models
{
    class Programmer : Employee
    {
        private int numberOfTechnology;
        public int NumberOfTechnology
        {
            get { return numberOfTechnology; }
            set { numberOfTechnology = value; }
        }
        public Programmer()
        {

        }
        public Programmer(int id, string name, string lastname, int age, int salary, int numberoftechnology, Sex sex) : base(id, name, lastname, age, salary, sex)
        {
            NumberOfTechnology = numberoftechnology;
        }
        public override void GiveBonus(int amount)
        {
            base.GiveBonus(amount);
            EmpSalary += NumberOfTechnology * 10;
        }
        public override string ToString()
        {
            return base.ToString() + $"Ilość technologii: {NumberOfTechnology}";
        }
    }
}
