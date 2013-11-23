namespace Onion.Factory
{
    using System;

    public class ProduceLayerEventArgs : EventArgs
    {
        public ProduceLayerEventArgs(string factoryName, int numberOfLayers)
        {
            this.NumberOfLayers = numberOfLayers;
            this.FactoryName = factoryName;
        }

        public int NumberOfLayers { get; private set; }

        public string FactoryName { get; private set; }
    }
}