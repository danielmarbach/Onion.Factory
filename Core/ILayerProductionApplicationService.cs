namespace Onion.Factory.Core
{
    using System.Collections.Generic;

    public interface ILayerProductionApplicationService
    {
        Factory OpenFactory(FactoryId factoryId);

        IEnumerable<Layer> ProduceLayers(FactoryId factoryId, int numberOfLayers);
    }
}