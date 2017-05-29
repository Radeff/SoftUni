using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, double[]>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, grades);
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value.Average()}");
            }
        }
    }
}
