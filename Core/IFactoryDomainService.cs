namespace Onion.Factory.Core
{
    using System.Collections.Generic;

    public interface IFactoryDomainService
    {
        Factory OpenFactory(FactoryId factoryId, string name = "Onion Factory");

        void AssignProducedLayers(FactoryId factoryId, IEnumerable<Layer> producedLayers);
    }
}