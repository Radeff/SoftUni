using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 100);
            string line = "";
            for (int i = 0; i < n; i++)
            {
                line += "*";
            }
            Console.WriteLine(line);
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('*');
                for (int j = 0; j < n-2; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }
            Console.WriteLine(line);
        }
    }
}