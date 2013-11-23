namespace Onion.Factory.Core
{
    using System.Collections.Generic;

    public interface ILayerDomainService
    {
        IReadOnlyCollection<Layer> ProduceLayers(int numberOfLayers);
    }
}