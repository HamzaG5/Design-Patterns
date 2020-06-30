using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Robot
    {
        private string generator;

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void MoveByPerson(string generator)
        {
            this.generator = generator;
            Console.WriteLine($"Robot is moved by {this.generator}");
        }

        public void WalkFoward()
        {
            Console.WriteLine("Robot walks 3 steps");
        }
    }
}
