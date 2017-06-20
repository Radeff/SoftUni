using System;
using System.Linq;

namespace _05.MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var filteredEven = numbers.Where(x => x % 2 == 0).ToList();

            if (filteredEven.Count > 0)
            {
                Console.WriteLine($"{filteredEven.Min():F2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
