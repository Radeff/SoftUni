using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var nations = new NationsBuilder();

        var input = string.Empty;

        while ((input = Console.ReadLine()) != Constants.TerminateString)
        {
            var inputSplit = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var command = inputSplit[0];

            switch (command)
            {
                case nameof(Bender):
                    nations.AssignBender(inputSplit.Skip(1).ToList());
                    break;

                case nameof(Monument):
                    nations.AssignMonument(inputSplit.Skip(1).ToList());
                    break;

                case Constants.StatusCommand:
                    var nationType = inputSplit[1];
                    Console.WriteLine(nations.GetStatus(nationType));
                    break;

                case Constants.WarCommand:
                    var nation = inputSplit[1];
                    nations.IssueWar(nation);
                    break;
            }
        }

        Console.WriteLine(nations.GetWarsRecord());
    }
}