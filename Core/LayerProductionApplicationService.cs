using System.Collections.Generic;

namespace Onion.Factory.Core
{
    public class LayerProductionApplicationService : ILayerProductionApplicationService
    {
        private readonly IFactoryDomainService factoryDomainService;

        private readonly ILayerDomainService layerDomainService;

        public LayerProductionApplicationService(IFactoryDomainService factoryDomainService, ILayerDomainService layerDomainService)
        {
            this.layerDomainService = layerDomainService;
            this.factoryDomainService = factoryDomainService;
        }

        public Factory OpenFactory(FactoryId factoryId)
        {
            Factory factory = this.factoryDomainService.OpenFactory(factoryId);

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
