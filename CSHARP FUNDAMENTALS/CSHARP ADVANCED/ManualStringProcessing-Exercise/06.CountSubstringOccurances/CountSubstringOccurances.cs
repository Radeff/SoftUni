using System;

namespace _06.CountSubstringOccurances
{
    public class CountSubstringOccurances
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var textCut = text.Substring(i, text.Length - i);

                if (textCut.Contains(pattern))
                {
                    i += textCut.IndexOf(pattern);
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
