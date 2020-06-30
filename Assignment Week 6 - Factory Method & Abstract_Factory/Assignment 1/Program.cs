using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop computerShop = new HighBugetShop();
            computerShop.AssembleMachine();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop shop = new LowBugdetShop();
            shop.AssembleMachine();

            Console.ReadKey();
        }
    }
}
