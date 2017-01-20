using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int q = i; q <= n; q++)
                {
                    Console.Write(q + " ");
                    if (q == n && i > 1 )
                    {
                        for (int j = n-1; j >= n-i+1; j--)
                        {
                            Console.Write(j + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
