using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            var stars = 1;
            var mid = n - 2 * leftRight - 2;
            for (int i = 1; i <= (n - 1) / 2 ; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*', stars));
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-', leftRight));
                leftRight--;
                mid += 2;
                Console.WriteLine();
            }
            for (int i = 1; i <= (n+1) / 2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*', stars));
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-', leftRight));
                leftRight++;
                mid -= 2;
                Console.WriteLine();
            }         
        }
    }
}
