namespace Onion.Factory.Core
{
    public interface IFactoryRepository
    {
        void Save(Factory factory);

        Factory Load(FactoryId factoryId);
    }
}