using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;

        public MainSystem()
        {
            logger = Logger.GetInstance();
            logger.Log("MainSystem", DoSomeMainWork());

            subSystem = new SubSystem();
        }

        public string DoSomeMainWork()
        {
           return "doing some main work";
        }
    }
}
