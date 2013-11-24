namespace Onion.Factory.Core.ApplicationServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;
    using Onion.Factory.Core.DomainServices;

    public class OnionProductionApplicationService : IOnionProductionApplicationService
    {
        private readonly IFactoryDomainService factoryDomainService;

        private readonly IOnionDomainService onionDomainService;

        public OnionProductionApplicationService(IFactoryDomainService factoryDomainService, IOnionDomainService onionDomainService)
        {
            this.onionDomainService = onionDomainService;
            this.factoryDomainService = factoryDomainService;
        }

        public Factory OpenFactory(FactoryId factoryId, FactoryName factoryName)
        {
            Factory factory = this.factoryDomainService.OpenFactory(factoryId, factoryName);

            return factory;
        }

        public IEnumerable<Onion> ProduceOnions(FactoryId factoryId, OnionQuantity quanity)
        {
            var produceOnions = this.onionDomainService.ProduceOnions(quanity);

            this.factoryDomainService.AssignProducedOnions(factoryId, produceOnions);

            return produceOnions;
        }
    }
}
