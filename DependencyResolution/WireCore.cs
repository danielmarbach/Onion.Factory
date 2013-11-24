namespace Onion.Factory.DependencyResolution
{
    using Onion.Factory.Core.ApplicationServices;
    using Onion.Factory.Core.DomainServices;

    public static class WireCore
    {
        public static IOnionProductionApplicationService Up()
        {
            return new OnionProductionApplicationService(new FactoryDomainService(new FactoryRepository(), new FactoryOpened()), new OnionDomainService(new OnionRepository()));
        }
    }
}
