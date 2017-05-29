using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);
            var dict = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
