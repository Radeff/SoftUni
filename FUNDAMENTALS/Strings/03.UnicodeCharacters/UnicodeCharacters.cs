using System;
using System.Linq;

namespace _03.UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray().Select(x => ((int)x).ToString("X4").ToLower()).ToArray();

            Console.Write("\\u");       
            Console.WriteLine(string.Join("\\u", input));
        }
    }
}
