using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsByGroup
{
    public class StudentsByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new SortedDictionary<string, int>();
            while (input[0] != "END")
            {
                var name = string.Concat(input[0], " ", input[1]);
                var group = int.Parse(input[2]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, group);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var student in students.Where(kvp => kvp.Value == 2))
            {
                Console.WriteLine(student.Key);
            }
        }
    }
}
