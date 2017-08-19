using _03BarracksFactory.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    var data = input.Split();
                    var commandName = data[0];
                    var interpreter = new CommandInterpreter(this.repository, this.unitFactory);
                    var command = interpreter.InterpretCommand(data, commandName);
                    Console.WriteLine(command.Execute());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }



        //// TODO: refactor for Problem 4
        //private string InterpredCommand(string[] data, string commandName)
        //{
        //    string result = string.Empty;
        //    switch (commandName)
        //    {
        //        case "add":
        //            result = this.AddUnitCommand(data);
        //            break;
        //        case "report":
        //            result = this.ReportCommand(data);
        //            break;
        //        case "fight":
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            throw new InvalidOperationException("Invalid command!");
        //    }
        //    return result;
        //}


        //private string ReportCommand(string[] data)
        //{
        //    string output = this.repository.Statistics;
        //    return output;
        //}


        //private string AddUnitCommand(string[] data)
        //{
        //    string unitType = data[1];
        //    IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
        //    this.repository.AddUnit(unitToAdd);
        //    string output = unitType + " added!";
        //    return output;
        //}
    }
}
