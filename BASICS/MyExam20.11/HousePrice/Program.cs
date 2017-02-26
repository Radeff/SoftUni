using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double small = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double bath = small / 2.0;
            double second = small + (small * 0.1);
            double third = second + (second * 0.1);

            double area = small + kitchen + bath + second + third;
            area = area + (area * 0.05);
            double total = area * price;
            Console.WriteLine("{0:F2}", total);
        }
    }
}
