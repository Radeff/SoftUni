using System;
using System.Text.RegularExpressions;

namespace _06.SentenceExtractor
{
    public class SentenceExtractor
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex($@"[^.!?]+?\b{keyword}\b[^.!?]+?[!?.]");
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
