using System;
using System.Linq;

namespace _04.AverageOfDoubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            var doubles = Console.ReadLine().Split()
                .Select(double.Parse)
                .ToList();
            Console.WriteLine($"{doubles.Average():F2}");
        }
    }
}
