using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = 1;
            var middleDots = 2 * n;

            for (int i = 0; i <= 3 * n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("##" + new string('.', 2 * n) + "##" + new string('.', 2 * n) + "##");
                }
                else if (i > 0 && i < n)
                {
                    Console.WriteLine("#" + new string('~', i) + "#" + new string('.', (2 * n) - (2 * i)) + "#" + new string('.', i * 2) + "#" + new string('.', 2 * n - (2 * i)) + "#" + new string('~', i) + "#");
                }
                else if (i >= n && i < 3 * n - n + 1)
                {
                    Console.WriteLine(new string('.', dots) + "#" + new string('~', Math.Abs(2 * n - i)) + "#" + new string('.', middleDots) + "#" + new string('~', Math.Abs(2 * n - i)) + "#" + new string('.', dots));
                    dots += 2;
                    middleDots -= 2;
                }
                else if (i == 2 * n)
                {
                    Console.WriteLine(new string('.', 2 * n + 1) + "####" + new string('.', 2 * n + 1));
                }
                else
                {
                    Console.WriteLine(new string('.', 2 * n + 2) + "##" + new string('.', 2 * n + 2));

                }
            }
        }
    }
}
