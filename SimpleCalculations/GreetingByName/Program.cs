﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
