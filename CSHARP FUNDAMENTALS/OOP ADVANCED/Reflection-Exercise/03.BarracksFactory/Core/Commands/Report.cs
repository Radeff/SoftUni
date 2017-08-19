using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Report : Command
    {
        private IRepository repository;

        public Report(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }

        
    }
}