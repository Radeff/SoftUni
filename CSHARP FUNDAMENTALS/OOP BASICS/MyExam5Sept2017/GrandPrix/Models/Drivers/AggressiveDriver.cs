public class AggressiveDriver : Driver
{
    private const double DefaultFuelConsumptionPerKm = 2.7;
    private const double SpeedMultiplier = 1.3;

    public AggressiveDriver(string name, int hp, double fuelAmount, Tyre tyre)
        : base(name, hp, fuelAmount, tyre)
    {
    }

    public override double FuelConsumptionPerKm => DefaultFuelConsumptionPerKm;

    public override double Speed => base.Speed * SpeedMultiplier;
    
}