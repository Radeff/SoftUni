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
            var num = double.Parse(Console.ReadLine());
            var EvenSum = 0.0;
            var OddSum = num;
            var EvenMax = num;
            var OddMax = num;
            var EvenMin = num;
            var OddMin = num;
            for (int i = 2; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
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
            Console.WriteLine("OddMin=" + OddMin);
            Console.WriteLine("OddMax=" + OddMax);
            Console.WriteLine("EvenSum=" + EvenSum);
            Console.WriteLine("EvenMin=" + EvenMin);
            Console.WriteLine("EvenMax=" + EvenMax);
        }
    }
}
