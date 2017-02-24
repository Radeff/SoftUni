using System;
using System.Linq;

namespace _02.TrophonTheGrumpyCat
{
    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            var items = Console.ReadLine().Split().Select(long.Parse).ToList();
            var entryPoint = int.Parse(Console.ReadLine());
            var cheapExpensive = Console.ReadLine();
            var allPosNeg = Console.ReadLine();

            var itemsLeft = items
                .Take(entryPoint)
                .Select(i => i)
                .Where(i => cheapExpensive == "cheap" ? i < items[entryPoint] : i >= items[entryPoint])
                .ToList();

            var itemsRight = items
                    .Skip(entryPoint + 1)
                    .Select(i => i)
                    .Where(i => cheapExpensive == "cheap" ? i < items[entryPoint] : i >= items[entryPoint])
                    .ToList();

            long sumLeft = itemsLeft
                .Select(i => i)
                .Where(i => allPosNeg == "all" ? i == i : (allPosNeg == "positive" ? i > 0 : i < 0))
                // nested conditional operators! Turn GodMode code reading ON!
                // if all (all), else (if positive (positive), else (negative))
                .Sum();

            long sumRight = itemsRight
                .Select(i => i)
                .Where(i => allPosNeg == "all" ? i == i : (allPosNeg == "positive" ? i > 0 : i < 0))
                .Sum();

            if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }

            else
            {
                Console.WriteLine($"Right - {sumRight}");
            }
        }
    }
}