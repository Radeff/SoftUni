using System;

namespace _03.SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine().Split();
            var rows = int.Parse(matrixSizes[0]);
            var cols = int.Parse(matrixSizes[1]);
            var matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split();
                matrix[i] = new string[cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = input[j];
                }
            }

            var counter = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1]
                        && matrix[i + 1][j] == matrix[i + 1][j + 1]
                        && matrix[i][j] == matrix[i + 1][j + 1]
                        )
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
