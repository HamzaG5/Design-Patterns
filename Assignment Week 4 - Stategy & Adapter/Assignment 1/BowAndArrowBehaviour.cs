using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWepaon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}
