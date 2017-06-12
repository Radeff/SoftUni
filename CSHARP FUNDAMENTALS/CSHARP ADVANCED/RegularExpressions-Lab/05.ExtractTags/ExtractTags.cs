using System;
using System.Text.RegularExpressions;

namespace _05.ExtractTags
{
    public class ExtractTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex("<.+?>");

            while (input != "END")
            {
                var matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match.ToString());
                }

                input = Console.ReadLine();
            }
        }
    }
}
