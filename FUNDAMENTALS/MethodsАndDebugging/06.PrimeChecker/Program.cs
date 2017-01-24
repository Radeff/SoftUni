using System;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
        public static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
