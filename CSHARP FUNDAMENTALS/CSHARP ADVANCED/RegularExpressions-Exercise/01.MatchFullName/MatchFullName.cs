using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z]{1}[a-z]+\b\ \b[A-Z]{1}[a-z]+\b");

            while (input != "end")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match.ToString());
                }

                input = Console.ReadLine();
            }
        }
    }
}
