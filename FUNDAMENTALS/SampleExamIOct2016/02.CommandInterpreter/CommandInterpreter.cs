using System;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var strings = Console.ReadLine()
                .Split("\t\r\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "reverse":
                        var start = int.Parse(command[2]);
                        var count = int.Parse(command[4]);

                        if (start + count > strings.Count 
                            || start < 0 
                            || start >= strings.Count 
                            || count < 0 
                            || count > strings.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        strings.Reverse(start, count);
                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (start + count > strings.Count
                            || start < 0 
                            || start >= strings.Count 
                            || count < 0 
                            || count > strings.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        
                        strings.Sort(start, count, null);
                        break;

                    case "rollLeft":
                        count = int.Parse(command[1]) % strings.Count;

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }                        

                        for (int i = 0; i < count; i++)
                        {
                            var first = strings.First();
                            strings.RemoveAt(0);
                            strings.Add(first);
                        }    
                                            
                        break;

                    case "rollRight":
                        count = int.Parse(command[1]) % strings.Count;

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }                        

                        for (int i = 0; i < count; i++)
                        {
                            var last = strings.Last();
                            strings.RemoveAt(strings.Count - 1);
                            strings.Insert(0, last);
                        }

                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", strings)}]");
        }
    }
}
