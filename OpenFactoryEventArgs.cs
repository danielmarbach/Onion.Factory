namespace Onion.Factory
{
    using System;

    public class OpenFactoryEventArgs : EventArgs
    {
        public OpenFactoryEventArgs(string factoryName)
        {
            this.FactoryName = factoryName;
        }

        public string FactoryName { get; private set; }
    }
}