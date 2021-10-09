using BookshelfApp.Models;

using System;

namespace BookshelfApp.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var bookshelf = new Bookshelf(1000);
            bookshelf.AddItem(new Album() { Pages = 10});
            bookshelf.AddItem(new Album() { Pages = 20 });
            bookshelf.AddItem(new Book() { Pages = 100 });


            var freeSpace = bookshelf.AvailableSpace;
            Console.ReadLine();
        }
    }
}
