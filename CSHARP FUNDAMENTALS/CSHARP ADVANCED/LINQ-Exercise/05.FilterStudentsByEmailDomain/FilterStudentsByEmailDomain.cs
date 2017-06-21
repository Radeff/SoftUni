using System;
using System.Linq;

namespace _05.FilterStudentsByEmailDomain
{
    public class FilterStudentsByEmailDomain
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputSplit = input.Split().ToArray();
                if (inputSplit.Length == 3 && inputSplit[2].EndsWith("@gmail.com"))
                {
                    Console.WriteLine(string.Concat(inputSplit[0], " ", inputSplit[1]));
                }

                input = Console.ReadLine();
            }
        }
    }
}
