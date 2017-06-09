using System;

namespace _02.ParseURLs
{
    public class ParseURLs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputSplit = input.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (inputSplit.Length != 2 || inputSplit[1].IndexOf("/") == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            
            var protocol = inputSplit[0];
            var server = inputSplit[1].Substring(0, inputSplit[1].IndexOf("/"));
            var resources = inputSplit[1].Substring(server.Length + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}
