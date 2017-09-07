using System.Collections.Generic;
using System.Text;

public class RepairCommand : Command
{
    private IProviderController pc;

    public RepairCommand(IList<string> arguments, IHarvesterController hc, IProviderController pc)
        : base(arguments, hc, pc)
    {
        this.pc = pc;
        
    }

    public override string Execute()
    {   
        return this.pc.Repair(double.Parse(this.Arguments[0]));
    }
}
