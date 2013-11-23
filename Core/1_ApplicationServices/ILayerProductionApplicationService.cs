﻿namespace Onion.Factory.Core.ApplicationServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface ILayerProductionApplicationService
    {
        Factory OpenFactory(FactoryId factoryId, string factoryName);

        IEnumerable<Layer> ProduceLayers(FactoryId factoryId, int numberOfLayers);
    }
}