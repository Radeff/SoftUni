using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                   set.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
