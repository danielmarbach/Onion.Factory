namespace Onion.Factory.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Factory
    {
        private readonly FactoryId factoryId;

        private readonly List<Onion> producedOnions;

        public Factory(FactoryId factoryId, FactoryName name)
        {
            this.factoryId = factoryId;
            this.Name = name;

            this.producedOnions = new List<Onion>();
        }

        public DateTimeOffset OpenedAt { get; private set; }

        public FactoryName Name { get; private set; }

        public ReadOnlyCollection<Onion> ProducedOnions
        {
            get
            {
                return new ReadOnlyCollection<Onion>(this.producedOnions);
            }
        }

        public FactoryId Id
        {
            get
            {
                return this.factoryId;
            }
        }

        public void Open(IFactoryOpened opened)
        {
            this.OpenedAt = opened.At();
        }

        public void Assign(IEnumerable<Onion> onions)
        {
            this.producedOnions.AddRange(onions);
        }
    }
}