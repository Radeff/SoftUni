public class ProviderFactory
{
    private const string Solar = "Solar";

    public Provider CreateProvider(string id, string type, double energyOutput)
    {

        if (type == Solar)
        {
            return new SolarProvider(id, energyOutput);
        }

        return new PressureProvider(id, energyOutput);
        
    }
}