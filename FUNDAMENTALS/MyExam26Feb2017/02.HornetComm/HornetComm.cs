using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    public class HornetComm
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();            
            var messagePattern = new Regex(@"^(\d+)\s<->\s([a-zA-Z0-9]+)$");
            var broadcastPattern = new Regex(@"^(\D+)\s<->\s([a-zA-Z0-9]+)$");

            var input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                var matchMessage = messagePattern.Match(input);
                var matchBroadcast = broadcastPattern.Match(input);

                if (matchMessage.Success)
                {
                    var message = new StringBuilder();
                    message.Append(new string(matchMessage.Groups[1].Value.Reverse().ToArray()));
                    message.Append(" -> ");
                    message.Append(matchMessage.Groups[2].Value);
                    messages.Add(message.ToString());
                }

                else if (matchBroadcast.Success)
                {
                    var broadcast = new StringBuilder();
                    var message = matchBroadcast.Groups[1].Value;
                    var frequency = matchBroadcast.Groups[2].Value;
                    var freqLowUp = string.Empty;

                    foreach (var c in frequency)
                    {
                        if (c >= 97 && c <= 122)
                        {
                            freqLowUp = string.Concat(freqLowUp, (char)(c - 32));
                        }

                        else if (c >= 65 && c <= 90)
                        {
                            freqLowUp = string.Concat(freqLowUp, (char)(c + 32));
                        }

                        else
                        {
                            freqLowUp = string.Concat(freqLowUp, c);
                        }
                    }

                    broadcast.Append(freqLowUp);
                    broadcast.Append(" -> ");
                    broadcast.Append(message);
                    broadcasts.Add(broadcast.ToString());
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            PrintResults(broadcasts);

            Console.WriteLine("Messages:");
            PrintResults(messages);
        }

        public static void PrintResults(List<string> list)
        {
            if (list.Any())
            {
                foreach (var line in list)
                {
                    Console.WriteLine($"{line}");
                }
            }

            else
            {
                Console.WriteLine("None");
            }
        }
    }
}