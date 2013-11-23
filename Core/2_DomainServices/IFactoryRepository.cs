namespace Onion.Factory.Core.DomainServices
{
    using Onion.Factory.Core.Domain;

    public interface IFactoryRepository
    {
        void Save(Factory factory);

        Factory Load(FactoryId factoryId);

        void Update(Factory factory);
    }
}