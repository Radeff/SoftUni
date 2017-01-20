using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b - a < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i1 = a; i1 <= b - 3; i1++)
                {
                    for (int i2 = i1 + 1; i2 <= b - 2; i2++)
                    {
                        for (int i3 = i2 + 1; i3 <= b - 1; i3++)
                        {
                            for (int i4 = i3 + 1; i4 <= b; i4++)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", i1, i2, i3, i4);
                            }
                        }
                    }
                }
            }
        }
    }
}
