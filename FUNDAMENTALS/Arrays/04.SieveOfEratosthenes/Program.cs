using System;

namespace _04.SieveOfEratosthenes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var primes = new bool[n + 1];
            primes[0] = primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            FindAndPrintPrimesToN(primes, n);
        }

        public static void FindAndPrintPrimesToN(bool[] primes, int n)
        {
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                    for (int q = 2 * i; q < primes.Length; q += i)
                    {
                        primes[q] = false;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
