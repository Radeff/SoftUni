public class MonumentFactory
{
    public Monument AddMonument(string type, string name, int affinity)
    {
        switch (type)
        {
            case Constants.Air:
                return new AirMonument(name, affinity);

            case Constants.Fire:
                return new FireMonument(name, affinity);

            case Constants.Earth:
                return new EarthMonument(name, affinity);

            //No invalid input will be given, so default is safe
            default:
                return new WaterMonument(name, affinity);
        }
    }
}