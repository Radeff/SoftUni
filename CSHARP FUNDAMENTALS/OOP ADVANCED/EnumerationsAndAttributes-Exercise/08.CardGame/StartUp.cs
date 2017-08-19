using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CardGame
{
    public class StartUp
    {
        public static void Main()
        {
            var allCards = new List<Card>();
            var playerOneName = Console.ReadLine();
            var playerTwoName = Console.ReadLine();

            var playerOneHand = new List<Card>();
            var playerTwoHand = new List<Card>();

            FillHand(playerOneHand, allCards);
            FillHand(playerTwoHand, allCards);
            playerOneHand.Sort();
            playerTwoHand.Sort();

            var result = playerOneHand.Last().CompareTo(playerTwoHand.Last());
            if (result > 0)
            {
                Console.WriteLine($"{playerOneName} wins with {playerOneHand.Last()}.");
            }
            else
            {
                Console.WriteLine($"{playerTwoName} wins with {playerTwoHand.Last()}.");
            }
        }

        public static void FillHand(List<Card> player, List<Card> allCards)
        {
            while (player.Count < 5)
            {
                var input = Console.ReadLine().Split();
                CardRank rank;
                CardSuit suit;

                if (Enum.TryParse(input[0], out rank) && Enum.TryParse(input[2], out suit))
                {
                    var card = new Card(rank, suit);
                    if (!allCards.Any(c => c.Suit == suit && c.Rank == rank))
                    {
                        player.Add(card);
                        allCards.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                else
                {
                    Console.WriteLine("No such card exists.");
                }
            }
        }
    }
}
