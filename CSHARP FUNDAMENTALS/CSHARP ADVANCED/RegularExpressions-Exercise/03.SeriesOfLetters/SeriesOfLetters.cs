﻿using System;
using System.Text.RegularExpressions;

namespace _03.SeriesOfLetters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(\w)\1{1,}");
            input = regex.Replace(input, "$1");
            
            Console.WriteLine(input);
        }
    }
}
