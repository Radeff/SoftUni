using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i < 10000; i++)
            {
                int first = i / 1000;
                if (n % first == 0)
                {
                    int second = (i / 100) % 10;
                    if (second != 0 && n % second == 0)
                    {
                        int third = ((i / 10) % 100) % 10;
                        if (third != 0 && n % third == 0)
                        {
                            int fourth = i % 10;
                            if (fourth != 0 && n % fourth == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
