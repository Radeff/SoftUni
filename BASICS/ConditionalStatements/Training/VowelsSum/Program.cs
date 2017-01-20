using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var currentChar = text[i];
                if (currentChar == 'a')
                {
                    sum += 1;
                }
                else if (currentChar == 'e')
                {
                    sum += 2;
                }
                else if (currentChar == 'i')
                {
                    sum += 3;
                }
                else if (currentChar == 'o')
                {
                    sum += 4;
                }
                else if (currentChar == 'u')
                {
                    sum += 5;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
