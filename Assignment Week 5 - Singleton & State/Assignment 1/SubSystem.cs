using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SubSystem
    {
        private Logger logger;

        public SubSystem()
        {
            logger = Logger.GetInstance();
            
            logger.Log("SubSystem", DoSomeWork());
            logger.Log("SubSystem", DoSomeMoreWork());
        }

        public string DoSomeWork()
        {
            return "[SubSystem] doing some work";
        }

        public string DoSomeMoreWork()
        {
            return "[SubSystem] doing some more work";
        }
    }
}
