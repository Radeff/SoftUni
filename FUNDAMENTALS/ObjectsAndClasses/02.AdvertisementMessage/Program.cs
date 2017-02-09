using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AdvertisementMessage
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var phrases = new string[] 
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            var cities = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var randomIndex = random.Next(0, 6);
                var phrase = phrases[randomIndex];
                randomIndex = random.Next(0, 6);
                var evnt = events[randomIndex];
                randomIndex = random.Next(0, 8);
                var author = authors[randomIndex];
                randomIndex = random.Next(0, 5);

                var city = cities[randomIndex];

                var msg = new Message()
                {
                    Phrase = phrase,
                    Event = evnt,
                    Author = author,
                    City = city
                };

                Console.WriteLine($"{msg.Phrase} {msg.Event} {msg.Author} - {msg.City}");
            }
        }
    }

    public class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
    }
}
