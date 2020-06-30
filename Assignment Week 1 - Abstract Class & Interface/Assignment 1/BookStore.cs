using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class BookStore
    {
        private List<BookStoreItem> listBookItems;

        public BookStore()
        {
            listBookItems = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem item)
        {
            listBookItems.Add(item);
        }

        public void PrintAllItems()
        {
            foreach (BookStoreItem item in listBookItems)
            {
                item.Print();
            }
        }

    }
}
