using System;

namespace _04.SpecialWords
{
    public class SpecialWords
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Split();
            var separator = "[]() <>,-!?".ToCharArray();
            var text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (var specialWord in specialWords)
            {
                var counter = 0;

                foreach (var word in text)
                {
                    if (word == specialWord)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"{specialWord} - {counter}");
            }
        }
    }
}
