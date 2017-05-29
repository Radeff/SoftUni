using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var text = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!text.ContainsKey(input[i]))
                {
                    text.Add(input[i], 1);
                }
                else
                {
                    text[input[i]]++;
                }
            }

            foreach (var kvp in text)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
