using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Parrot : Animal, IFlyable
    {
        public Color Color { get; set; }
        public Parrot(string name, int age, Color color) : base(name, age)
        {
            Color = color;
        }

        public new string MakeSound()
        {
            Console.WriteLine("Parrot is talking");
            return "Parrot is talking";
        }

        public void MakeSound(string words)
        { 
            Console.WriteLine(words);
        }

        public void Fly()
        {
            Console.WriteLine("Parrot is flying");
        }
    }
}
