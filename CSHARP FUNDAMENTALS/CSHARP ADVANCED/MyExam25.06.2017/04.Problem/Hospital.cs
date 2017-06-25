using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Problem
{
    public class Hospital
    {
        public static void Main()
        {
            var beds = new Dictionary<string, int>();
            //key - department, value - bed number
            var patients = new List<Patient>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Output")
            {
                var split = input.Split();
                if (split.Length == 4)
                {
                    var department = split[0];
                    var doctor = string.Concat(split[1], split[2]);
                    var name = split[3];

                    var patient = new Patient()
                    {
                        Name = name,
                        Doctor = doctor,
                        Department = department
                    };

                    if (!beds.ContainsKey(department))
                    {
                        beds.Add(department, 1);
                    }
                    else
                    {
                        if (beds[department] == 60)
                        {
                            continue;
                        }

                        beds[department]++;
                    }

                    patient.Room = (int)Math.Ceiling(beds[department] / 3.0);
                    patients.Add(patient);
                }
            }

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                var split = command.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 1)
                {
                    foreach (var patient in patients.Where(p => p.Department == split[0]))
                    {
                        Console.WriteLine(patient.Name);
                    }
                }
                if (split.Length == 2)
                {
                    var n = 0;
                    if (int.TryParse(split[1], out n))
                    {
                        foreach (var patient in patients
                            .Where(p => p.Department == split[0] 
                            && p.Room == int.Parse(split[1]))
                            .OrderBy(p => p.Name))
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                    else
                    {
                        var doc = string.Concat(split[0], split[1]);
                        foreach (var patient in patients.Where(p => p.Doctor == doc).OrderBy(p => p.Name))
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                }
            }
        }
    }

    public class Patient
    {
        public string Name { get; set; }

        public string Department { get; set; }
        public int Room { get; set; }

        public string Doctor { get; set; }
    }
}
