using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private string[] data;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            private set { this.unitFactory = value; }
        }

        protected IRepository Repository {
            get { return this.repository; }
            private set { this.repository = value; }
        }

        protected string[] Data { get => data; private set => data = value; }

        public abstract string Execute();
    }
}

