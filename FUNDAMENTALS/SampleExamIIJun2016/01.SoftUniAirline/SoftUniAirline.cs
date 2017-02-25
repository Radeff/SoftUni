using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SoftUniAirline
{
    public class SoftUniAirline
    {
        public static void Main()
        {
            var flights = int.Parse(Console.ReadLine());                     
            var profit = new List<decimal>();

            for (int i = 0; i < flights; i++)
            {
                var adults = int.Parse(Console.ReadLine());
                var adultsPrice = decimal.Parse(Console.ReadLine());
                var youths = int.Parse(Console.ReadLine());
                var youthPrice = decimal.Parse(Console.ReadLine());
                var fuelPrice = decimal.Parse(Console.ReadLine());
                var fuelConsumption = decimal.Parse(Console.ReadLine());
                var flightDur = int.Parse(Console.ReadLine());

                var flightIncome = (adults * adultsPrice) + (youths * youthPrice);
                var flightCost = flightDur * fuelConsumption * fuelPrice;
                var flightProfit = flightIncome - flightCost;                
                
                profit.Add(flightProfit);

                if (flightIncome >= flightCost)
                {
                    Console.WriteLine($"You are ahead with {flightProfit:F3}$.");
                }

                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {flightProfit:F3}$.");
                }
            }

            Console.WriteLine($"Overall profit -> {profit.Sum():F3}$.");
            Console.WriteLine($"Average profit -> {profit.Average():F3}$.");
        }
    }
}
