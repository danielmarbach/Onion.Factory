using NUnit.Framework;

namespace Onion.Factory
{
    using Onion.Factory.DependencyResolution;

    [TestFixture]
    public class Application
    {
        private OnionProductionView view;

        private OnionProductionPresenter presenter;

        [SetUp]
        public void SetUp()
        {
            this.view = new OnionProductionView();
            this.presenter = new OnionProductionPresenter(this.view, WireCore.Up());
            this.presenter.Initialize();
        }

        [Test]
        public void Run()
        {
            this.view.ClickOpenFactory();
            this.view.ClickProduceOnion();
        }
    }
}