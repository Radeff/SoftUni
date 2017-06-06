using System;

namespace _05.RubiksMatrix
{
    public class RubiksMatrix
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine().Split();
            var r = int.Parse(matrixSizes[0]);
            var c = int.Parse(matrixSizes[1]);
            var matrix = new int[r][];
            var filler = 1;

            for (int i = 0; i < r; i++)
            {
                matrix[i] = new int[c];

                for (int j = 0; j < c; j++)
                {
                    matrix[i][j] = filler;
                    filler++;
                }
            }

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                var rowcol = int.Parse(command[0]);
                var dir = command[1];
                var moves = int.Parse(command[2]);

                if (dir == "left")
                {
                    RowMove(rowcol, dir, moves, matrix);
                }
                else if (dir == "right")
                {
                    RowMove(rowcol, dir, moves, matrix);
                }
                else if (dir == "up")
                {
                    ColMove(rowcol, dir, moves, matrix);
                }
                else
                {
                    ColMove(rowcol, dir, moves, matrix);
                }
            }

            Console.WriteLine();

            filler = 1;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i][j] == filler)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var swapRow = 0;
                        var swapCol = 0;
                        for (int k = 0; k < r; k++)
                        {
                            for (int l = 0; l < c; l++)
                            {
                                if (matrix[k][l] == filler)
                                {
                                    var swapNumber = matrix[i][j];
                                    matrix[i][j] = matrix[k][l];
                                    matrix[k][l] = swapNumber;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({k}, {l})");
                                }
                            }
                        }
                    }

                    filler++;
                }
            }

            Console.WriteLine();
        }

        private static void ColMove(int rowcol, string dir, int moves, int[][] matrix)
        {
            if (dir == "up")
            {
                for (int i = 0; i < moves % matrix[0].Length; i++)
                {
                    var first = matrix[0][rowcol];
                    for (int j = 1; j < matrix.Length; j++)
                    {
                        matrix[j - 1][rowcol] = matrix[j][rowcol];
                    }
                    matrix[matrix.Length - 1][rowcol] = first;
                }
            }
            else
            {
                for (int i = 0; i < moves % matrix[0].Length; i++)
                {
                    var last = matrix[matrix.Length - 1][rowcol];
                    for (int j = matrix.Length - 1; j > 0; j--)
                    {
                        matrix[j][rowcol] = matrix[j - 1][rowcol];
                    }
                    matrix[0][rowcol] = last;
                }
            }
        }

        private static void RowMove(int rowcol, string dir, int moves, int[][] matrix)
        {
            if (dir == "right")
            {
                for (int i = 0; i < moves % matrix.Length; i++)
                {
                    var last = matrix[rowcol][matrix.Length - 1];
                    for (int j = matrix.Length - 1; j > 0; j--)
                    {
                        matrix[rowcol][j] = matrix[rowcol][j - 1];
                    }
                    matrix[rowcol][0] = last;
                }
            }
            else
            {
                for (int i = 0; i < moves % matrix.Length; i++)
                {
                    var first = matrix[rowcol][0];
                    for (int j = 0; j < matrix.Length - 1; j++)
                    {
                        matrix[rowcol][j] = matrix[rowcol][j + 1];
                    }
                    matrix[rowcol][matrix.Length - 1] = first;
                }
            }
        }
    }
}
