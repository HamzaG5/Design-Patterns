using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("airplane is flying...");
            Console.WriteLine("airplane is flying...");
            Console.WriteLine("airplane is flying...");
        }

        public void Land()
        {
            Console.WriteLine("airplane is landing...");
        }

        public void LiftOff()
        {
            Console.WriteLine("airplane is lifting off...");
        }
    }
}
