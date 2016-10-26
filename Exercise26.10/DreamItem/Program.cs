using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string month = input.Split('\\')[0];
            var mph = decimal.Parse(input.Split('\\')[1]);
            var hpd = uint.Parse(input.Split('\\')[2]);
            var price = decimal.Parse(input.Split('\\')[3]);

            int workdays = 0;
            switch (month)
            {
                case "Jan":
                    workdays = 31;
                break;
                case "Feb":
                    workdays = 28;
                    break;
                case "March":
                    workdays = 31;
                    break;
                case "Apr":
                    workdays = 30;
                    break;
                case "May":
                    workdays = 31;
                    break;
                case "June":
                    workdays = 30;
                    break;
                case "July":
                    workdays = 31;
                    break;
                case "Aug":
                    workdays = 31;
                    break;
                case "Sept":
                    workdays = 30;
                    break;
                case "Oct":
                    workdays = 31;
                    break;
                case "Nov":
                    workdays = 30;
                    break;
                case "Dec":
                    workdays = 31;
                    break;
            }
            workdays -= 10;
            var wage = workdays * (mph * hpd);
            if (wage > 700)
            {
                wage *= 1.1M;
            }
            if (wage < price)
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", price - wage);
            }
            else
            {
                Console.WriteLine("Money left = {0:F2} leva.", wage - price);
            }
        }
    }
}
