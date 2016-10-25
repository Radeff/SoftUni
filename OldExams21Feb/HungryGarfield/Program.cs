using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            pizzaPrice /= rate;
            lasagnaPrice /= rate;
            sandwichPrice /= rate;

            var pizza = pizzaQuantity * pizzaPrice;
            var lasagna = lasagnaQuantity * lasagnaPrice;
            var sandwich = sandwichQuantity * sandwichPrice;

            var needed = pizza + lasagna + sandwich;
            if (money >= needed)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", money - needed);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", needed - money);
            }
        }
    }
}
