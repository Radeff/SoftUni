using System;

namespace _01.CardSuit
{
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var cardSuits = Enum.GetValues(typeof(CardSuit));

            if (inputLine == "Card Suits")
            {
                Console.WriteLine("Card Suits:");
                foreach (var suit in cardSuits)
                {
                    Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
                }
            }
        }
    }
}
