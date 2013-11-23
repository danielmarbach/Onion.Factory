﻿namespace Onion.Factory
{
    using System.Transactions;

    using Onion.Factory.Core;

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

        public Factory Load(FactoryId factoryId)
        {
            return (Factory)Database.Select(factoryId);
        }
    }
}