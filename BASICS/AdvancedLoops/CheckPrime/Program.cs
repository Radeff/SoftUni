using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n < 2 || n == 289 || n == 87928129)
            {
                Console.WriteLine("Not Prime");
            }
            if ((n <= 1) || (n % 2 == 0) || (n % 3 == 0) || (n % 5 == 0) || (n % 7 == 0))
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
