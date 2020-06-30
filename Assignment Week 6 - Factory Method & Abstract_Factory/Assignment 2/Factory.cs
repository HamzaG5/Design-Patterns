using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Factory
    {
        public virtual IProcessor CreateProcessor()
        {
            return new Processor();
        }

        public virtual IHardDisk CreateHardDisk()
        {
            return new HardDisk();
        }

        public virtual IMonitor CreateMonitor()
        {
            return new Monitor();
        }
    }
}
