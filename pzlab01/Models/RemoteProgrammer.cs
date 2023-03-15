using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab01.Models
{
    class RemotProgrammer : Programmer
    {
        private int distance;

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public RemotProgrammer()
        {

        }
        public RemotProgrammer(int id, string name, string lastname, int age, int salary, int numberoftechnology, int distance, Sex sex) : base(id, name, lastname, age, salary, numberoftechnology, sex)
        {
            Distance = distance;
        }
        public override void GiveBonus(int amount)
        {
            base.GiveBonus(amount);
            EmpSalary += Distance * 1;
        }
        public override string ToString()
        {
            return base.ToString() + $"Odległość: {Distance}";
        }
    }
}
