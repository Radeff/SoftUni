using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var greater = Math.Max(a, b);
            var lesser = Math.Min(a, b);
            while (lesser != 0)
            {
                var remainder = greater % lesser;
                greater = lesser;
                lesser = remainder;
            }
            Console.WriteLine(greater);
        }
    }
}