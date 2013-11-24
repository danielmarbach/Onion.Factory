namespace Onion.Factory.Core.DomainServices
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Onion.Factory.Core.Domain;

    public class OnionDomainService : IOnionDomainService
    {
        private readonly IOnionRepository repository;

        public OnionDomainService(IOnionRepository repository)
        {
            this.repository = repository;
        }

        public IReadOnlyCollection<Onion> ProduceOnions(OnionQuantity quantity)
        {
            var onions = Enumerable.Range(0, quantity).Select(i => new Onion()).ToList();

            foreach (var onion in onions)
            {
                this.repository.Save(onion);
            }

            return new ReadOnlyCollection<Onion>(onions);
        }
    }
}