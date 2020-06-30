using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWepaon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}
