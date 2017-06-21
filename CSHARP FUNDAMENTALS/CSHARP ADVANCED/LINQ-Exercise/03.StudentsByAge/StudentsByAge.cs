using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StudentsByAge
{
    public class StudentsByAge
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new Dictionary<string, int>();
            while (input[0] != "END")
            {
                var name = string.Concat(input[0], " ", input[1]);
                var age = int.Parse(input[2]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, age);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var student in students.Where(kvp => kvp.Value >= 18 && kvp.Value <= 24))
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
