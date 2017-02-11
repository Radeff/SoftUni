using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.StudentGroups
{
    public class StudentGroups
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var towns = new List<Town>();

            while (input != "End")
            {
                var townName = string.Empty;
                var seats = 0;

                if (input.Contains("=>"))
                {
                    var inputSplit = input.Split("=> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                    for (int i = 0; i < inputSplit.Length; i++)
                    {
                        if (int.TryParse(inputSplit[i], out seats))
                        {
                            break;
                        }

                        townName += " " + inputSplit[i];
                        townName = townName.Trim();
                    }

                    var town = new Town()
                    {
                        Name = townName,
                        Seats = seats,
                        Students = new List<Student>()
                    };

                    towns.Add(town);
                }

                else
                {
                    var inputSplit = input.Split('|').Select(x => x.Trim()).ToArray();

                    var name = inputSplit[0];
                    var email = inputSplit[1];
                    var date = DateTime.ParseExact(inputSplit[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var student = new Student()
                    {
                        Name = name,
                        Email = email,
                        Date = date
                    };

                    towns.Last().Students.Add(student);
                }

                input = Console.ReadLine();
            }

            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                var studentsInTown = town.Students
                    .OrderBy(x => x.Date)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (studentsInTown.Count > 0)
                {
                    var group = new Group()
                    {
                        Town = town,
                        Students = studentsInTown.Take(town.Seats).ToList()
                    };

                    if (studentsInTown.Count < town.Seats)
                    {
                        studentsInTown.RemoveRange(0, studentsInTown.Count);
                    }

                    else
                    {
                        studentsInTown.RemoveRange(0, town.Seats);
                    }   
                                     
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Distinct().Count()} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                var emails = group.Students.Select(x => x.Email).ToArray();
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", emails)}");
            }
        }
    }
}
