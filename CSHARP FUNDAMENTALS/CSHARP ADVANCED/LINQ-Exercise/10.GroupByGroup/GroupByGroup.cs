using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.GroupByGroup
{
    public class GroupByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new List<Student>();
            while (input[0] != "END")
            {
                var name = string.Concat(input[0], " ", input[1]);
                var group = int.Parse(input[2]);
                var student = new Student {Name = name, Group = group};

                if (!students.Contains(student))
                {
                    students.Add(student);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var group in students.GroupBy(s => s.Group).ToList().OrderBy(g => g.Key))
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.Select(s => s.Name))}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
