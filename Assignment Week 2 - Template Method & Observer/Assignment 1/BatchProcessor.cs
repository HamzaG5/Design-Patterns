using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BatchProcessor
    {
        public List<BigDataLoader> bigDataLoadersList= new List<BigDataLoader>();

        public void Add(BigDataLoader bgl)
        {
            bigDataLoadersList.Add(bgl);
        }

        public void Process()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (BigDataLoader bgl in bigDataLoadersList)
            {
                Console.WriteLine("[ETL-proces started]");
                bgl.ETL();

                Console.WriteLine("[ETL-proces finished]");
                Console.WriteLine();
            }

            Console.ResetColor();
        }

    }
}
