namespace Onion.Factory
{
    using System.Transactions;

    using Onion.Factory.Core.Domain;
    using Onion.Factory.Core.DomainServices;

    public class OnionRepository : IOnionRepository
    {
        public void Save(Onion onion)
        {
            using (var tx = new TransactionScope())
            {
                Database.Insert(onion.Id, onion);

                tx.Complete();
            }
        }
    }
}