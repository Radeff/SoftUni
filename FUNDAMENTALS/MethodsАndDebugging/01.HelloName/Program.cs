using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            StringPrint(name);
        }
        public static void StringPrint(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
