namespace Onion.Factory
{
    using System;
    using System.Collections.Generic;

    using Onion.Factory.Core.Domain;

    public class OnionProductionView
    {
        public EventHandler<OpenFactoryEventArgs> OpenFactoryClicked = delegate { };

        public EventHandler<ProduceOnionsEventArgs> ProduceOnionClicked = delegate { };

        public void Update(IEnumerable<Onion> onions)
        {
            int count = 0;

            foreach (var onion in onions)
            {
                count++;
                Logger.Log("Updating view for onion " + count + "and id " + onion.Id);
            }
        }

        public void ClickOpenFactory()
        {
            this.OpenFactoryClicked(this, new OpenFactoryEventArgs("Foo Bar Baz"));
        }

        public void ClickProduceOnion()
        {
            this.ProduceOnionClicked(this, new ProduceOnionsEventArgs("Foo Bar Baz", 10));
        }
    }
}