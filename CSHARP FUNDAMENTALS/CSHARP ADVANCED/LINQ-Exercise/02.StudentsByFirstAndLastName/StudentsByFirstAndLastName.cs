using System;
using System.Linq;

namespace _02.StudentsByFirstAndLastName
{
    public class StudentsByFirstAndLastName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputSplit = input
                    .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputSplit.Length == 2 && inputSplit[0].CompareTo(inputSplit[1]) < 0)
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
