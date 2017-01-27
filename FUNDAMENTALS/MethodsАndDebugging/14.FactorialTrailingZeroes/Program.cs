using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fact = FindFactorial(n);
            var count = CountFactorialTrailingZeroes(fact);
            Console.WriteLine(count);
        }

        public static BigInteger FindFactorial(int n)
        {
            BigInteger fact = 1;
            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }

        public static int CountFactorialTrailingZeroes(BigInteger fact)
        {
            var counter = 0;
            while (fact % 10 == 0)
            {
                counter++;
                fact = fact / 10;
            }
            return counter;
        }
    }
}
