using NUnit.Framework;

namespace Onion.Factory
{
    [TestFixture]
    public class Application
    {
        private LayerProductionView view;

        private LayerProductionPresenter presenter;

        [SetUp]
        public void SetUp()
        {
            this.view = new LayerProductionView();
            this.presenter = new LayerProductionPresenter(this.view);
            this.presenter.Initialize();
        }

        [Test]
        public void Run()
        {
            this.view.ClickOpenFactory();
            this.view.ClickProduceLayer();
        }
    }
}
