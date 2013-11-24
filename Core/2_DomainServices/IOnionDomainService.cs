namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface IOnionDomainService
    {
        IReadOnlyCollection<Onion> ProduceOnions(OnionQuantity quantity);
    }
}