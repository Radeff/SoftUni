using System;
using System.Text.RegularExpressions;

namespace _01.MatchCount
{
    public class MatchCount
    {
        public static void Main()
        {
            var search = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex(search);
            var matches = regex.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}
