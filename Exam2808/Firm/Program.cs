using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededDays = int.Parse(Console.ReadLine());
            var availableDays = double.Parse(Console.ReadLine());
            var overtime = int.Parse(Console.ReadLine());
            double available = Math.Floor((availableDays - (availableDays * 10 / 100)) * 8.0);
            double total = available + (overtime * (availableDays * 2.0));
            if (total >= neededDays)
            {
                Console.WriteLine("Yes!{0} hours left.", total - neededDays);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(total - neededDays));
            }
        }
    }
}
