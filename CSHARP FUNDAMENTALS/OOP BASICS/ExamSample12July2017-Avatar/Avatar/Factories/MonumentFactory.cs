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

            case Constants.Water:
            default:
                return new WaterMonument(name, affinity);
        }
    }
}