﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write(Convert.ToChar(i)+" ");
            }
            Console.WriteLine();
        }
    }
}
