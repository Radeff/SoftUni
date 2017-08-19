using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var blackBoxType = typeof(BlackBoxInt);

            var blackBox = Activator.CreateInstance(blackBoxType, true);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var command = inputLine.Split('_');
                var methodName = command[0];
                var value = int.Parse(command[1]);

                blackBoxType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBox, new object[] { value });

                var field = blackBoxType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First()
                    .GetValue(blackBox);

                Console.WriteLine(field);
            }
        }
    }
}
