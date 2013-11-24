namespace Onion.Factory
{
    using Onion.Factory.Core.ApplicationServices;
    using Onion.Factory.Core.Domain;

    public class OnionProductionPresenter
    {
        private readonly OnionProductionView view;

        private readonly IOnionProductionApplicationService onionProductionApplicationService;

        public OnionProductionPresenter(
            OnionProductionView view,
            IOnionProductionApplicationService onionProductionApplicationService)
        {
            this.onionProductionApplicationService = onionProductionApplicationService;
            this.view = view;
        }

        public void Initialize()
        {
            Logger.Log("Initializing presenter");

            this.view.OpenFactoryClicked += this.HandleOpenFactoryClicked;
            this.view.ProduceOnionClicked += this.HandleProduceOnionClicked;
        }

        private void HandleProduceOnionClicked(object sender, ProduceOnionsEventArgs e)
        {
            Logger.Log("Handling Produce Onion Clicked Event");

            var factoryId = new FactoryId(e.FactoryName.Replace(" ", "_"));
            OnionQuantity onionQuantity = e.NumberOf.Onions();

            var onions = this.onionProductionApplicationService.ProduceOnions(factoryId, onionQuantity);

            this.view.Update(onions);
        }

        private void HandleOpenFactoryClicked(object sender, OpenFactoryEventArgs e)
        {
            Logger.Log("Handling Open Factory Clicked Event");

            var factoryId = new FactoryId(e.FactoryName.Replace(" ", "_"));
            var factoryName = new FactoryName(e.FactoryName);

            this.onionProductionApplicationService.OpenFactory(factoryId, factoryName);
        }
    }
}