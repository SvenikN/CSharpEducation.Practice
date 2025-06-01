using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Eagle : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Eagle is soaring high");
        }
    }
}
