namespace Onion.Factory.Core.Domain
{
    public static class IntExtensionsForOnions
    {
        public static OnionQuantity Onions(this int numberOfOnions)
        {
            return new OnionQuantity(numberOfOnions);
        }
    }
}