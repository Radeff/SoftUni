using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var wage = double.Parse(Console.ReadLine());
            var rate = double.Parse(Console.ReadLine());
            var month = days * wage;
            var year = (month * 12) + (month * 2.5);
            var total = year - (year * 25 / 100);
            Console.WriteLine(Math.Round((total * rate) / 365.0, 2));
        }
    }
}
