namespace Onion.Factory.Core
{
    using System;

    public class Layer
    {
        public Layer()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}