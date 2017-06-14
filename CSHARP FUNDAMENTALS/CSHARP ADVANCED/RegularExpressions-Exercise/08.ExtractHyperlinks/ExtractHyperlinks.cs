using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var html = new StringBuilder();
            var input = Console.ReadLine();

            while (input != "END")
            {
                html.Append(input);
                input = Console.ReadLine();
            }
            
            var regex = new Regex(@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>");
            var matches = regex.Matches(html.ToString());

            foreach (Match match in matches)
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (match.Groups[i].Length > 0)
                    {
                        Console.WriteLine(match.Groups[i]);
                    }
                }
            }
        }
    }
}