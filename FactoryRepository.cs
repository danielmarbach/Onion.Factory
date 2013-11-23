namespace Onion.Factory
{
    using System.Transactions;

    using Onion.Factory.Core;
    using Onion.Factory.Core.Domain;
    using Onion.Factory.Core.DomainServices;

    public class FactoryRepository : IFactoryRepository
    {
        public void Save(Factory factory)
        {
            using (var tx = new TransactionScope())
            {
                Database.Insert(factory.Id, factory);

                tx.Complete();
            }
        }

        public void Update(Factory factory)
        {
            using (var tx = new TransactionScope())
            {
                Database.Update(factory.Id, factory);

                tx.Complete();
            }
        }

        public Factory Load(FactoryId factoryId)
        {
            return (Factory)Database.Select(factoryId);
        }
    }
}