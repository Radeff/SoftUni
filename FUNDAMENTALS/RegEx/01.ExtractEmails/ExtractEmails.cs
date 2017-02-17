using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"\b(?<!\S)[a-zA-Z0-9]+[-._]*\w*@\w+([.-]*\w)*\.\w+\b"); // (?<!\S) - Look behind!
            var matches = pattern.Matches(input);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
