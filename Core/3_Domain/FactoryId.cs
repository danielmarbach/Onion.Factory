namespace Onion.Factory.Core.Domain
{
    using System;

    public class FactoryId : IEquatable<FactoryId>
    {
        public bool Equals(FactoryId other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return string.Equals(this.factoryName, other.factoryName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return this.Equals((FactoryId)obj);
        }

        public override int GetHashCode()
        {
            return this.factoryName.GetHashCode();
        }

        private readonly string factoryName;

        public FactoryId(string factoryName)
        {
            this.factoryName = factoryName;
        }
    }
}