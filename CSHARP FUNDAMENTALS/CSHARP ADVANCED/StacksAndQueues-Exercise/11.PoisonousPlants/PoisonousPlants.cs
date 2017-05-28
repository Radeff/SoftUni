﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    public class PoisonousPlants
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var days = new int[plants.Length];
            var indexes = new Stack<int>();
            indexes.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                var maxDaysAlive = 0;

                while (indexes.Count > 0 && plants[indexes.Peek()] >= plants[i])
                {
                    maxDaysAlive = Math.Max(maxDaysAlive, days[indexes.Pop()]);
                }

                if (indexes.Count > 0)
                {
                    days[i] = maxDaysAlive + 1;
                }
                indexes.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
