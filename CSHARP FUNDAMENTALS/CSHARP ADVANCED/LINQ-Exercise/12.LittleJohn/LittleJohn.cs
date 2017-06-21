using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.LittleJohn
{
    public class LittleJohn
    {
        public static void Main()
        {
            var input = string.Empty;
            var regex = new Regex(@"(>{1}-{5}>)|(>{2}-{5}>)|(>{3}-{5}>{2})");
            // 1 - small, 2 - medium, 3 - large
            var small = 0;
            var medium = 0;
            var large = 0;

            for (int i = 0; i < 4; i++)
            {
                input = Console.ReadLine();
                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    if (match.Groups[1].Length > 0)
                    {
                        small ++;
                    }
                    if (match.Groups[2].Length > 0)
                    {
                        medium ++;
                    }
                    if (match.Groups[3].Length > 0)
                    {
                        large ++;
                    }
                }
            }

            var count = int.Parse(string.Concat(small, medium, large));
            var countToBinary = Convert.ToString(count, 2);
            var reversed = new string(countToBinary.ToCharArray().Reverse().ToArray());
            var concatenated = string.Concat(countToBinary, reversed);
            var result = Convert.ToInt32(concatenated, 2);
            Console.WriteLine(result);
        }
    }
}
