using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magn = 3.25;
            double zumb = 4.0;
            double rose = 3.5;
            double cact = 8.0;

            int m = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double total = m * magn + z * zumb + r * rose + c * cact;
            total -= total * 0.05;
            if (total >= gift)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(total - gift));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(Math.Abs(total - gift)));
            }
        }
    }
}
