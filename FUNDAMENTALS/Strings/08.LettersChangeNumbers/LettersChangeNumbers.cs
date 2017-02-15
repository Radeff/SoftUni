using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var totalSum = 0M;

            foreach (var splitItem in input)
            {
                var letterBefore = splitItem.ElementAt(0);
                var number = decimal.Parse(splitItem.Substring(1, splitItem.Length - 2));
                var letterAfter = splitItem.ElementAt(splitItem.Length - 1);

                if (letterBefore >= 'A' && letterBefore <= 'Z')
                {
                    number /= letterBefore - 'A' + 1;
                }
                else
                {
                    number *= letterBefore - 'a' + 1;
                }

                if (letterAfter >= 'A' && letterAfter <= 'Z')
                {
                    number -= letterAfter - 'A' + 1;
                }
                else
                {
                    number += letterAfter - 'a' + 1;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
