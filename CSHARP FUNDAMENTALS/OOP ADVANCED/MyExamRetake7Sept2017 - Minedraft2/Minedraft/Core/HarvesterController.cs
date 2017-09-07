using System;
using System.Collections.Generic;
using System.Linq;

public class HarvesterController : IHarvesterController
{
    private const string FullMode = "Full";
    private const string HalfMode = "Half";
    private const string EnergyMode = "Energy";
    private const double HalfModeOreModifier = 0.5;
    private const double EnergyModeOreModifier = 0.2;

    private List<IHarvester> harvesters;
    private IEnergyRepository energyRepository;
    private IHarvesterFactory factory;
    private string currentMode;

    public HarvesterController(IEnergyRepository energyRepository)
    {
        this.harvesters = new List<IHarvester>();
        this.factory = new HarvesterFactory();
        this.energyRepository = energyRepository;
        this.currentMode = FullMode;
    }

    public string Mode => this.currentMode;

    public double OreProduced { get; protected set; }

    public string Register(IList<string> args)
    {
        var harvester = this.factory.GenerateHarvester(args);
        this.harvesters.Add(harvester);
        return string.Format(Constants.SuccessfullRegistration, harvester.GetType().Name);
    }

    public string Produce()
    {
        var energyRequired = this.harvesters.Select(h => h.EnergyRequirement).Sum();
        var oreProduced = 0d;

        if (energyRequired <= this.energyRepository.EnergyStored)
        {
            oreProduced = this.harvesters.Select(h => h.Produce()).Sum();

            if (this.currentMode == HalfMode)
            {
                oreProduced *= HalfModeOreModifier;
            }
            else if (currentMode == EnergyMode)
            {
                oreProduced *= EnergyModeOreModifier;
            }

            this.OreProduced += oreProduced;
        }

        return string.Format(Constants.OreOutputToday, oreProduced);
    }
    
    public string ChangeMode(string mode)
    {
        this.currentMode = mode;
        foreach (var harvester in harvesters)
        {
            harvester.Broke();
        }
        return string.Format(Constants.ChangedMode, mode);
    }
}