﻿using System;
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
            Program myProgram = new Program();
            myProgram.Start();
        }   
        void Start()
        {
            IFlyable s = new Superman();
            IFlyable a = new Airplane();

            MakeFlight(s);
            MakeFlight(a);

            Console.ReadKey();
        }

        void MakeFlight(IFlyable flyable)
        {
            flyable.LiftOff();
            flyable.Fly();
            flyable.Land();
            Console.WriteLine();
        }
    }
}
