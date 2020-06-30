﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LowBugdetShop : ComputerShop
    {
        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }
    }
}
