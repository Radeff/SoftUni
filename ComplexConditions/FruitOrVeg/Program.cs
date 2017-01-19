using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVeg
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = Console.ReadLine();
            if (prod == "banana" || prod == "apple" || prod == "kiwi" || prod == "cherry" || prod == "lemon" || prod == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (prod == "tomato" || prod == "cucumber" || prod == "pepper" || prod == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
