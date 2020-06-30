using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[shop creating expensive computers]");
            Factory highBuget = new HighBugetFactory();
            ComputerShop shop1 = new ComputerShop();
            shop1.AssembleMachine(highBuget);

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            Factory lowBuget = new LowBugetFactory();
          //  ComputerShop shop2 = new ComputerShop();
            shop1.AssembleMachine(lowBuget);

            Console.ReadKey();
        }
    }
}
