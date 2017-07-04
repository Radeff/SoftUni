using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
    public class CompanyRoster
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var email = "n/a";
                var age = -1;
                var input = Console.ReadLine().Split();

                if (input.Length > 4)
                {
                    int number;
                    var isDigit = int.TryParse(input[4], out number);

                    if (isDigit)
                    {
                        age = number;
                    }
                    else
                    {
                        email = input[4];
                    }

                    if (input.Length > 5)
                    {
                        if (isDigit)
                        {
                            email = input[5];
                        }
                        else
                        {
                            age = int.Parse(input[5]);
                        }
                    }
                }

                var employee = new Employee(
                    input[0],
                    decimal.Parse(input[1]),
                    input[2],
                    input[3],
                    email,
                    age
                );

                employees.Add(employee);
            }

            var department = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(g => g.Select(e => e.Salary).Sum())
                .First();

            Console.WriteLine($"Highest Average Salary: {department.Key}");
            foreach (var employee in department.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
