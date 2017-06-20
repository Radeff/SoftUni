using System;
using System.Linq;

namespace _01.TakeTwo
{
    public class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            numbers.Select(x => x)
                .Where(x => x >= 10 && x <= 20)
                .Take(2)
                .ToList()
                .ForEach(x => Console.Write(string.Concat(x, " ")));
            Console.WriteLine();
        }
    }
}
