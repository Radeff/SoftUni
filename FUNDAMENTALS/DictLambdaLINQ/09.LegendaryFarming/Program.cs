using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    public class Program
    {
        public static void Main()
        {
            var materials = new Dictionary<string, int>()
            { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            var itemName = string.Empty;

            while (itemName == string.Empty)
            {
                var input = Console.ReadLine().ToLower().Split().Select(x => x).ToArray();
                itemName = AddMaterials(materials, input);
            }

            PrintResult(materials, itemName);
        }

        private static void PrintResult(Dictionary<string, int> materials, string itemName)
        {
            Console.WriteLine($"{itemName} obtained!");

            foreach (var mat in materials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => x)
                .Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes"))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
                materials.Remove(mat.Key);
            }

            foreach (var junk in materials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }

        private static string AddMaterials(Dictionary<string, int> materials, string[] input)
        {
            var found = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!materials.ContainsKey(input[i + 1]))
                {
                    materials.Add(input[i + 1], int.Parse(input[i]));
                }

                else
                {
                    materials[input[i + 1]] += int.Parse(input[i]);
                }

                i++;

                if (materials["shards"] >= 250)
                {
                    materials["shards"] -= 250;
                    found = "Shadowmourne";
                    break;
                }

                else if (materials["fragments"] >= 250)
                {
                    materials["fragments"] -= 250;
                    found = "Valanyr";
                    break;
                }

                else if (materials["motes"] >= 250)
                {
                    materials["motes"] -= 250;
                    found = "Dragonwrath";
                    break;
                }

            }

            return found;
        }
    }
}