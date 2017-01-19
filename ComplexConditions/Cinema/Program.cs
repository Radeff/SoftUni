using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var proj = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (proj == "Premiere")
            {
                price = 12.0;
            }
            else if (proj == "Normal")
            {
                price = 7.5;
            }
            else
            {
                price = 5.0;
            }
            Console.WriteLine("{0:f2} leva", r * c * price);
        }
    }
}
