using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                List<double> grades = input.Skip(1).Select(double.Parse).ToList();                
                var student = new Student() { Name = name, Grades = grades};
                students.Add(student);
            }

            foreach (var student in students.Where(x => x.Average >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:F2}");
            }
        }        
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average { get { return Grades.Average(); } }        
    }

}
