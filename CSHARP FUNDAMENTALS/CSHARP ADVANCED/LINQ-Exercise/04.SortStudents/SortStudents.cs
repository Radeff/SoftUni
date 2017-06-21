using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStudents
{
    public class SortStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new List<KeyValuePair<string,string>>();
            while (input[0] != "END")
            {
                var firstName = input[0];
                var lastName = input[1];
                students.Add(new KeyValuePair<string, string>(firstName,lastName));

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var student in students.OrderBy(s => s.Value).ThenByDescending(s => s.Key))
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
