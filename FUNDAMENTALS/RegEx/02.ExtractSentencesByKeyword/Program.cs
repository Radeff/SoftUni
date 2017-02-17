using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = new Regex($@"\b[^.!?]*{keyword}[ ,:]\w+\b[^?!.]*");
            var matches = pattern.Matches(text);

            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
