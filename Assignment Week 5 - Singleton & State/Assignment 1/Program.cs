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
            Program myProgram = new Program();
            myProgram.Main();
        }

        void Main()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("main", "starting");

            MainSystem mainSystem = new MainSystem();
            // ...

            logger.Log("main", "finishing");
            Console.ReadKey();
        }
    }
}
