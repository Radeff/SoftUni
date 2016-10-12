using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
