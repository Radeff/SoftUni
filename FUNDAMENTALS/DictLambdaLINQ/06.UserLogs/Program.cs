using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    public class Program
    {
        public static void Main()
        {
            var input = string.Empty;
            var log = new SortedDictionary<string, List<string>>();

            while (input != "end")
            {
                input = Console.ReadLine();
                PrintIPLogs(log, input);
            }
        }

        public static void PrintIPLogs(SortedDictionary<string, List<string>> log, string input)
        {
            if (input == "end")
            {
                foreach (var username in log)
                {
                    Console.WriteLine($"{username.Key}: ");
                    var IPs = username.Value.GroupBy(x => x);
                    
                    for (int i = 0; i < IPs.Count(); i++)
                    {
                        if (i == IPs.Count() - 1)
                        {
                            Console.Write($"{IPs.ElementAt(i).Key} => {IPs.ElementAt(i).Count()}.");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.Write($"{IPs.ElementAt(i).Key} => {IPs.ElementAt(i).Count()}, ");
                        }
                    }                    
                }

                return;
            } 

            var IP = input.Split().First().Remove(0, 3);
            var user = input.Split().Last().Remove(0, 5);

            if (!log.ContainsKey(user))
            {
                log.Add(user, new List<string>());
            }

            log[user].Add(IP);            
        }
    }
}
