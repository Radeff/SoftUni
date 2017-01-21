using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char symbol = Convert.ToChar(input);
            int ascii = Convert.ToInt16(symbol);
            if (ascii >= 48 && ascii <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (ascii == 97 || ascii == 101 || ascii == 105 || ascii == 111 || ascii == 117)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
