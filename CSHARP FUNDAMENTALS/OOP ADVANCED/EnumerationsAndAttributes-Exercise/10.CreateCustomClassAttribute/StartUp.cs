using System;

namespace _10.CreateCustomClassAttribute
{
    public class StartUp
    {
        public static void Main()
        {
            var attributes = typeof(Weapon).GetCustomAttributes(false);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                foreach (KurAttribute attr in attributes)
                {
                    switch (input)
                    {
                        case "Author":
                            Console.WriteLine($"Author: {attr.Author}");
                            break;
                        case "Revision":
                            Console.WriteLine($"Revision: {attr.Revision}");
                            break;
                        case "Description":
                            Console.WriteLine($"Class description: {attr.Description}");
                            break;
                        case "Reviewers":
                            Console.WriteLine($"Reviewers: {string.Join(", ", attr.Reviewers)}");
                            break;
                    }
                }
            }
        }
    }
}
