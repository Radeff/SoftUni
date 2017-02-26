using System;

namespace _01.HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var travelDistance = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * travelDistance;
            var travelSeconds = wingFlaps / 100;
            var restSeconds = (wingFlaps / endurance) * 5;
            var totalSeconds = travelSeconds + restSeconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
