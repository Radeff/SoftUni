using System;

namespace _02.DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];

            var leftDiagonal = 0;
            var rightDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine()
                    .Split();
                
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = int.Parse(numbers[j]);
                }

                leftDiagonal += matrix[i][i];
            }

            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                    rightDiagonal += matrix[i][j];
            }

            Console.WriteLine(Math.Abs(leftDiagonal - rightDiagonal));
        }
    }
}
