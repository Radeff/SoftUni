using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    public class FootballLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();            
            var teams = new SortedDictionary<string, Team>();

            while (true)
            {
                var result = Console.ReadLine();
                var safeResult = result.Replace($"{key}", "@");

                if (result == "final")
                {
                    break;
                }                
                
                var pattern = new Regex($@"(@)([\w\s]*?)\1.+\1([\w\s]*?)\1.+?(\d+):(\d+)$"); 
                // team1 - gr2, team2 - gr3, score team1 - gr4, score team2 - gr5
                var match = pattern.Match(safeResult);
                var firstTeamName = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                var secondTeamName = new string(match.Groups[3].Value.ToUpper().Reverse().ToArray());
                var firstTeamScore = int.Parse(match.Groups[4].Value);
                var secondTeamScore = int.Parse(match.Groups[5].Value);

                if (!teams.ContainsKey(firstTeamName))
                {
                    teams.Add(firstTeamName, new Team());
                }

                if (!teams.ContainsKey(secondTeamName))
                {
                    teams.Add(secondTeamName, new Team());
                }

                teams[firstTeamName].Goals += firstTeamScore;
                teams[secondTeamName].Goals += secondTeamScore;

                if (firstTeamScore > secondTeamScore)
                {
                    teams[firstTeamName].Points += 3;
                }

                else if (secondTeamScore > firstTeamScore)
                {
                    teams[secondTeamName].Points += 3;
                }

                else
                {
                    teams[firstTeamName].Points += 1;
                    teams[secondTeamName].Points += 1;
                }
            }

            Console.WriteLine("League standings:");
            int i = 1;

            foreach (var team in teams.OrderByDescending(x => x.Value.Points))
            {
                Console.WriteLine($"{i}. {team.Key} {team.Value.Points}");
                i++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in teams.OrderByDescending(x => x.Value.Goals).Take(3))
            {
                Console.WriteLine($" - {team.Key} -> {team.Value.Goals}");
            }
        }
    }    
}
