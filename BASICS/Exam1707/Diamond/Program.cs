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
            Console.WriteLine(new string('.', n) + new string('*', n * 3) + new string('.', n));
            int dots = n-1;
            int dots_mid = 3 * n;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string('.', dots) + "*" + new string('.', dots_mid) + "*" + new string('.', dots));
                dots--;
                dots_mid += 2;
            }
            Console.WriteLine(new string('*', 5 * n));
            dots = 1;
            dots_mid = 5 * n - 4;
            for (int i = 1; i < 2 * n + 1; i++)
            {
                Console.WriteLine(new string('.', dots) + "*" + new string('.', dots_mid) + "*" + new string('.', dots));
                dots++;
                dots_mid -= 2;
            }
            Console.WriteLine(new string('.', dots) + new string('*', dots_mid + 2) + new string('.', dots));
        }
    }
}
