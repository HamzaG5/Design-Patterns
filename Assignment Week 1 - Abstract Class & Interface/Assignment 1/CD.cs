using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string title, string artist, float price, int numberOfItems)
        {
            base.Title = title;
            this.Artist = artist;
            base.Price = price;
            base.NumberOfItems = numberOfItems;
        }

        public override void Print()
        {
            Console.WriteLine($"[CD] {Title} - {Artist}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
