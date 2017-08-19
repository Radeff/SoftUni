using System;
using System.Linq;
using System.Reflection;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var firstChar = commandName.ToUpper().ToCharArray();
            var fixedName = string.Concat(firstChar[0], commandName.Substring(1));

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == fixedName);

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            var command = (IExecutable)Activator.CreateInstance(type, new object[] {data, repository, unitFactory});

            return command;
        }
    }
}