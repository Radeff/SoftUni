using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split("/\\() ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var validList = new List<string>();
            var pattern = new Regex(@"\b[a-zA-Z]\w{2,24}\b");

            foreach (var userName in input)
            {
                if (pattern.IsMatch(userName))
                {
                    validList.Add(userName);
                }
            }

            var longest = 0;
            var longestIndex = 0;

            for (int i = 0; i < validList.Count - 1; i++)
            {
                var currentLength = validList[i].Length + validList[i + 1].Length;
                if (currentLength > longest)
                {
                    longest = currentLength;
                    longestIndex = i;
                }
            }

            Console.WriteLine($"{validList[longestIndex]}{Environment.NewLine}{validList[longestIndex + 1]}");
        }
    }
}
