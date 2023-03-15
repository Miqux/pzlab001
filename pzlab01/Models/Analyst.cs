using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab01.Models
{
    class Analyst : Employee
    {
		private int numberOfClient;

		public int NumberOfClient
        {
			get { return numberOfClient; }
			set { numberOfClient = value; }
		}
        public Analyst()
        {

        }
        public Analyst(int id, string name, string lastname, int age, int salary, int numberOfClient, Sex sex) : base(id, name, lastname, age, salary, sex)
        {
            NumberOfClient = numberOfClient;
        }
        public override void GiveBonus(int amount)
        {
            base.GiveBonus(amount);
            EmpSalary += numberOfClient * 10;
        }
        public override string ToString()
        {
            return base.ToString() + $"Ilość klientów: { NumberOfClient }";
        }
    }
}
