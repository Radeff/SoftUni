using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fr = Console.ReadLine();
            var d = Console.ReadLine();
            var q = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (d == "Monday" || d == "Tuesday" || d == "Wednesday" || d == "Thursday" || d == "Friday")
            {
                if (fr == "banana")
                {
                    price = 2.5;
                }
                else if (fr == "apple")
                {
                    price = 1.2;
                }
                else if (fr == "orange")
                {
                    price = 0.85;
                }
                else if (fr == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fr == "kiwi")
                {
                    price = 2.70;
                }
                else if (fr == "pineapple")
                {
                    price = 5.50;
                }
                else if (fr == "grapes")
                {
                    price = 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(q * price);
            }
            else if (d == "Saturday" || d == "Sunday")
            {
                if (fr == "banana")
                {
                    price = 2.7;
                }
                else if (fr == "apple")
                {
                    price = 1.25;
                }
                else if (fr == "orange")
                {
                    price = 0.90;
                }
                else if (fr == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fr == "kiwi")
                {
                    price = 3.0;
                }
                else if (fr == "pineapple")
                {
                    price = 5.60;
                }
                else if (fr == "grapes")
                {
                    price = 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(q * price, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
