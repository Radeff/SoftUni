﻿using System;
using System.Text;
using System.Threading.Tasks;


namespace TriangleArea
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a * h) / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}