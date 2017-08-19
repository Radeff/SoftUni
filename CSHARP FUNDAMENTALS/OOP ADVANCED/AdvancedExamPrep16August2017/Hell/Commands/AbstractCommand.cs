using System.Collections.Generic;

public abstract class AbstractCommand : ICommand
{
    protected AbstractCommand(IList<string> argsList, IManager manager)
    {
        ArgsList = argsList;
        Manager = manager;
    }
    public IList<string> ArgsList { get; }

    public IManager Manager { get;  }


    public abstract string Execute();
}