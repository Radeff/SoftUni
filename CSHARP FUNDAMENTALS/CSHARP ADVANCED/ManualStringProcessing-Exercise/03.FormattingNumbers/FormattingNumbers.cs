using System;

namespace _03.FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(numbers[0]);
            var aConv = Convert.ToString(a, 2);

            if (aConv.Length > 10)
            {
                aConv = aConv.Substring(0, 10);
            }
            else
            {
                aConv = aConv.PadLeft(10, '0');
            }

            var b = double.Parse(numbers[1]);
            var c = double.Parse(numbers[2]);


            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, aConv, b, c);
        }
    }
}
