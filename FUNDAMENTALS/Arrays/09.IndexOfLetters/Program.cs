using System;

namespace _09.IndexOfLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            PrintLetterIndex(input);
        }

        public static void PrintLetterIndex(char[] input)
        {
            var alphabet = new char[26];
            char letter = 'a';

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = letter;
                letter++;
            }

            for (int j = 0; j < input.Length; j++)
            {
                for (int q = 0; q < alphabet.Length; q++)
                {
                    if (input[j] == alphabet[q])
                    {
                        Console.WriteLine($"{input[j]} -> {q}");
                    }
                }
            }
        }
    }
}
