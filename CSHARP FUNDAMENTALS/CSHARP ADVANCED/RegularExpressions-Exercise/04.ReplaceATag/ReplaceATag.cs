using System;
using System.Text.RegularExpressions;

namespace _04.ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"<a(.*?href.*?=.*?)>(.*?)<\/a>");
            //gr1 - href, gr2 - tag content, 
            while (input != "end")
            {
                var replacement = "[URL$1]$2[/URL]";
                var result = regex.Replace(input, replacement);
                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
