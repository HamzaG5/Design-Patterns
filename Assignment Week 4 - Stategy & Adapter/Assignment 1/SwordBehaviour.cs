using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWepaon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
