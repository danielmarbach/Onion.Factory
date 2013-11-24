namespace Onion.Factory.Core.ApplicationServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface IOnionProductionApplicationService
    {
        Factory OpenFactory(FactoryId factoryId, FactoryName factoryName);

        IEnumerable<Onion> ProduceOnions(FactoryId factoryId, OnionQuantity quanity);
    }
}