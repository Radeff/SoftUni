using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double metersPerSecond = meters / totalSeconds;
            Console.WriteLine(Math.Round(metersPerSecond, 6));
            double kmPerHour = (meters / 1000.00) / (totalSeconds / 3600.00);
            Console.WriteLine(Math.Round(kmPerHour, 6));
            double milesPerHour = (meters / 1609.00) / (totalSeconds / 3600.00);
            Console.WriteLine(Math.Round(milesPerHour, 6));
        }
    }
}
