using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var result = IsPrimeList(startNum, endNum).ToArray();
            var joinedResult = string.Join(", ", result);
            Console.WriteLine(joinedResult);
        }
        public static List<int> IsPrimeList(int start, int end)
        {
            List<int> Primes = new List<int>();
            if (end <= 1 || end < start)
            {
                return Primes;
            }
            for (int number = start; number <= end; number++)
            {
                if (number < 2)
                {
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i <= (int)Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                if (isPrime)
                {
                    Primes.Add(number);
                }
            }
            return Primes;
        }
    }
}
