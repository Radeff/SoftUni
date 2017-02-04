using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    public class Program
    {
        public static void Main()
        {
            var input = string.Empty;
            var ores = new Dictionary<string, int>();

            while (input != "stop")
            {
                input = Console.ReadLine();
                AddAndPrintOre(ores, input);
            }            
        }

        public static void AddAndPrintOre(Dictionary<string, int> ores, string ore)
        {            
            if (ore == "stop")
            {
                foreach (var item in ores)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

                return;
            }

            else if (!ores.ContainsKey(ore))
            {
                ores.Add(ore, int.Parse(Console.ReadLine()));
            }       
                 
            else
            {
                ores[ore] += int.Parse(Console.ReadLine());
            }            
        }
    }
}