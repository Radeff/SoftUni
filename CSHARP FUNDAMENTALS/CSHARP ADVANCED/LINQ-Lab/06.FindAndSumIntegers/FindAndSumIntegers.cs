using System;
using System.Linq;

namespace _06.FindAndSumIntegers
{
    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var n = 0L;
            var ints = input.Where(s => long.TryParse(s, out n))
                .Select(long.Parse)
                .ToList();

            if (ints.Count > 0)
            {
                Console.WriteLine(ints.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
