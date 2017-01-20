using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var frWeight = int.Parse(Console.ReadLine());
            var vegWeight = int.Parse(Console.ReadLine());
            var result = (vegPrice * vegWeight) + (fruitPrice * frWeight);
            Console.WriteLine(result = result * 1.94);
        }
    }
}
