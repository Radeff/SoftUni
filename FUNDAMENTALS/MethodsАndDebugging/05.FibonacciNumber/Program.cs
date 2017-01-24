using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumberFinder(input));
        }
        public static int FibonacciNumberFinder(int input)
        {
            var previousFib = 0;
            var currentFib = 1;
            var newFib = 1;

            for (int i = 0; i < input; i++)
            {
                newFib = previousFib + currentFib;
                previousFib = currentFib;
                currentFib = newFib;
            }
            return newFib;
        }
    }
}
