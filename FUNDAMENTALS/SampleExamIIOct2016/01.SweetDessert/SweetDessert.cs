using System;

namespace _01.SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berryPrice = decimal.Parse(Console.ReadLine());

            var portionPrice = 2 * bananaPrice + 4 * eggPrice + 0.2M * berryPrice;

            var portions = guests / 6;

            if (guests % 6 != 0)
            {
                portions++;
            }

            var moneyNeeded = portions * portionPrice;

            if (money >= moneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - money):F2}lv more.");
            }
        }
    }
}