namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface IFactoryDomainService
    {
        Factory OpenFactory(FactoryId factoryId, FactoryName name);

        void AssignProducedOnions(FactoryId factoryId, IEnumerable<Onion> producedOnions);
    }
}