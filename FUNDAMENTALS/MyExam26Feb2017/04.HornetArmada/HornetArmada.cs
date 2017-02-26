using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var inputPattern = new Regex(@"^(\d+) = (.*?) -> (.*?):(\d+)$");
            // gr1 - activity, gr2 - name, gr3 soldier type, gr4 count
            var legions = new List<Legion>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var match = inputPattern.Match(input);

                if (match.Success)
                {
                    var soldierType = match.Groups[3].Value;
                    var soldierCount = long.Parse(match.Groups[4].Value);

                    var legion = new Legion()
                    {
                        Name = match.Groups[2].Value,
                        Activity = int.Parse(match.Groups[1].Value),
                        Soldiers = new Dictionary<string, long>()
                    };

                    if (!legions.Any(l => l.Name == legion.Name))
                    {
                        legions.Add(legion);
                    }
                    
                    if (legions.Find(l => l.Name == legion.Name).Activity < legion.Activity)
                    {
                        legions.Find(l => l.Name == legion.Name).Activity = legion.Activity;
                    }

                    if (!legions.Find(l => l.Name == legion.Name).Soldiers.ContainsKey(soldierType))
                    {
                        legions.Find(l => l.Name == legion.Name).Soldiers.Add(soldierType, 0);
                    }

                    legions.Find(l => l.Name == legion.Name).Soldiers[soldierType] += soldierCount;
                }
            }

            var command = Console.ReadLine();

            var commandPattern = new Regex(@"^(\d+)\\(.*)$");
            //gr1 - activity, gr2 - type
            var commMatch = commandPattern.Match(command);            
            var sType = command;

            if (commMatch.Success)
            {
                var activityLimit = int.Parse(commMatch.Groups[1].Value);
                sType = commMatch.Groups[2].Value;

                foreach (var legion in legions.Where(l => l.Activity < activityLimit && l.Soldiers.ContainsKey(sType)).OrderByDescending(l => l.Soldiers[sType]))
                {
                    Console.WriteLine($"{legion.Name} -> {legion.Soldiers[sType]}");
                }
            }

            else
            {
                foreach (var legion in legions.Where(l => l.Soldiers.ContainsKey(sType)).OrderByDescending(l => l.Activity))
                {
                    Console.WriteLine($"{legion.Activity} : {legion.Name}");
                }
            }
        }
    }

    public class Legion
    {
        public string Name { get; set; }

        public Dictionary<string, long> Soldiers { get; set; }

        public int Activity { get; set; }
    }
}
