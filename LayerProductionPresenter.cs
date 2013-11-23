namespace Onion.Factory
{
    using Onion.Factory.Core;
    using Onion.Factory.Core.ApplicationServices;
    using Onion.Factory.Core.Domain;
    using Onion.Factory.Core.DomainServices;

    public class LayerProductionPresenter
    {
        private readonly LayerProductionView view;

        private readonly ILayerProductionApplicationService layerProductionApplicationService;

        public LayerProductionPresenter(LayerProductionView view)
            : this(view, new LayerProductionApplicationService(new FactoryDomainService(new FactoryRepository(), new FactoryOpened()), new LayerDomainService(new LayerRepository())))
        {
        }

        public LayerProductionPresenter(LayerProductionView view, ILayerProductionApplicationService layerProductionApplicationService)
        {
            this.layerProductionApplicationService = layerProductionApplicationService;
            this.view = view;
        }

        public void Initialize()
        {
            Logger.Log("Initializing presenter");

            this.view.OpenFactoryClicked += this.HandleOpenFactoryClicked;
            this.view.ProduceLayerClicked += this.HandleProduceLayerClicked;
        }

        private void HandleProduceLayerClicked(object sender, ProduceLayerEventArgs e)
        {
            Logger.Log("Handling Produce Layer Clicked Event");

            var factoryId = new FactoryId(e.FactoryName.Replace(" ", "_"));

            var layers = this.layerProductionApplicationService.ProduceLayers(factoryId, e.NumberOfLayers);

            this.view.Update(layers);
        }

        private void HandleOpenFactoryClicked(object sender, OpenFactoryEventArgs e)
        {
            Logger.Log("Handling Open Factory Clicked Event");

            var factoryId = new FactoryId(e.FactoryName.Replace(" ", "_"));

            this.layerProductionApplicationService.OpenFactory(factoryId);
        }
    }
}