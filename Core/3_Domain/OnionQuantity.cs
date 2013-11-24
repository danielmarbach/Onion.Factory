namespace Onion.Factory.Core.Domain
{
    using System;

    public class OnionQuantity
    {
        private readonly int numberOfOnions;

        public OnionQuantity(int numberOfOnions)
        {
            if (numberOfOnions < 1)
            {
                throw new ArgumentOutOfRangeException("numberOfOnions", numberOfOnions, "Should be greater than one.");
            }

            if (numberOfOnions > 255)
            {
                throw new ArgumentOutOfRangeException("numberOfOnions", numberOfOnions, "Should be smaller than 256.");
            }

            this.numberOfOnions = numberOfOnions;
        }

        public static implicit operator int(OnionQuantity quantity)
        {
            return quantity.numberOfOnions;
        }
    }
}