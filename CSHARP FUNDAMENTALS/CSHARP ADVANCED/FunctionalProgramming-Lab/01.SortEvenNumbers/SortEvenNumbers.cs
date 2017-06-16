using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    public class SortEvenNumbers
    {
        public static void Main()
        {
            Func<string, int> NumberParser = n => int.Parse(n);
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(NumberParser);

            Func<int, bool> EvenSelector = n => n % 2 == 0;
            Console.WriteLine(string.Join(", ", numbers.Where(EvenSelector).OrderBy(n => n)));
        }
    }
}
