namespace Onion.Factory
{
    using System;

    public class ProduceOnionsEventArgs : EventArgs
    {
        public ProduceOnionsEventArgs(string factoryName, int numberOf)
        {
            this.NumberOf = numberOf;
            this.FactoryName = factoryName;
        }

        public int NumberOf { get; private set; }

        public string FactoryName { get; private set; }
    }
}