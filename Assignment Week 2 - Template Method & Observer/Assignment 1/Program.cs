using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        
        void Start()
        {
            BatchProcessor batchProcessor = new BatchProcessor();
            CallDataLoader call = new CallDataLoader();
            TwitterDataLoader twitter = new TwitterDataLoader();
            SensorDataLoader sensor = new SensorDataLoader();

            batchProcessor.Add(call);
            batchProcessor.Add(twitter);
            batchProcessor.Add(sensor);

            batchProcessor.Process();

            Console.ReadKey();
        }
    }
}
