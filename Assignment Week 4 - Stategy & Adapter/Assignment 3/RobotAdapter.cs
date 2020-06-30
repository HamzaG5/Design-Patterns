using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class RobotAdapter : IAttacker
    {
        private Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string generator)
        {
            robot.MoveByPerson(generator);
        }

        public void DriveFoward()
        {
            robot.WalkFoward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
