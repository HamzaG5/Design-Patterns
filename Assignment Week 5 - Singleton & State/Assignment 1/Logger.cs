using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Logger
    {
        private int numberOfLine;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLine = 0;
        }

        public void Log(string system, string objective)
        {
            Console.WriteLine($"{numberOfLine += 1} - [{system}] {objective}");
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }
    }
}
