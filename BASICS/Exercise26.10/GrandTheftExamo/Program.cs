using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftExamo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long thievesSlap = 0;
            long thievesEsc = 0;
            long totalBeer = 0;

            for (int i = 0; i < n; i++)
            {
                var thieves = long.Parse(Console.ReadLine());
                var beer = long.Parse(Console.ReadLine());
                if (thieves > 5)
                {
                    thievesSlap += 5;
                    thievesEsc += thieves - 5;
                }
                else
                {
                    thievesSlap += thieves;
                }
                totalBeer += beer;       
            }
            Console.WriteLine(thievesSlap + " thieves slapped.");
            Console.WriteLine(thievesEsc + " thieves escaped.");
            Console.WriteLine(totalBeer / 6 + " packs, " + totalBeer % 6 + " bottles."); 
        }
    }
}
