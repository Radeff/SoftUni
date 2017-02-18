using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniKaraoke
{
    public class SoftuniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var awards = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();

                if (input[0] == "dawn")
                {
                    break;
                }

                
                var name = input[0];
                var song = input[1];
                var award = input[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(name))
                    {
                        awards.Add(name, new List<string>());
                    }

                    awards[name].Add(award);
                }
            }

            foreach (var participant in awards.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Distinct().Count()} awards");

                foreach (var award in participant.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }

            if (awards.Any() == false)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
