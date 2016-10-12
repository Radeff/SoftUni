using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int blanks = n - 1;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', blanks));
                for (int i = 0; i < row; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                blanks--;
            }
            blanks = 1;
            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write(new string(' ', blanks));
                for (int i = row; i > 0; i--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                blanks++;
            }
        }
    }
}
