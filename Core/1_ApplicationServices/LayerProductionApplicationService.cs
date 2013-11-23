namespace Onion.Factory.Core.ApplicationServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;
    using Onion.Factory.Core.DomainServices;

    public class LayerProductionApplicationService : ILayerProductionApplicationService
    {
        private readonly IFactoryDomainService factoryDomainService;

        private readonly ILayerDomainService layerDomainService;

        public LayerProductionApplicationService(IFactoryDomainService factoryDomainService, ILayerDomainService layerDomainService)
        {
            this.layerDomainService = layerDomainService;
            this.factoryDomainService = factoryDomainService;
        }

        public Factory OpenFactory(FactoryId factoryId, string factoryName)
        {
            Factory factory = this.factoryDomainService.OpenFactory(factoryId, factoryName);

            return factory;
        }

        public IEnumerable<Layer> ProduceLayers(FactoryId factoryId, int numberOfLayers)
        {
            var producedLayers = this.layerDomainService.ProduceLayers(numberOfLayers);

            this.factoryDomainService.AssignProducedLayers(factoryId, producedLayers);

            return producedLayers;
        }
    }
}
