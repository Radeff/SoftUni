using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
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
                var input = Console.ReadLine().Split().ToArray();
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

            var authorSums = new Dictionary<string, double>();

            foreach (var book in library.Books)
            {
                if (!authorSums.ContainsKey(book.Author))
                {
                    authorSums[book.Author] = 0;
                }

                authorSums[book.Author] += book.Price;
            }

            foreach (var author in authorSums.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {                
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }

            //Same result using LINQ:
            /*             
                var filteredBooks = library.Books              //  library.Books.GroupBy(x => x.Author)
                .Select(b => new                               //  .Select(g => new
                {                                              //  {
                    Author = b.Author,                         //       Author = g.Key,
                    PricesTotal = library.Books                //      Prices = g.Sum(s => s.Price)
                        .Where(c => c.Author.Equals(b.Author)) //  })
                        .Sum(c => c.Price)                     //  .OrderByDescending(x=>x.Prices)
                })                                             //  .ThenBy(x=>x.Author)
                .Distinct()                                    //  .ToList();
                .OrderByDescending(b => b.PricesTotal)         //  foreach... print author.Author & author.Prices
                .ThenBy(b => b.Author)
                .ToList();

            foreach (var book in filteredBooks)
            {
                Console.WriteLine($"{book.Author:F2} -> {book.PricesTotal:F2}");
            }
            */
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
