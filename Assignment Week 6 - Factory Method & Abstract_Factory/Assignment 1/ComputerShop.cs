using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ComputerShop
    {
        public void AssembleMachine()
        {
            IProcessor processor = CreateProcessor();
            IHardDisk hardDisk = CreateHardDisk();
            IMonitor monitor = CreateMonitor();

            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
        
        public virtual IProcessor CreateProcessor() { return new Processor(); }

        public virtual IHardDisk CreateHardDisk() { return new HardDisk(); }

        public virtual IMonitor CreateMonitor() { return new Monitor(); }
        
    }
}
