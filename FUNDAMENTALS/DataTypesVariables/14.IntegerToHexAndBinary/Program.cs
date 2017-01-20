using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string text = Convert.ToString(input, 16);
            text = text.ToUpper();
            Console.WriteLine(text);
            string binary = Convert.ToString(input, 2);
            Console.WriteLine(binary);
        }
    }
}
