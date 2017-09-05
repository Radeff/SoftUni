public abstract class Driver
{
    protected Driver(string name, int hp, double fuelAmount, Tyre tyre)
    {
        Name = name;
        this.Car = new Car(hp, fuelAmount, tyre);
    }

    public string Name { get; }

    public double TotalTime { get; private set; }

    public Car Car { get; }

    public abstract double FuelConsumptionPerKm { get; }

    public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    

    public void IncreaseTotalTime(int length)
    {
        this.TotalTime += 60 / (length / this.Speed);
    }

    public virtual void ReduceFuelAmount(int length)
    {
        this.Car.ReduceFuel(length, this.FuelConsumptionPerKm);
    }

    public virtual void IncreaseTotalTimeBox()
    {
        this.TotalTime += 20.0;
    }

    public virtual void DecreaseTotalTimeOvertake(double interval)
    {
        this.TotalTime -= interval;
    }

    public virtual void IncreaseTotalTimeOvertaken(double interval)
    {
        this.TotalTime += interval;
    }
}