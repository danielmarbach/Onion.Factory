namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public interface ILayerDomainService
    {
        IReadOnlyCollection<Layer> ProduceLayers(int numberOfLayers);
    }
}