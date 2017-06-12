using System;
using System.Text.RegularExpressions;

namespace _02.VowelCount
{
    public class VowelCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var vowels = "[aeiouyAEIOUY]";
            var regex = new Regex(vowels);
            Console.WriteLine($"Vowels: {regex.Matches(text).Count}");
        }
    }
}
