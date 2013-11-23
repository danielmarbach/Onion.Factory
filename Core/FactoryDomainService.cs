namespace Onion.Factory.Core
{
    using System.Collections.Generic;

    public class FactoryDomainService : IFactoryDomainService
    {
        private readonly IFactoryRepository repository;

        private readonly IFactoryOpened factoryOpened;

        public FactoryDomainService(IFactoryRepository repository, IFactoryOpened factoryOpened)
        {
            this.factoryOpened = factoryOpened;
            this.repository = repository;
        }

        public Factory OpenFactory(FactoryId factoryId, string name = "Onion Factory")
        {
            var factory = new Factory(factoryId, name);

            factory.Open(this.factoryOpened);

            this.repository.Save(factory);

            return factory;
        }

        public void AssignProducedLayers(FactoryId factoryId, IEnumerable<Layer> producedLayers)
        {
            var factory = this.repository.Load(factoryId);

            factory.Assign(producedLayers);

            this.repository.Save(factory);
        }
    }
}