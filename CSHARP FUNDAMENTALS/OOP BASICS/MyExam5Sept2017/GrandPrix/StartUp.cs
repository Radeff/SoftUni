using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var laps = int.Parse(Console.ReadLine());
        var trackLength = int.Parse(Console.ReadLine());
        var race = new RaceTower();
        race.SetTrackInfo(laps, trackLength);
        
        while (race.CurrentLap < laps)
        {
            var input = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = input[0];
            input.RemoveAt(0);
            switch (command)
            {
                case "RegisterDriver":
                    race.RegisterDriver(input);
                    break;

                case "Leaderboard":
                    Console.WriteLine(race.GetLeaderboard());
                    break;

                case "CompleteLaps":
                    try
                    {
                        var result = race.CompleteLaps(input);
                        if (result != string.Empty)
                        {
                            Console.WriteLine(result);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    break;

                case "Box":
                    race.DriverBoxes(input);
                    break;

                case "ChangeWeather":
                    race.ChangeWeather(input);
                    break;
            }
        }
        
        Console.WriteLine($"{race.Winner.Name} wins the race for {race.Winner.TotalTime:F3} seconds.");
    }
}