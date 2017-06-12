using System;
using System.Text.RegularExpressions;

namespace _04.ExtractIntegerNumbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\d+");
            var matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.ToString());
                }
            }
        }
    }
}
