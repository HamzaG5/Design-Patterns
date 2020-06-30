using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Pencil : IPencil
    {
        private int maxToWrite;        // number of characters to write with a sharpened pencil   
        private int nrOfCharsWritten;  // number of written characters 

        public Pencil()
        {
            maxToWrite = 20;
        }

        public bool CanWrite
        {
            get
            {
                return nrOfCharsWritten < maxToWrite;
            }
        }


        public void AfterSharpening()
        {
            //maxToWrite = 20;
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Char chr in message)
            {
                if (CanWrite)
                {
                    Console.Write(chr);
                }
                else
                {
                    Console.Write("#");
                }
                nrOfCharsWritten++;

            }
            Console.ResetColor();
            Console.WriteLine();
        }

    }
}
