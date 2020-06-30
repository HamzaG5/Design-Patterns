using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ComputerShop
    {
        public void AssembleMachine(Factory factory)
        {
            IProcessor processor = factory.CreateProcessor();
            IHardDisk hardDisk = factory.CreateHardDisk();
            IMonitor monitor = factory.CreateMonitor();

            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }

    }
}
