using System;

namespace _04.PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new long[n][];

            if (n > 0)
            {
                matrix[0] = new long[1] { 1 };
            }
            if (n > 1)
            {
                matrix[1] = new long[2] { 1, 1 };
            }

            for (int i = 2; i < n; i++)
            {
                matrix[i] = new long[i+1];

                matrix[i][0] = 1;
                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
                }
                matrix[i][matrix[i].Length - 1] = 1;
            }

            if (matrix.Length > 0)
            {
                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join(" ", row));
                }
            }
        }
    }
}
