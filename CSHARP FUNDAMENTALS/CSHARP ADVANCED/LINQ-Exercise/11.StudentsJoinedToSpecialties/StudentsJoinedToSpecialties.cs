using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.StudentsJoinedToSpecialties
{
    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var students = new List<Student>();
            var specialties = new List<Specialty>();

            while (input[0] != "Students:")
            {
                var name = string.Concat(input[0], " ", input[1]);
                var number = input[2];
                var specialty = new Specialty() { Name = name, Number = number};
                specialties.Add(specialty);
                input = Console.ReadLine().Split().ToArray();
            }

            input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                var name = string.Concat(input[1], " ", input[2]);
                var number = input[0];
                var student = new Student { Name = name, Number = number};
                students.Add(student);
                input = Console.ReadLine().Split().ToArray();
            }

            var studentsSpecialties = students.Join(specialties, st => st.Number, sp => sp.Number,
                (st, sp) => new 
                {
                    st.Name,
                    st.Number,
                    Specialty = sp.Name
                });

            foreach (var st in studentsSpecialties.OrderBy(st => st.Name))
            {
                Console.WriteLine($"{st.Name} {st.Number} {st.Specialty}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public string Number { get; set; }
    }

    public class Specialty
    {
        public string Name { get; set; }

        public string Number { get; set; }
    }
}
