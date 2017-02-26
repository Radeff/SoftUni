using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int price = 0;
            double total_pr = 0;
            double total_w = 0;
            int van = 0;
            int truck = 0;
            int train = 0;
            for (int i = 0; i < n; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 3)
                {
                    price = 200;
                    van += weight;
                }
                else if (weight >= 4 && weight <= 11)
                {
                    price = 175;
                    truck += weight;
                }
                else if (weight >= 12)
                {
                    price = 120;
                    train += weight;
                }
                total_w += weight;
                total_pr += weight * price;
            }
            Console.WriteLine("{0:F2}", total_pr/total_w);
            Console.WriteLine("{0:F2}%", van / total_w * 100);
            Console.WriteLine("{0:F2}%", truck / total_w * 100);
            Console.WriteLine("{0:F2}%", train / total_w * 100);
        }
    }
}
