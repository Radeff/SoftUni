using System;
using System.Linq;

namespace _03.GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[3][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i][j] = int.MinValue;
                }
            }

            var zeroCol = 0;
            var oneCol = 0;
            var twoCol = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                var num = numbers[i];
                var division = Math.Abs(num % 3);

                if (division == 0)
                {
                    matrix[0][zeroCol] = num;
                    zeroCol++;
                }
                else if (division == 1)
                {
                    matrix[1][oneCol] = num;
                    oneCol++;
                }
                else if (division == 2)
                {
                    matrix[2][twoCol] = num;
                    twoCol++;
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i].Where(x => x != int.MinValue)));
            }
        }
    }
}
