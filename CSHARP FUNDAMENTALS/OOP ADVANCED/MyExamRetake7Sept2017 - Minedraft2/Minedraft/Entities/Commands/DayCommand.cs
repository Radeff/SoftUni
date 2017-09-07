using System.Collections.Generic;

public class DayCommand : Command
{
    public DayCommand(IList<string> arguments, IHarvesterController hc, IProviderController pc)
        : base(arguments, hc, pc)
    {

    }

    public override string Execute()
    {
        throw new System.NotImplementedException();
    }
}