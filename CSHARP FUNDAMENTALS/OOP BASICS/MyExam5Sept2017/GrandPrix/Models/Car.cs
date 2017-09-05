using System;

public class Car
{
    private const double FuelMaxCapacity = 160d;

    private double fuelAmount;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.Tyre = tyre;
        this.FuelAmount = fuelAmount;
    }

    public int Hp { get; }

    public double FuelAmount {
        get
        {
            return this.fuelAmount;
        }
        private set
        {
            this.fuelAmount = Math.Min(value, FuelMaxCapacity);
            if (this.fuelAmount < 0)
            {
                throw new Exception("Out of fuel");
            }
        }
    }

    public Tyre Tyre { get; private set; }

    public void ReduceFuel(int length, double fuelConsumption)
    {
        this.FuelAmount = this.FuelAmount - (length * fuelConsumption);
    }

    public void Refuel(double fuel)
    {
        this.FuelAmount += fuel;
    }

    public void ChangeTyre(Tyre tyre)
    {
        this.Tyre = tyre;
    }
}