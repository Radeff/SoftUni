using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StudentsEnrolledIn2014Or2015
{
    public class StudentsEnrolledIn2014Or2015
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new Dictionary<string, List<string>>();
            while (input[0] != "END")
            {
                var facNumber = input[0];
                var grades = new List<string>()
                {
                    input[1],
                    input[2],
                    input[3],
                    input[4],
                };

                if (!students.ContainsKey(facNumber))
                {
                    students.Add(facNumber, grades);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var student in students.Where(s => s.Key.EndsWith("14") || s.Key.EndsWith("15")))
            {
                Console.WriteLine(string.Join(" ", student.Value));
            }
        }
    }
}
