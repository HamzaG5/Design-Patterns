using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            string message = "";
            Pencil pencil = new Pencil();
            PencilSharpener pencilSharpener = new PencilSharpener();

            while (message != "stop")
            {
                if (message == "sharpen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("sharpening the pencil...");
                    Console.ResetColor();

                    pencilSharpener.Sharpen(pencil);
                }
                else if (message != "")
                {
                    pencil.Write(message);
                }

                Console.Write("Enter a word: ");
                message = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
