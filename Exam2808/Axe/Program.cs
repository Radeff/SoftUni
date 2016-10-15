using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rows = 0;
            if (n % 2 == 0)
            {
                rows = 2 * n;
            }
            else
            {
                rows = 2 * n - 1;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('-', 3 * n) + '*' + new string('-', i-1) + '*' + new string('-', 2 * n - i - 1));
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('*', 3 * n) + '*' + new string('-', n - 1) + '*' + new string('-', n - 1));
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (i == (n / 2) - 1)
                {
                Console.WriteLine(new string('-', 3 * n - i) + '*' + new string('*', n - 1 +  2 * i ) + '*' + new string('-', n - 1 - i));
                }
                else
                {
                    Console.WriteLine(new string('-', 3 * n - i) + '*' + new string('-', n - 1 + 2 * i) + '*' + new string('-', n - 1 - i));
                }
            }
        }
    }
}
