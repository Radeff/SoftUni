using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    public class Program
    {
        public static void Main()
        {
            var input = string.Empty;
            var hands = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {
                input = Console.ReadLine();
                DrawCards(hands, input);
            }
        }

        public static void DrawCards(Dictionary<string, List<string>> hands, string input)
        {
            if (input == "JOKER")
            {
                foreach (var name in hands)
                {
                    int sum = 0;

                    foreach (var card in name.Value)
                    {
                        var cardnum = 0;
                        var cardPower = 0;
                        var cardMultiplier = 0;

                        switch (card[card.Length - 1])
                        {
                            case 'C':
                                cardMultiplier = 1;
                                break;
                            case 'D':
                                cardMultiplier = 2;
                                break;
                            case 'H':
                                cardMultiplier = 3;
                                break;
                            case 'S':
                                cardMultiplier = 4;
                                break;
                        }

                        if (int.TryParse(card.Substring(0, card.Length - 1), out cardnum))
                        {
                            cardPower = cardnum;
                        }

                        else
                        {
                            switch (card[0])
                            {
                                case 'J':
                                    cardPower = 11;
                                    break;
                                case 'Q':
                                    cardPower = 12;
                                    break;
                                case 'K':
                                    cardPower = 13;
                                    break;
                                case 'A':
                                    cardPower = 14;
                                    break;
                            }
                        }

                        sum += cardPower * cardMultiplier;
                    }

                    Console.WriteLine($"{name.Key}: {sum}");
                }
                return;
            }
            else
            {
                var splitInput = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = splitInput[0];

                var hand = splitInput[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();
                
                if (!hands.ContainsKey(name))
                {
                    hands.Add(name, hand);
                }

                else
                {
                    hands[name].AddRange(hand.Where(x => !hands[name].Contains(x)));
                }
            }
        }
    }
}
