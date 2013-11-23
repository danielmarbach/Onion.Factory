namespace Onion.Factory.Core
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Factory
    {
        private readonly FactoryId factoryId;

        private readonly List<Layer> producedLayers;

        public Factory(FactoryId factoryId, string name)
        {
            this.factoryId = factoryId;
            this.Name = name;

            this.producedLayers = new List<Layer>();
        }

        public DateTimeOffset OpenedAt { get; private set; }

        public string Name { get; private set; }

        public ReadOnlyCollection<Layer> ProducedLayers
        {
            get
            {
                return new ReadOnlyCollection<Layer>(this.producedLayers);
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

        public void Assign(IEnumerable<Layer> layers)
        {
            this.producedLayers.AddRange(layers);
        }
    }
}