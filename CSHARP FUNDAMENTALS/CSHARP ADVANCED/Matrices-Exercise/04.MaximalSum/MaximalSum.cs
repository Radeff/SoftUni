using System;

namespace _04.MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine().Split();
            var rows = int.Parse(matrixSizes[0]);
            var cols = int.Parse(matrixSizes[1]);
            var matrix = new long[rows][];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split();
                matrix[i] = new long[cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = long.Parse(input[j]);
                }
            }

            long maxSum = 0;
            var indexRow = 0;
            var indexCol = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    long currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                                      matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                                      matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = indexRow; i <= indexRow + 2; i++)
            {
                for (int j = indexCol; j <= indexCol + 2; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
