using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task3
{
    internal class Calculator
    {
        public double Sum(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль");
                return 0;
            }
            return Math.Round(a / b, 2);
        }
    }
}
