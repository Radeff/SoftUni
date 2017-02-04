using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    public class Program
    {
        public static void Main()
        {
            var input = string.Empty;
            var mailbook = new Dictionary<string, string>();

            while (input != "stop")
            {
                input = Console.ReadLine();
                AddFixEmail(mailbook, input);
            }            
        }

        public static void AddFixEmail(Dictionary<string, string> mailbook, string input)
        {
            if (input == "stop")
            {
                foreach (var person in mailbook)
                {
                    Console.WriteLine($"{person.Key} -> {person.Value}");
                }

                return;
            }

            else if (!mailbook.ContainsKey(input))
            {
                var mail = Console.ReadLine();
                var mailEnding = mail.Substring(mail.Length - 3, 3);
                
                if (mailEnding != ".uk" && mailEnding != ".us")
                {
                    mailbook.Add(input, mail);
                }
            }

            else
            {
                var mail = Console.ReadLine();
                var mailEnding = mail.Substring(mail.Length - 3, 3);

                if (mailEnding != ".uk" && mailEnding != ".us")
                {
                    mailbook[input] = mail;
                }          
            }
        }
    }
}
