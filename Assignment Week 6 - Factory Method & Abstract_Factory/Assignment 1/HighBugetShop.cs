using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class HighBugetShop : ComputerShop
    {
        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }
    }
}
