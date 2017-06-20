using System;
using System.Linq;

namespace _07.BoundedNumbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var lower = Math.Min(boundaries[0], boundaries[1]);
            var upper = Math.Max(boundaries[0], boundaries[1]);
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var filtered = numbers.Where(x => x >= lower && x <= upper).ToList();
            Console.WriteLine(string.Join(" ", filtered));
        }
    }
}
