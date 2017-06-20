using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var divisor = int.Parse(Console.ReadLine());
            Array.Reverse(numbers);
            Predicate<int> divisible = n => n % divisor != 0;
            
            foreach (var num in numbers)
            {
                if (divisible(num))
                {
                    Console.Write(string.Concat(num, " "));
                }
            }

            Console.WriteLine();
        }
    }
}
