using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintFactorial(n);
        }

        public static void PrintFactorial(int n)
        {
            BigInteger fact = 1;
            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
            Console.WriteLine(fact);
        }
    }
}
