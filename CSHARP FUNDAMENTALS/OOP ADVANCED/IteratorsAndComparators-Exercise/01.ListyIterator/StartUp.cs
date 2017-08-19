using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split().ToList();
            var list = new List<string>();
            var listy = new ListyIterator<string>(list);

            while (command.FirstOrDefault() != "END")
            {
                switch (command[0])
                {
                    case "Create":
                        list.AddRange(command.Skip(1));
                        break;

                    case "Move":
                        if (listy.Move(list))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        break;

                    case "HasNext":
                        if (listy.HasNext(list))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        break;

                    case "Print":
                        listy.Print(list);
                        break;

                    case "PrintAll":
                        listy.PrintAll(list);
                        break;
                }

                command = Console.ReadLine().Split().ToList();
            }
        }
    }
}
