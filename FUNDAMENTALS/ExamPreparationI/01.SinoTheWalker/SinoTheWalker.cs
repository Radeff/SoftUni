using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var departure = TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine()) % 86400;
            var stepTime = int.Parse(Console.ReadLine()) % 86400;            
            var timeWalking = TimeSpan.FromSeconds(stepTime * steps);
            var arrival = departure.Add(timeWalking);
            Console.WriteLine($"Time Arrival: {arrival.ToString("hh\\:mm\\:ss")}");            
        }
    }
}
