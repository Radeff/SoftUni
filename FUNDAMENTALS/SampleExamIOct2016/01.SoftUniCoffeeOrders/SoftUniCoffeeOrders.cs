using System;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var orders = int.Parse(Console.ReadLine());
            var total = 0M;

            for (int i = 0; i < orders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsules = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                var pricePerMonth = daysInMonth * capsules * price;
                total += pricePerMonth;

                Console.WriteLine($"The price for the coffee is: ${pricePerMonth:F2}");
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
