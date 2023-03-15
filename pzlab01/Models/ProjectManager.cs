using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab01.Models
{
    class ProjectManager : Employee
    {
        private int numberOfproject;

        public int NumberOfProject
        {
            get { return numberOfproject; }
            set { numberOfproject = value; }
        }
        public ProjectManager()
        {

        }
        public ProjectManager(int id, string name, string lastname, int age, int salary, int numberofproject, Sex sex) : base(id, name, lastname, age, salary, sex)
        {
            NumberOfProject = numberofproject;
        }
        public override void GiveBonus(int amount)
        {
            base.GiveBonus(amount);
            EmpSalary += NumberOfProject * 10;
        }
        public override string ToString()
        {
            return base.ToString() + $"Ilość projektów: {NumberOfProject}";
        }
    }
}
