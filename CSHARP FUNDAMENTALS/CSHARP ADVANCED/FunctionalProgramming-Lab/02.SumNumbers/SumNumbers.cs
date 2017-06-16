using System;
using System.Linq;

namespace _02.SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            Func<string, int> NumberParser = n => int.Parse(n);
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(NumberParser);

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
