using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class TeamWork
    {
        public static void Main()
        {
            var numberOfTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            var input = new string[1];

            while (input[0] != "end of assignment")
            {
                input = Console.ReadLine().Split('-');

                if (input.Length > 1)
                {
                    var studentName = input[0];
                    var teamName = input[1];
                    if (input[1].StartsWith(">"))
                    {
                        teamName = teamName.Remove(0, 1);
                        if (!teams.Any(x => x.Name == teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist!");
                        }

                        else if (teams.Any(x => x.Members.Contains(studentName) || x.Creator.Equals(studentName)))
                        {
                            Console.WriteLine($"Member {studentName} cannot join team {teamName}!");
                        }

                        else
                        {
                            teams.Find(x => x.Name.Equals(teamName)).Members.Add(studentName);
                        }
                    }

                    else
                    {
                        if (teams.Any(x => x.Name.Equals(teamName)))
                        {
                            Console.WriteLine($"Team {teamName} was already created!");
                        }

                        else if (teams.Any(x => x.Creator.Equals(studentName)))
                        {
                            Console.WriteLine($"{studentName} cannot create another team!");
                        }

                        else
                        {
                            var team = new Team()
                            {
                                Name = teamName,
                                Members = new List<string>(),
                                Creator = studentName
                            };
                            teams.Add(team);
                            Console.WriteLine($"Team {teamName} has been created by {studentName}!");
                        }
                    }
                }
            }

            foreach (var team in teams.Where(x => x.Members.Count() > 0)
                .OrderByDescending(x => x.Members.Count())
                .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (teams.Any(x => x.Members.Count == 0))
            {
                foreach (var team in teams.Where(x => x.Members.Count() == 0).OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{team.Name}");
                }
            }
        }
    }
}

