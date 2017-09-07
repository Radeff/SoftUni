using System.Collections.Generic;

public abstract class Command : ICommand
{
    private IHarvesterController hc;
    private IProviderController pc;

    protected Command(IList<string> arguments, IHarvesterController hc, IProviderController pc)
    {
        this.pc = pc;
        this.hc = hc;
        this.Arguments = arguments;
    }

    public IList<string> Arguments { get; }

    public abstract string Execute();
}