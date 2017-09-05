public class DriverFactory
{
    public Driver CreateDriver(string type, string name, int hp, double fuelAmount, Tyre tyre)
    {
        if (type == "Aggressive")
        {
            return new AggressiveDriver(name, hp, fuelAmount, tyre);
        }
        if (type == "Endurance")
        {
            return new EnduranceDriver(name, hp, fuelAmount, tyre);
        }

        return null;
    }
}
