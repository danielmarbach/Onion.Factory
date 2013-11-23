namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface IFactoryDomainService
    {
        Factory OpenFactory(FactoryId factoryId, string name = "Onion Factory");

        void AssignProducedLayers(FactoryId factoryId, IEnumerable<Layer> producedLayers);
    }
}