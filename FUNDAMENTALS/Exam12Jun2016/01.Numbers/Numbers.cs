using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var average = numbers.Average();
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (number > average)
                {
                    result.Add(number);
                }
            }

            var count = 5;

            if (count > result.Count)
            {
                count = result.Count;
            }

            if (result.Any())
            {
                Console.WriteLine($"{string.Join(" ", result.OrderByDescending(n => n).Take(count))}");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
