using System;
using System.Linq;

public class StartUp
{
    private const string TerminateProgram = "Shutdown";

    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        var dm = new DraftManager();
        var command = input[0];

        while (command != TerminateProgram)
        {
            var args = input.Skip(1).ToList();

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(dm.RegisterHarvester(args));
                    break;

                case "RegisterProvider":
                    Console.WriteLine(dm.RegisterProvider(args));
                    break;

                case "Day":
                    Console.WriteLine(dm.Day());
                    break;

                case "Check":
                    Console.WriteLine(dm.Check(args));
                    break;

                case "Mode":
                    Console.WriteLine(dm.Mode(args));
                    break;
            }

            input = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            command = input[0];
        }

        Console.WriteLine(dm.ShutDown());
    }
}