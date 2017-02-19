using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(", \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var regex = new Regex(@"\${6,10}|\^{6,10}|@{6,10}|#{6,10}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    var left = regex.Match(ticket.Substring(0, 10));
                    var right = regex.Match(ticket.Substring(10, 10));                    

                    if ((left.Success && right.Success) && left.Value.First() == right.Value.First())
                    {
                        if (left.Length == right.Length && left.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {10}{ticket[left.Index]} Jackpot!");
                        }

                        else
                        {
                            if (left.Length <= right.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {left.Length}{ticket[left.Index]}");
                            }

                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {right.Length}{ticket[left.Index]}");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }

                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
