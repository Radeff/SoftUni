using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Add : Command
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        public Add(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}