using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine("Создана новая собака!");
        }
        public override string MakeSound()
        {
            Console.WriteLine("Woof!");
            return "Woof!";
        }
    }
}
