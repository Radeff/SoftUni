using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var yearsOld = int.Parse(input[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, yearsOld);
                }
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var filter = Console.ReadLine();
            FilterPrinter(condition, age, filter, people);
        }

        private static void FilterPrinter(string condition, int age, string filter, Dictionary<string, int> people)
        {
            foreach (var person in people.Where(kvp => condition == "older" ? kvp.Value >= age : kvp.Value < age))
            {
                if (filter == "name")
                {
                    Console.WriteLine(person.Key);
                }
                else if (filter == "age")
                {
                    Console.WriteLine(person.Value);
                }
                else
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }
    }
}
