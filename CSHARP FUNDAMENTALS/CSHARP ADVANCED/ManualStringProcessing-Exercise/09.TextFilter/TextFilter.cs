using System;

namespace _09.TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            var banlist = Console.ReadLine()
                .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var bannedWord in banlist)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
