using System;
using System.Linq;

public class StartUp
{
    private const string TerminateInput = "Cops Are Here";

    public static void Main()
    {
        var cm = new CarManager();
        var input = Console.ReadLine();

        while (input != TerminateInput)
        {
            var inputSplit = input
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = inputSplit[0];

            var id = 0;
            var type = string.Empty;

            switch (command)
            {
                case "register":
                    id = int.Parse(inputSplit[1]);
                    type = inputSplit[2];
                    var brand = inputSplit[3];
                    var model = inputSplit[4];
                    var year = int.Parse(inputSplit[5]);
                    var horsepower = int.Parse(inputSplit[6]);
                    var acceleration = int.Parse(inputSplit[7]);
                    var suspension = int.Parse(inputSplit[8]);
                    var durability = int.Parse(inputSplit[9]);

                    cm.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
                    break;

                case "check":
                    id = int.Parse(inputSplit[1]);
                    Console.WriteLine(cm.Check(id));
                    break;

                case "open":
                    id = int.Parse(inputSplit[1]);
                    type = inputSplit[2];
                    var length = int.Parse(inputSplit[3]);
                    var route = inputSplit[4];
                    var prizePool = int.Parse(inputSplit[5]);
                    var lastParam = 0;

                    if (inputSplit.Count > 6)
                    {
                        lastParam = int.Parse(inputSplit[6]);
                    }

                    cm.Open(id, type, length, route, prizePool, lastParam);
                    break;

                case "participate":
                    id = int.Parse(inputSplit[1]);
                    var raceId = int.Parse(inputSplit[2]);
                    cm.Participate(id, raceId);
                    break;

                case "start":
                    id = int.Parse(inputSplit[1]);
                    Console.WriteLine(cm.Start(id));
                    break;

                case "park":
                    id = int.Parse(inputSplit[1]);
                    cm.Park(id);
                    break;

                case "unpark":
                    id = int.Parse(inputSplit[1]);
                    cm.Unpark(id);
                    break;

                case "tune":
                    var tuneIndex = int.Parse(inputSplit[1]);
                    var tuneAddOn = inputSplit[2];
                    cm.Tune(tuneIndex, tuneAddOn);
                    break;
            }

            input = Console.ReadLine();
        }
    }
}

