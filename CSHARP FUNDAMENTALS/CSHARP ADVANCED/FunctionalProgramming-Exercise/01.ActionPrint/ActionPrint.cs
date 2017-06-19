using System;

namespace _01.ActionPrint
{
    public class ActionPrint
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            Action<string> print = s => Console.WriteLine(s);
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
