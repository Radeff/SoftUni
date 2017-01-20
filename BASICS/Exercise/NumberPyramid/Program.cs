﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                if (num > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
