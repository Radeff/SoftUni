using System;
using System.Text.RegularExpressions;

namespace _07.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b[A-Za-z][A-Za-z0-9_]{2,24}\b");
            var matches = regex.Matches(input);
            var result = new string[matches.Count];

            var sum = 0;
            var firstLongest = string.Empty;
            var secondLongest = string.Empty;

            var i = 0;
            foreach (Match match in matches)
            {
                result[i] = match.Value;
                i++;
            }

            for (int j = 0; j < result.Length - 1; j++)
            {
                var tempSum = result[j].Length + result[j + 1].Length;
                if ( tempSum > sum)
                {
                    sum = tempSum;
                    firstLongest = result[j];
                    secondLongest = result[j + 1];
                }
            }

            Console.WriteLine(firstLongest);
            Console.WriteLine(secondLongest);
        }
    }
}
