using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var pattern = new Regex(@"([^\d]+)(\d{1,2})");
            var matches = pattern.Matches(input);                       
            var uniqueSymbols = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].Groups[2].Value != "0")
                {
                    uniqueSymbols.Append(matches[i].Groups[1].Value);
                }
            }

            var uniqueSymbolsCount = uniqueSymbols.ToString().Select(x => x).Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");

            foreach (Match m in matches)
            {
                var digits = m.Groups[2].Value;

                while (digits.StartsWith("0") && digits.Length > 1)
                {
                    digits = digits.Remove(0, 1);
                }

                var count = int.Parse(digits);
                Console.Write(string.Concat(Enumerable.Repeat((m.Groups[1].Value.ToUpper()), count)));
            }

            Console.WriteLine();            
        }
    }
}
