using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var EvenSum = 0.0;
            var OddSum = 0.0;
            var EvenMax = double.MinValue;
            var OddMax = double.MinValue;
            var EvenMin = double.MaxValue;
            var OddMin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }
                    if (num < EvenMin)
                    {
                        EvenMin = num;
                    }
                    EvenSum += num;
                }
                else
                {
                    if (num > OddMax)
                    {
                        OddMax = num;
                    }
                    if (num < OddMin)
                    {
                        OddMin = num;
                    }
                    OddSum += num;
                }
            }
            Console.WriteLine("OddSum=" + OddSum);
            if (OddMax == double.MinValue || OddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin no");
                Console.WriteLine("OddMax no");
            }
            else
            {
                Console.WriteLine("OddMin=" + OddMin);
                Console.WriteLine("OddMax=" + OddMax);
            }
            Console.WriteLine("EvenSum=" + EvenSum);
            if (EvenMin == double.MaxValue || EvenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin no");
                Console.WriteLine("EvenMax no");
            }
            else
            {
                Console.WriteLine("EvenMin=" + EvenMin);
                Console.WriteLine("EvenMax=" + EvenMax);
            }
        }
    }
}