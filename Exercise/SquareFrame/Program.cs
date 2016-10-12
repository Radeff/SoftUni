using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine('+' + new string('-', n) + '+');
                }
                else
                {
                    Console.WriteLine('|' + new string('-', n) + '|');
                }
            }
        }
    }
}
