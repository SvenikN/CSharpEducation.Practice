using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager() { }
        public Manager(string name, double salary, int teamSize) 
        : base(name, salary) 
        { 
            TeamSize = teamSize;
        }
        public override double CalculateBonus()
        {
            if (TeamSize > 5) 
                return Salary * 0.25;
            else return base.CalculateBonus();
        }
    }
}
