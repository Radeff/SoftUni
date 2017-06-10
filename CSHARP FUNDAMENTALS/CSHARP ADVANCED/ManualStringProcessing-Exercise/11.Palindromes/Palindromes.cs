using System;
using System.Collections.Generic;

namespace _11.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split("., !?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var uniques = new SortedSet<string>();

            foreach (var word in text)
            {
                var start = word.Substring(0, word.Length / 2);
                var end = start.ToCharArray();
                Array.Reverse(end);

                if (word.EndsWith(new string(end)))
                {
                    uniques.Add(word);
                }
            }

            Console.Write("[");
            Console.Write(string.Join(", ", uniques));
            Console.WriteLine("]");
        }
    }
}
