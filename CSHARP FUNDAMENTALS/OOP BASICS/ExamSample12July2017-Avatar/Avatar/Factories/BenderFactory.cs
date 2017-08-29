public class BenderFactory
{
    public Bender AddBender(string type, string name, int power, double special)
    {
        switch (type)
        {
            case Constants.Air:
                return new AirBender(name, power, special);

            case Constants.Fire:
                return new FireBender(name, power, special);

            case Constants.Earth:
                return new EarthBender(name, power, special);

            //No invalid input will be given, so default is safe
            default:
                return new WaterBender(name, power, special);
        }
    }
}