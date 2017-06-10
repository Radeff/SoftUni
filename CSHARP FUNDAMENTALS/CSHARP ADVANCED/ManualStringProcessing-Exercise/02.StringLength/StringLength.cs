﻿using System;

namespace _02.StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
