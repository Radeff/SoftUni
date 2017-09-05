public class EnduranceDriver : Driver
{
    private const double DefaultFuelConsumptionPerKm = 1.5;

    public EnduranceDriver(string name, int hp, double fuelAmount, Tyre tyre) : base(name, hp, fuelAmount, tyre)
    {
    }

    public override double FuelConsumptionPerKm => DefaultFuelConsumptionPerKm;
}