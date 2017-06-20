using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MapDistricts
{
    public class MapDistricts
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            var cities = new Dictionary<string, List<long>>();

            foreach (var pair in data)
            {
                var cityDistrict = pair.Split(':').ToArray();
                var city = cityDistrict[0];
                var population = long.Parse(cityDistrict[1]);

                if (!cities.ContainsKey(city))
                {
                    var pop = new List<long>();
                    cities.Add(city, pop);
                }
                cities[city].Add(population);
            }

            var limit = long.Parse(Console.ReadLine());
            var filtered = cities.Where(kvp => kvp.Value.Sum() >= limit);

            foreach (var kvp in filtered.OrderByDescending(kvp => kvp.Value.Sum()))
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(" ", kvp.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}
