using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    public class Program
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(x => x).ToArray();
                AddDragon(dragons, input);
            }

            PrintDragons(dragons);
        }

        public static void PrintDragons(Dictionary<string, SortedDictionary<string, List<int>>> dragons)
        {
            foreach (var type in dragons)
            {
                var avgDmg = type.Value.Select(x => x.Value).Select(x => x.ElementAt(0)).Average();
                var avgHealth = type.Value.Select(x => x.Value).Select(x => x.ElementAt(1)).Average();
                var avgArmor = type.Value.Select(x => x.Value).Select(x => x.ElementAt(2)).Average();
                Console.WriteLine($"{type.Key}::({avgDmg:F2}/{avgHealth:F2}/{avgArmor:F2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value.First()}, health: {name.Value.ElementAt(1)}, armor: {name.Value.Last()}");
                }
            }
        }

        public static void AddDragon(Dictionary<string, SortedDictionary<string, List<int>>> dragons, string[] input)
        {
            var type = input[0];
            var name = input[1];
            var stats = new List<int>() { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                if (input[i + 2] != "null")
                {
                    stats[i] = int.Parse(input[i + 2]);
                }

                else
                {
                    switch (i)
                    {
                        case 0: stats[0] = 45; break;

                        case 1: stats[1] = 250; break;

                        case 2: stats[2] = 10; break;
                    }
                }
            }

            if (!dragons.ContainsKey(type))
            {
                dragons.Add(type, new SortedDictionary<string, List<int>>() { { name, stats } });
            }

            else if (!dragons[type].ContainsKey(name))
            {
                dragons[type].Add(name, stats);
            }

            else
            {
                dragons[type][name].Clear();
                dragons[type][name].AddRange(stats);
            }
        }
    }
}
