using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main()
        {
            var totalWater = decimal.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            var capacity = long.Parse(Console.ReadLine());

            var bottlesLeftIndexes = new List<int>();
            var bottlesLeft = 0;

            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    var waterToFill = capacity - bottles[i];
                    totalWater -= waterToFill;

                    if (totalWater < 0)
                    {
                        bottlesLeft++;
                        bottlesLeftIndexes.Add(i);
                    }
                }
            }

            else
            {
                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    var waterToFill = capacity - bottles[i];
                    totalWater -= waterToFill;

                    if (totalWater < 0)
                    {
                        bottlesLeft++;
                        bottlesLeftIndexes.Add(i);
                    }
                }
            }

            if (totalWater < 0)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft}");
                Console.WriteLine($"With indexes: {string.Join(", ", bottlesLeftIndexes)}");
                Console.WriteLine($"We need {Math.Abs(totalWater)} more liters!");
            }

            else
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalWater}l.");
            }
        }
    }
}
