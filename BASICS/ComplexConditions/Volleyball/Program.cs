using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            var playedSofia = (48 - h) * 3.0 / 4;
            var holidayGames = p * 2.0 / 3;
            var totalPlayed = playedSofia + holidayGames + h;
            if (y == "leap")
            {
                totalPlayed += totalPlayed * 15.0 / 100;
            }
            Console.WriteLine(Math.Truncate(totalPlayed));
        }
    }
}
