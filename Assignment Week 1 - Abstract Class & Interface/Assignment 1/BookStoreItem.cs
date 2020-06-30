using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem()
        {

        }

        public BookStoreItem(string title, float price, int count)
        {
            this.Title = title;
            this.Price = price;
            NumberOfItems = count;
        }
        public abstract void Print();
    }
}
