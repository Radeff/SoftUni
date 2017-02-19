using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RoliTheCoder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var events = new Dictionary<string, Event>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var inputSplit = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputSplit.Count() < 2)
                {
                    continue;
                }

                else
                {
                    var id = inputSplit[0];
                    var eventName = "";

                    if (inputSplit[1].StartsWith("#"))
                    {
                        eventName = inputSplit[1].Substring(1, inputSplit[1].Length - 1);
                    }

                    else
                    {
                        continue;
                    }

                    if (!events.ContainsKey(id))
                    {
                        var newEvent = new Event()
                        {
                            Name = eventName,
                            Participants = new List<string>()
                        };

                        events.Add(id, newEvent);
                    }

                    for (int i = 2; i < inputSplit.Count(); i++)
                    {
                        var participant = inputSplit[i];

                        if (events[id].Name == eventName && !events[id].Participants.Contains(participant))
                        {
                            events[id].Participants.Add(participant);
                        }
                    }
                }
            }

            foreach (var evnt in events
                    .OrderByDescending(x => x.Value.Participants.Count())
                    .ThenBy(x => x.Value.Name))
            {
                Console.WriteLine($"{evnt.Value.Name} - {evnt.Value.Participants.Count}");

                foreach (var participant in evnt.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}