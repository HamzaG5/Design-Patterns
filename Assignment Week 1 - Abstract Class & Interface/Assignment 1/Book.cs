using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string title, string author, float price, int numberOfItems)
        {
            base.Title = title;
            this.Author = author;
            base.Price = price;
            base.NumberOfItems = numberOfItems;
        }
        
        public override void Print()
        {
            Console.WriteLine($"[Book] {Title} - {Author}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
