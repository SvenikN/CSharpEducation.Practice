using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        
        public Employee() 
        {
            Name = "Не известно";
            Salary = 0;
        }
        public Employee(string name, double salary) 
        {
            Name = name;
            Salary = salary;
        }

        public virtual double CalculateBonus() {
            return Salary*0.1;
        }
    }
}
