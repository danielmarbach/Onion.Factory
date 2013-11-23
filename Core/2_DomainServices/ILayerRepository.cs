namespace Onion.Factory.Core.DomainServices
{
    using Onion.Factory.Core.Domain;

    public interface ILayerRepository
    {
        void Save(Layer layer);
    }
}