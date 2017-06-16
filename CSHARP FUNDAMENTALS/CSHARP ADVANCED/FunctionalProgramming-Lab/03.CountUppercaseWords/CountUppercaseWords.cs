using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    public class CountUppercaseWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();
            Func<string, bool> FirstUpperCase = s => s.Length > 0 && (s[0] >= 'A' && s[0] <= 'Z');

            var UpperCaseWords = words.Where(w => FirstUpperCase(w));
            Console.WriteLine(string.Join("\r\n", UpperCaseWords));
        }
    }
}
