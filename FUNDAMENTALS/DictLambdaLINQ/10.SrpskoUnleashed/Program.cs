using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SrpskoUnleashed
{
    public class Program
    {
        public static void Main()
        {
            var concerts = new Dictionary<string, Dictionary<string, int>>();
            var input = new string[1];

            do
            {
                input = Console.ReadLine().Split().ToArray();
                if (input.Length > 3)
                {
                    AddConcert(concerts, input);
                }

            } while (input[0] != "End");

            PrintTotals(concerts);
        }

        public static void PrintTotals(Dictionary<string, Dictionary<string, int>> concerts)
        {
            foreach (var place in concerts)
            {
                Console.WriteLine($"{place.Key}");
                foreach (var singer in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }            
        }

        public static void AddConcert(Dictionary<string, Dictionary<string, int>> concerts, string[] input)
        {
            var place = string.Empty;
            var singer = string.Empty;
            int money = 1;
            int placeStart = -1;
            placeStart = Array.FindIndex(input, x => x.StartsWith("@"));

            if (placeStart + 2 >= input.Length || placeStart < 0)
            {
                return;
            }

            else if (!int.TryParse(input.Last(), out money) 
                || !int.TryParse(input[input.Length-2], out money) 
                || int.TryParse(input[input.Length-3], out money))
            {
                return;
            }

            for (int i = 0; i < placeStart; i++)
            {
                singer += " " + input[i];
                singer = singer.Trim();
            }

            input[placeStart] = input[placeStart].Remove(0, 1);
            money = 1;

            for (int j = placeStart; j < input.Length; j++)
            {
                int temp = 0;
                if (int.TryParse(input[j], out temp))
                {
                    money *= temp;
                }

                else
                {
                    place += " " + input[j];
                    place = place.Trim();
                }
            }

            if (!concerts.ContainsKey(place))
            {
                concerts.Add(place, new Dictionary<string, int> { { singer, money } });
            }

            else if (!concerts[place].ContainsKey(singer))
            {
                concerts[place].Add(singer, money);
            }

            else
            {
                concerts[place][singer] += money;
            }
        }
    }
}
