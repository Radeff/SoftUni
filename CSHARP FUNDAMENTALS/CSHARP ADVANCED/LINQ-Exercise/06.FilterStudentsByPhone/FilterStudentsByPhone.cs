using System;
using System.Linq;

namespace _06.FilterStudentsByPhone
{
    public class FilterStudentsByPhone
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputSplit = input.Split().ToArray();
                if (inputSplit.Length == 3 && inputSplit[2].StartsWith("02") || inputSplit[2].StartsWith("+3592"))
                {
                    Console.WriteLine(string.Concat(inputSplit[0], " ", inputSplit[1]));
                }

                input = Console.ReadLine();
            }
        }
    }
}
