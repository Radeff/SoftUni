using System;
using System.Linq;

namespace _03.EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var racers = Console.ReadLine()
                .Split()
                .ToArray();

            var zones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var racer in racers)
            {
                double fuel = racer.First();                

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                    }

                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{racer} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{racer} - fuel left {fuel:F2}");
                }                
            }
        }
    }
}
