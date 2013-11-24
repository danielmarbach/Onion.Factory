namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public class FactoryDomainService : IFactoryDomainService
    {
        private readonly IFactoryRepository repository;

        private readonly IFactoryOpened factoryOpened;

        public FactoryDomainService(IFactoryRepository repository, IFactoryOpened factoryOpened)
        {
            this.factoryOpened = factoryOpened;
            this.repository = repository;
        }

        public Factory OpenFactory(FactoryId factoryId, FactoryName name)
        {
            var factory = new Factory(factoryId, name);

            factory.Open(this.factoryOpened);

            this.repository.Save(factory);

            return factory;
        }

        public void AssignProducedOnions(FactoryId factoryId, IEnumerable<Onion> producedOnions)
        {
            var factory = this.repository.Load(factoryId);

            factory.Assign(producedOnions);

            this.repository.Update(factory);
        }
    }
}