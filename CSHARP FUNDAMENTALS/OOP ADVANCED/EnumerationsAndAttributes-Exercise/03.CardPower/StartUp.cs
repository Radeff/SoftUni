using System;

namespace _03.CardPower
{
    public class StartUp
    {
        public static void Main()
        {
            var cardRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var card = new Card(cardRank, cardSuit);

            Console.WriteLine(card);
        }
    }
}
