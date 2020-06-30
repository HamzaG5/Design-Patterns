using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Tank : IAttacker
    {
        private string generator;
        
        public void AssignDriver(string generator)
        {
            this.generator = generator;
            Console.WriteLine($"{this.generator} is steering the tank");
        }

        public void DriveFoward()
        {
            Console.WriteLine("Tank moves 3 positions foward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damages");
        }
    }
}
