using System;

namespace _05.CardCompareTo
{
    public class StartUp
    {
        public static void Main()
        {
            var cardRankOne = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var cardSuitOne = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var cardRankTwo = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var cardSuitTwo = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var cardOne = new Card(cardRankOne, cardSuitOne);
            var cardTwo = new Card(cardRankTwo, cardSuitTwo);


            var result = cardOne.CompareTo(cardTwo);
            if (result < 0)
            {
                Console.WriteLine(cardTwo);
            }
            else
            {
                Console.WriteLine(cardOne);
            }
        }
    }
}
