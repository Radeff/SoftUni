using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var m = input[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            if (n >= m)
            {
                foreach (var num in firstSet)
                {
                    if (secondSet.Contains(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            else
            {
                foreach (var num in secondSet)
                {
                    if (firstSet.Contains(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
