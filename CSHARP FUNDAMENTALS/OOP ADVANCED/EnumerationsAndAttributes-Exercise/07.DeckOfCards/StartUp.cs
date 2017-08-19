using System;


namespace _07.DeckOfCards
{
    public class StartUp
    {
        public static void Main()
        {
            var cardSuits = Enum.GetValues(typeof(CardSuit));
            var cardRanks = Enum.GetValues(typeof(CardRank));

            foreach (var suit in cardSuits)
            {
                foreach (var rank in cardRanks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
