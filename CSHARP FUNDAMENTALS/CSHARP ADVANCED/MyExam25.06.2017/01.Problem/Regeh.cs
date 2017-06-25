using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Problem
{
    public class Regeh
    {
        public static void Main()
        {
            var regex = new Regex(@"\[[^\[\]\s]+?<(\d+)REGEH(\d+)>[^\[\]\s]+?\]");
            var input = Console.ReadLine();

            var matches = regex.Matches(input);
            var indexes = new List<int>();

            foreach (Match match in matches)
            { 
                indexes.Add(int.Parse(match.Groups[1].Value));
                indexes.Add(int.Parse(match.Groups[2].Value));
            }

            var sb = new StringBuilder();

            var index = 0;
            for (int i = 0; i < indexes.Count; i++)
            {
                index += indexes[i];
                if (index > input.Length)
                {
                    index = index - input.Length - 1;
                }
                sb.Append(input[index]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
