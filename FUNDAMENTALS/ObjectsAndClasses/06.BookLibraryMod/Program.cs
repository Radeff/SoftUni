using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibraryMod
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            var library = new Library() { Books = books, Name = "National Library" };

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                books.Add(new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    Release = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                });
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books
                .Where(b => b.Release > date)
                .OrderBy(b => b.Release)
                .ThenBy(b => b.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.Release.ToString("dd.MM.yyyy")}");
            }
        }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime Release { get; set; }

        public string ISBN { get; set; }

        public double Price { get; set; }
    }
}
