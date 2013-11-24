namespace Onion.Factory.Core.Domain
{
    public class FactoryName
    {
        private readonly string factoryName;

        public FactoryName(string factoryName)
        {
            this.factoryName = factoryName;
        }

        public static implicit operator string(FactoryName name)
        {
            return name.factoryName;
        }
    }
}