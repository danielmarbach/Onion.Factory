namespace Onion.Factory.Core.DomainServices
{
    using Onion.Factory.Core.Domain;

    public interface IOnionRepository
    {
        void Save(Onion onion);
    }
}