using System;

namespace _02.CardRank
{
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var cardRanks = Enum.GetValues(typeof(CardRank));

            if (inputLine == "Card Ranks")
            {
                Console.WriteLine("Card Ranks:");
                foreach (var rank in cardRanks)
                {
                    Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
                }
            }
        }
    }
}
