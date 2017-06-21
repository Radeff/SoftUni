using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.WeakStudents
{
    public class WeakStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new Dictionary<string, List<int>>();
            while (input[0] != "END")
            {
                var name = string.Concat(input[0], " ", input[1]);
                var grades = new List<int>()
                {
                    int.Parse(input[2]),
                    int.Parse(input[3]),
                    int.Parse(input[4]),
                    int.Parse(input[5])
                };

                if (!students.ContainsKey(name))
                {
                    students.Add(name, grades);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var student in students.Where(s => s.Value.Count(n => n <= 3) >= 2))
            {
                Console.WriteLine($"{student.Key}");
            }
        }
    }
}
