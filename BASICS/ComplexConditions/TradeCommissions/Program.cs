using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            double q = 0.0;
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    q = 5 / 100.0;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    q = 7 / 100.0;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    q = 8 / 100.0;
                }
                else if (sales > 10000)
                {
                    q = 12 / 100.0;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    q = 4.5 / 100.0;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    q = 7.5 / 100.0;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    q = 10 / 100.0;
                }
                else if (sales > 10000)
                {
                    q = 13 / 100.0;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    q = 5.5 / 100.0;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    q = 8 / 100.0;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    q = 12 / 100.0;
                }
                else if (sales > 10000)
                {
                    q = 14.5 / 100.0;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if ( q > 0)
            {
                Console.WriteLine(q * sales);
            }
        }
    }
}
