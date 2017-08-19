using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    public QuitCommand(IList<string> argsList, IManager manager)
        : base (argsList, manager)
    {
    }

    public override string Execute()
    {
         return base.Manager.Quit(this.ArgsList);
    }
}