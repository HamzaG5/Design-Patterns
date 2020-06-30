using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(string title, DayOfWeek releaseDay, float price, int numberOfItems)
        {
            base.Title = title;
            this.ReleaseDay = releaseDay;
            base.Price = price;
            base.NumberOfItems = numberOfItems;
        }
        
        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - {ReleaseDay}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
