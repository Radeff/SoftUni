using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    private const string CommandSuffix = "Command";

    public CommandInterpreter(IHarvesterController harvesterController, IProviderController providerController)
    {
        this.HarvesterController = harvesterController;
        this.ProviderController = providerController;
    }

    public IHarvesterController HarvesterController { get; }
    public IProviderController ProviderController { get; }
    
    public string ProcessCommand(IList<string> args)
    {
        var fixedName = string.Concat(args[0], CommandSuffix);

        var type = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t => t.Name == fixedName);

        var command = (ICommand)Activator.CreateInstance(type, new object[] { args, this.HarvesterController, this.ProviderController });

        return command.Execute();
    }
}
