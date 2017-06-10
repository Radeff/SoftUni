using System;

namespace _15.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (input.Length > 0 && pattern.Length > 0)
            {
                bool beginning = false;
                bool end = false;
                var indexStart = -1;
                var indexEnd = -1;

                for (int i = 0; i < input.Length - pattern.Length; i++)
                {
                    if (input.Substring(i, pattern.Length) == pattern)
                    {
                        beginning = true;
                        indexStart = i;
                        break;
                    }
                }

                for (int i = input.Length - pattern.Length; i >= 0; i--)
                {
                    if (input.Substring(i, pattern.Length) == pattern)
                    {
                        end = true;
                        indexEnd = i;
                        break;
                    }
                }

                if (beginning && end && indexStart != indexEnd)
                {
                    input = input.Remove(indexEnd, pattern.Length);
                    input = input.Remove(indexStart, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }

                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(input);
            }
        }
    }
}
