using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    public class NumberWars
    {
        public static void Main()
        {
            var playerOne = new Queue<string>();
            var playerTwo = new Queue<string>();
            var alphabet = "0abcdefghijklmnopqrstuvwxyz";
            var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var card in input)
            {
                playerOne.Enqueue(card);
            }

            input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var card in input)
            {
                playerTwo.Enqueue(card);
            }

            var table = new Queue<string>();
            var turns = 0;

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                turns++;
                if (turns == 1000000)
                {
                    if (playerOne.Count > playerTwo.Count)
                    {
                        Console.WriteLine($"First player wins after {turns} turns");
                    }
                    else if (playerTwo.Count > playerOne.Count)
                    {
                        Console.WriteLine($"Second player wins after {turns} turns");
                    }
                    else
                    {
                        Console.WriteLine($"Draw after {turns} turns");
                    }
                    return;
                }

                var cardOne = playerOne.Dequeue();
                var cardTwo = playerTwo.Dequeue();
                table.Enqueue(cardOne);
                table.Enqueue(cardTwo);
                var cardOneNum = int.Parse(cardOne.Substring(0, cardOne.Length - 1));
                var cardtwoNum = int.Parse(cardTwo.Substring(0, cardTwo.Length - 1));
                if (cardOneNum > cardtwoNum)
                {
                    playerOne.Enqueue(table.Dequeue());
                    playerOne.Enqueue(table.Dequeue());
                }
                else if (cardtwoNum > cardOneNum)
                {
                    playerTwo.Enqueue(cardTwo);
                    playerTwo.Enqueue(cardOne);
                    table.Clear();
                }
                else
                {
                    while (true)
                    {
                        if (playerOne.Count < 3)
                        {
                            Console.WriteLine($"Second player wins after {turns} turns");
                            return;
                        }

                        if (playerTwo.Count < 3)
                        {
                            Console.WriteLine($"First player wins after {turns} turns");
                            return;
                        }

                        var playerOneOne = playerOne.Dequeue();
                        var playerOneTwo = playerOne.Dequeue();
                        var playerOneThree = playerOne.Dequeue();

                        var playerTwoOne = playerTwo.Dequeue();
                        var playerTwoTwo = playerTwo.Dequeue();
                        var playerTwoThree = playerTwo.Dequeue();

                        table.Enqueue(playerOneOne);
                        table.Enqueue(playerOneTwo);
                        table.Enqueue(playerOneThree);

                        table.Enqueue(playerTwoOne);
                        table.Enqueue(playerTwoTwo);
                        table.Enqueue(playerTwoThree);

                        var playerOneSum = alphabet.IndexOf(playerOneOne.Last())
                            + alphabet.IndexOf(playerOneTwo.Last())
                            + alphabet.IndexOf(playerOneThree.Last());

                        var playerTwoSum = alphabet.IndexOf(playerTwoOne.Last())
                                           + alphabet.IndexOf(playerTwoTwo.Last())
                                           + alphabet.IndexOf(playerTwoThree.Last());

                        if (playerOneSum > playerTwoSum)
                        {
                            foreach (var card in table.OrderByDescending(c => int.Parse(c.Substring(0, c.Length - 1))).ThenByDescending(c => c.Last()))
                            {
                                playerOne.Enqueue(card);
                            }
                            table.Clear();
                            break;
                        }

                        if (playerTwoSum > playerOneSum)
                        {
                            foreach (var card in table.OrderByDescending(c => int.Parse(c.Substring(0, c.Length - 1))).ThenByDescending(c => c.Last()))
                            {
                                playerTwo.Enqueue(card);
                            }
                            table.Clear();
                            break;
                        }

                        if (playerOne.Count == 0 && playerTwo.Count == 0)
                        {
                            Console.WriteLine($"Draw after {turns} turns");
                            return;
                        }
                    }
                }
            }

            if (playerOne.Count > 0)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (playerTwo.Count > 0)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
        }
    }
}
