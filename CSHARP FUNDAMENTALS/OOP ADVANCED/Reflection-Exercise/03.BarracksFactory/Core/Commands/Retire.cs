using System;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class Retire : Command
    {
        private IRepository repository;

        
        public Retire(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            try
            {
                this.repository.RemoveUnit(this.Data[1]);
                return $"{this.Data[1]} retired!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}