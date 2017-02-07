using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = new string[1];
            var population = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                input = Console.ReadLine().Split('|');
                PopulationCountAndPrint(population, input);
            }
        }

        public static void PopulationCountAndPrint(Dictionary<string, Dictionary<string, long>> population, string[] input)
        {
            if (input[0] == "report")
            {                
                foreach (var c in population.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    Console.WriteLine($"{c.Key} (total population: {c.Value.Values.Sum()})");
                    foreach (var t in c.Value.OrderByDescending(y => y.Value))
                    {
                        Console.WriteLine($"=>{t.Key}: {t.Value}");
                    }
                }
                
                return;
            }

            var city = input[0];
            var country = input[1];
            var pop = long.Parse(input[2]);            

            if (population.ContainsKey(country))
            {
                population[country].Add(city, pop);
            }

            else
            {
                var cityStats = new Dictionary<string, long>();
                cityStats.Add(city, pop);
                population.Add(country, cityStats);
            }            
        }
    }
}
