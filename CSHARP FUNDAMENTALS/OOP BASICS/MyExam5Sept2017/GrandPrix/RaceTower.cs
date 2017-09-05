using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private DriverFactory driverFactory;
    private TyreFactory tyreFactory;
    private Dictionary<string, Driver> drivers;
    private Dictionary<string, string> dnf;
    private int laps;
    private string weather;

    public RaceTower()
    {
        this.driverFactory = new DriverFactory();
        this.tyreFactory = new TyreFactory();
        this.drivers = new Dictionary<string, Driver>();
        this.CurrentLap = 0;
        this.weather = "Sunny";
        this.dnf = new Dictionary<string, string>();
    }

    public Driver Winner { get; private set; }

    public int CurrentLap { get; private set; }

    public int Length { get; private set; }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.laps = lapsNumber;
        this.Length = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var type = commandArgs[0];
            var name = commandArgs[1];
            var hp = int.Parse(commandArgs[2]);
            var fuelAmount = double.Parse(commandArgs[3]);
            var tyreType = commandArgs[4];
            var tyreHardness = double.Parse(commandArgs[5]);
            var grip = 0d;

            if (tyreType == "Ultrasoft")
            {
                grip = double.Parse(commandArgs[6]);
            }

            var tyre = this.tyreFactory.CreateTyre(tyreType, tyreHardness, grip);

            var driver = this.driverFactory
                .CreateDriver(type, name, hp, fuelAmount, tyre);

            drivers.Add(name, driver);

        }
        catch (Exception e)
        {

        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var name = commandArgs[1];

        if (commandArgs[0] == "Refuel")
        {
            var fuel = double.Parse(commandArgs[2]);

            drivers[name].Car.Refuel(fuel);
        }
        else if(commandArgs[0] == "ChangeTyres")
        {
            var type = commandArgs[2];
            var hardness = double.Parse(commandArgs[3]);
            var grip = 0d;
            
            if (type == "Ultrasoft")
            {
                grip = double.Parse(commandArgs[4]);
            }

            drivers[name].Car.ChangeTyre(tyreFactory.CreateTyre(type, hardness, grip));
        }

        drivers[name].IncreaseTotalTimeBox();
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var sb = new StringBuilder();
        var lapsToAdd = int.Parse(commandArgs[0]);

        if (lapsToAdd + this.CurrentLap > this.laps)
        {
            throw new Exception($"There is no time! On lap {this.CurrentLap}.");
        }

        for (int i = 0; i < lapsToAdd; i++)
        {
            var driversLeft = drivers.Values.ToList();

            foreach (var driver in driversLeft)
            {
                drivers[driver.Name].IncreaseTotalTime(this.Length);

                try
                {
                    drivers[driver.Name].ReduceFuelAmount(this.Length);
                    drivers[driver.Name].Car.Tyre.DegradeTyre();
                }
                catch (Exception e)
                {
                    dnf.Add(driver.Name, e.Message);
                    drivers.Remove(driver.Name);
                }
            }

            this.CurrentLap++;

            driversLeft = drivers.Values.OrderByDescending(d => d.TotalTime).ToList();
            var prevDriver = driversLeft[0];
            
            for (int j = 1; j < driversLeft.Count; j++)
            {
                var canCrash = false;

                var interval = 2d;
                if (prevDriver.GetType().Name == nameof(AggressiveDriver) &&
                    prevDriver.Car.Tyre.GetType().Name == nameof(UltrasoftTyre))
                {
                    interval = 3d;
                    if (this.weather == "Foggy")
                    {
                        canCrash = true;
                    }
                }
                if (prevDriver.GetType().Name == nameof(EnduranceDriver) &&
                    prevDriver.Car.Tyre.GetType().Name == nameof(HardTyre))
                {
                    interval = 3d;
                    if (this.weather == "Rainy")
                    {
                        canCrash = true;
                    }
                }

                var currDriver = driversLeft[j];
                if (prevDriver.TotalTime - currDriver.TotalTime <= interval)
                {
                    if (canCrash)
                    {
                        dnf.Add(prevDriver.Name, "Crashed");
                        drivers.Remove(prevDriver.Name);
                        continue;
                    }

                    prevDriver.DecreaseTotalTimeOvertake(interval);
                    currDriver.IncreaseTotalTimeOvertaken(interval);

                    sb.AppendLine($"{prevDriver.Name} has overtaken {currDriver.Name} on lap {this.CurrentLap}.");
                }

                prevDriver = driversLeft[j];
            }
        }

        if (CurrentLap == this.laps)
        {
            this.Winner = drivers.Values.OrderBy(d => d.TotalTime).FirstOrDefault();
        }

        return sb.ToString().Trim();
    }

    public string GetLeaderboard()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Lap {this.CurrentLap}/{this.laps}");

        var position = 1;
        foreach (var driver in drivers.Values.OrderBy(d => d.TotalTime))
        {
            sb.AppendLine($"{position} {driver.Name} {driver.TotalTime:F3}");
            position++;
        }

        foreach (var driver in dnf)
        {
            sb.AppendLine($"{position} {driver.Key} {driver.Value}");
            position++;
        }

        return sb.ToString().Trim();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        this.weather = commandArgs[0];
    }

}