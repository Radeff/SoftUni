using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string cat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double ticket_price = 249.99;
            if (cat == "VIP")
            {
                ticket_price = 499.99;
            }
            if (n >= 1 && n <= 4)
            {
                money -= money * 0.75;
            }
            else if (n >= 5 && n <= 9)
            {
                money -= money * 0.60;
            }
            else if (n >= 10 && n <= 24)
            {
                money -= money * 0.50;
            }
            else if (n >= 25 && n <= 49)
            {
                money -= money * 0.40;
            }
            else if (n > 49)
            {
                money -= money * 0.25;
            }
            money -= n * ticket_price;
            if (money > 0)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", money);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(money));
            }
        }
    }
}
