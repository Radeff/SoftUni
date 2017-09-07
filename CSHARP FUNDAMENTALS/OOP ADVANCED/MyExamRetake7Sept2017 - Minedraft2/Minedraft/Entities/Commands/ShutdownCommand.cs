using System.Collections.Generic;
using System.Text;

public class ShutdownCommand : Command
{
    private IHarvesterController hc;
    private IProviderController pc;
    public ShutdownCommand(IList<string> arguments, IHarvesterController hc, IProviderController pc) : base(arguments, hc, pc)
    {
        this.pc = pc;
        this.hc = hc;
    }

    public override string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Produced: {this.pc.TotalEnergyProduced}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.hc.OreProduced}");
        return sb.ToString().Trim();
    }
}
