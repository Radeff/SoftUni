public class HammerHarvester : Harvester
{
    private const int OreOutputMultiplier = 3;
    private const int EnergyRequirementMultiplier = 2;

    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput *= OreOutputMultiplier;
        this.EnergyRequirement *= EnergyRequirementMultiplier;
    }
}
