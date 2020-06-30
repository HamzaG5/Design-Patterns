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
            BookStoreItem book1 = new Book("Bram Stoker", "Dracula", 15, 5);
            BookStoreItem book2 = new Book("Tommy Wieringa", "Joe speedboot", 12.5f, 3);
            BookStoreItem magazine1 = new Magazine("Time", DayOfWeek.Friday, 3.9f, 10);
            BookStoreItem magazine2 = new Magazine("Donald Duck", DayOfWeek.Thursday, 2.5f, 15);
            BookStoreItem cd = new CD("The Cure", "Seventeen Seconds", 3.9f, 5);

            BookStore bookStore = new BookStore();
            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(cd);

            bookStore.PrintAllItems();

            Console.ReadKey();
        }

    }
}
