using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterD = 0;
            string answers = "";
            for (int i = 0; i < n; i++)
            {
                var answer = uint.Parse(Console.ReadLine());
                if (answer % 4 == 0)
                {
                    answers += "a ";
                    counterA++;
                }
                if (answer % 4 == 1)
                {
                    answers += "b ";
                    counterB++;
                }
                if (answer % 4 == 2)
                {
                    answers += "c ";
                    counterC++;
                }
                if (answer % 4 == 3)
                {
                    answers += "d ";
                    counterD++;
                }       
            }
            Console.WriteLine(answers);
            Console.WriteLine("Answer A: " + counterA);
            Console.WriteLine("Answer B: " + counterB);
            Console.WriteLine("Answer C: " + counterC);
            Console.WriteLine("Answer D: " + counterD);
        }
    }
}
