using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine();
            string town = Console.ReadLine();
            var q = double.Parse(Console.ReadLine());
            switch (town)
            {
                case "Sofia":
                    if (prod == "coffee")
                    {
                        Console.WriteLine(q * 0.5);
                    }
                    else if (prod == "water")
                    {
                        Console.WriteLine(q * 0.8);
                    }
                    else if (prod == "beer")
                    {
                        Console.WriteLine(q * 1.20);
                    }
                    else if (prod == "sweets")
                    {
                        Console.WriteLine(q * 1.45);
                    }
                    else
                    {
                        Console.WriteLine(q * 1.60);
                    }
                    break;
                case "Plovdiv":
                    if (prod == "coffee")
                    {
                        Console.WriteLine(q * 0.4);
                    }
                    else if (prod == "water")
                    {
                        Console.WriteLine(q * 0.7);
                    }
                    else if (prod == "beer")
                    {
                        Console.WriteLine(q * 1.15);
                    }
                    else if (prod == "sweets")
                    {
                        Console.WriteLine(q * 1.30);
                    }
                    else
                    {
                        Console.WriteLine(q * 1.50);
                    }
                    break;
                case "Varna":
                    if (prod == "coffee")
                    {
                        Console.WriteLine(q * 0.45);
                    }
                    else if (prod == "water")
                    {
                        Console.WriteLine(q * 0.7);
                    }
                    else if (prod == "beer")
                    {
                        Console.WriteLine(q * 1.10);
                    }
                    else if (prod == "sweets")
                    {
                        Console.WriteLine(q * 1.35);
                    }
                    else
                    {
                        Console.WriteLine(q * 1.55);
                    }
                    break;
            }
        }
    }
}
