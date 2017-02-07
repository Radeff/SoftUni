using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var input = new string[n];
            var userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }            

            PrintLogs(userLogs, input);
        }

        public static void PrintLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string[] input)
        {
            foreach (var line in input)
            {
                var inputsplit = line.Split().ToArray();
                var ip = inputsplit[0];
                var user = inputsplit[1];
                var dur = int.Parse(inputsplit[2]);

                if (!userLogs.ContainsKey(user))
                {
                    var stats = new SortedDictionary<string, int>();
                    userLogs.Add(user, stats);
                }

                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }

                userLogs[user][ip] += dur;
            }

            foreach (var user in userLogs)
            {
                var duration = user.Value.Values.Sum();
                var ips = user.Value.Keys.Distinct().OrderBy(z => z);
                Console.WriteLine($"{user.Key}: {duration} [{string.Join(", ", ips)}]");
            }
        }
    }
}
