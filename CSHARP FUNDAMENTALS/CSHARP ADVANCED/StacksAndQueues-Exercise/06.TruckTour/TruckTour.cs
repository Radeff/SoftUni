using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            var pumpsNumber = int.Parse(Console.ReadLine());
            var circle = new Queue<long[]>();

            for (int i = 0; i < pumpsNumber; i++)
            {
                circle.Enqueue(Console.ReadLine().Split().Select(long.Parse).ToArray());
            }

            var possible = false;

            for (int i = 0; i < pumpsNumber; i++)
            {
                long fuel = 0;

                foreach (var pump in circle)
                {
                    fuel += pump[0];
                    fuel -= pump[1];

                    if (fuel >= 0)
                    {
                        possible = true;
                    }
                    else
                    {
                        possible = false;
                        break;
                    }
                }

                if (possible)
                {
                    Console.WriteLine(i);
                    return;
                }

                var pumpToMove = circle.Dequeue();
                circle.Enqueue(pumpToMove);
            }
        }
    }
}
