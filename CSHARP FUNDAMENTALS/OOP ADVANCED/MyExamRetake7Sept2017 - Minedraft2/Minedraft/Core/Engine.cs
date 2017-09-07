using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private DraftManager manager;
    private IReader reader;
    private IWriter writer;
    private ICommandInterpreter interpreter;
    private IHarvesterController harvesterController;
    private IProviderController providerController;
    private IEnergyRepository energyRepository;

    public Engine()
    {
        this.manager = new DraftManager();
        this.reader = new ConsoleReader();
        this.writer = new ConsoleWriter();
        this.energyRepository = new EnergyRepository();
        this.harvesterController = new HarvesterController(this.energyRepository);
        this.providerController = new ProviderController(this.energyRepository);
        this.interpreter = new CommandInterpreter(this.harvesterController, this.providerController);
    }

    public void Run()
    {
        while (true)
        {
            var input = reader.ReadLine();
            var data = input.Split().ToList();
            var command = data[0];
            writer.WriteLine(this.interpreter.ProcessCommand(data));

            if (command == "Shutdown")
            {
                break;
            }
        }
    }
}
