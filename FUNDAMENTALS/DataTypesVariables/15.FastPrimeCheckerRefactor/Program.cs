using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool checkPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(i); divider++)
                {
                    if (i % divider == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {checkPrime}");
            }

        }
    }
}
