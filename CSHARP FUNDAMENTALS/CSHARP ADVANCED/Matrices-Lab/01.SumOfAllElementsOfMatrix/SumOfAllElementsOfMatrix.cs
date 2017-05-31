using System;
using System.Linq;

namespace _01.SumOfAllElementsOfMatrix
{
    public class SumOfAllElementsOfMatrix
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var matrix = new int[int.Parse(matrixSize[0])][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i].Sum();
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
