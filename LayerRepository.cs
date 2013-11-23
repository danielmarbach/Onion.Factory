namespace Onion.Factory
{
    using System.Transactions;

    using Onion.Factory.Core;

    public class LayerRepository : ILayerRepository
    {
        public void Save(Layer layer)
        {
            using (var tx = new TransactionScope())
            {
                Database.Insert(layer.Id, layer);

                tx.Complete();
            }
        }
    }
}