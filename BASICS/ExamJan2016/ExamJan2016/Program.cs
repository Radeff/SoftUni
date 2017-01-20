using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamJan2016
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            uint f = uint.Parse(Console.ReadLine());
            uint t = uint.Parse(Console.ReadLine());
            uint p = uint.Parse(Console.ReadLine());
            double cakes = Math.Floor(f / c);
            ulong tprice = (ulong)t * p;

            if (cakes < n)
            {
                double kgNeeded = (c * n) - f;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakes, kgNeeded);
            }
            else
            {
                double price = ((double)tprice / n) * 1.25d;
                Console.WriteLine("All products available, price of a cake: {0:F2}", price);
            }
        }
    }
}
