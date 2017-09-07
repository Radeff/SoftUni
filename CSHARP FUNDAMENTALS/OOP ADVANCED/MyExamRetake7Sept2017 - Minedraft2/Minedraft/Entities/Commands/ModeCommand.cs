using System.Collections.Generic;

public class ModeCommand : Command
{
    private IHarvesterController hc;

    public ModeCommand(IList<string> arguments, IHarvesterController hc, IProviderController pc)
        : base(arguments, hc, pc)
    {
        this.hc = hc;
    }

    public override string Execute()
    {
        return this.hc.ChangeMode(this.Arguments[0]);
    }
}