using System;
using System.Text.RegularExpressions;

namespace _03.NonDigitCount
{
    public class NonDigitCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\D");
            Console.WriteLine($"Non-digits: {regex.Matches(text).Count}");
        }
    }
}
