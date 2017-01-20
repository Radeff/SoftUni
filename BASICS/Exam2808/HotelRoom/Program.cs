using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            var discount = 1;
            var apDiscount = 1;
            if (nights > 14)
            {
                apDiscount = 10;
            }
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (nights > 7 && nights < 14)
                {
                    discount = 5;
                }
                if (nights > 14)
                {
                    discount = 30;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (nights > 14)
                {
                    discount = 20;
                }
            }
            else
            {
                studio = 76;
                apartment = 77;
            }
            double totalApt = nights * apartment;
            if (apDiscount > 1)
            {
                totalApt -= totalApt * apDiscount / 100;
            }
            Console.WriteLine("Apartment: {0:F2} lv.", Math.Round(totalApt, 2));
            double totalStudio = nights * studio;
            if (discount > 1)
            {
                totalStudio -= totalStudio * discount / 100;
            }
            Console.WriteLine("Studio: {0:F2} lv.", Math.Round(totalStudio, 2));
            
        }
    }
}
