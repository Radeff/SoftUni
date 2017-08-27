public class HarvesterFactory
{
    private const string Hammer = "Hammer";

    public Harvester CreateHarvester(string id, string type, double oreOutput, double energyRequirement, int sonicFactor)
    {

        if (type == Hammer)
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }

        return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);

    }
}
