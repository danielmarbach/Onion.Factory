namespace Onion.Factory.Core.Domain
{
    using System;

    public class Onion
    {
        public Onion()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}