using System.Collections.Generic;

public class CarManager
{
    public Dictionary<int, Race> Races { get; }
    public Garage Garage { get; }
    public Dictionary<int, Car> Cars { get; }

    public CarManager()
    {
        Garage = new Garage();
        Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car car = null;
        switch (type)
        {
            case "Performance":
                car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;

            case "Show":
                car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
        }

        if (car != null)
        {
            this.Cars.Add(id, car);
        }
    }

    public string Check(int id)
    {
        return this.Cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool, int lastParam)
    {
        if (!this.Races.ContainsKey(id))
        {
            Race race = null;

            switch (type)
            {
                case "Drag":
                    race = new DragRace(length, route, prizePool);
                    break;

                case "Drift":
                    race = new DriftRace(length, route, prizePool);
                    break;

                case "Casual":
                    race = new CasualRace(length, route, prizePool);
                    break;

                case "Circuit":
                    race = new CircuitRace(length, route, prizePool, lastParam);
                    break;

                case "TimeLimit":
                    race = new TimeLimitRace(length, route, prizePool, lastParam);
                    break;
            }

            if (race != null)
            {
                this.Races.Add(id, race);
            }
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.Garage.ParkedCars.Contains(carId))
        {
            var car = Cars[carId];
            if (this.Races[raceId].GetType().Name == nameof(TimeLimitRace) && this.Races[raceId].Participants.Count > 0)
            {
                return;
            }
            this.Races[raceId].Participants.Add(car);
        }
    }

    public string Start(int id)
    {
        return this.Races[id].CalculateResult();
    }

    public void Park(int id)
    {
        var isRacing = false;
        var car = this.Cars[id];

        foreach (var race in this.Races)
        {
            if (race.Value.Participants.Contains(car))
            {
                isRacing = true;
            }
        }

        if (!this.Garage.ParkedCars.Contains(id) && isRacing == false)
        {
            this.Garage.ParkedCars.Add(id);
        }
    }

    public void Unpark(int id)
    {
        if (this.Garage.ParkedCars.Contains(id))
        {
            this.Garage.ParkedCars.Remove(id);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var id in this.Garage.ParkedCars)
        {
            this.Cars[id].Horsepower += tuneIndex;
            this.Cars[id].Suspension += tuneIndex / 2;

            if (this.Cars[id].GetType().Name == nameof(PerformanceCar))
            {
                this.Cars[id].AddOns.Add(addOn);
            }
            else
            {
                this.Cars[id].Stars += tuneIndex;
            }
        }
    }
}
