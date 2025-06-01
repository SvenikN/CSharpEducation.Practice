using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine("Создана новая кошка!");
        }

        public override string MakeSound()
        {
            Console.WriteLine("Meow!");
            return "Meow!";
        }
    }
}
