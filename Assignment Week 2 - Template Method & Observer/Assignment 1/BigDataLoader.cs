using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Console.ResetColor();
            Extract();
            Transform();
            Load();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();
    }
}
