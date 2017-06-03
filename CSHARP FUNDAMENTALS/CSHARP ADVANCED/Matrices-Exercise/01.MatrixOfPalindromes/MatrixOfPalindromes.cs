using System;

namespace _01.MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var r = int.Parse(input[0]);
            var c = int.Parse(input[1]);

            var matrix = new string[r][];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < r; i++)
            {
                matrix[i] = new string[c];
                var chars = new char[3];

                for (int j = 0; j < c; j++)
                {
                    chars[0] = alphabet[i];
                    chars[1] = alphabet[j + i];
                    chars[2] = alphabet[i];
                    matrix[i][j] = new string(chars);
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
