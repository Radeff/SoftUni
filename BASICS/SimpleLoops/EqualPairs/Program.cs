using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum1 = num1 + num2;
            var diff = 0;
            var maxdiff = 0;

            for (int i = 1; i < n; i++)
            {
                var num3 = int.Parse(Console.ReadLine());
                var num4 = int.Parse(Console.ReadLine());
                var sum2 = num3 + num4;
                if (sum2 != sum1)
                {
                    diff = Math.Abs(sum1 - sum2);
                    sum1 = sum2;
                    if (diff > maxdiff)
                    {
                        maxdiff = diff;
                    }
                }
            }
            if (diff == 0)
            {
                Console.WriteLine("Yes, value=" + sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxdiff);
            }

        }
    }
}