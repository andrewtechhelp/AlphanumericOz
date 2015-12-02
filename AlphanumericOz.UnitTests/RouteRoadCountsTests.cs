using AlphanumericOz.Core.Services;
using AlphanumericOz.Core.ViewModels;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.Platform;
using Cirrious.MvvmCross.Test.Core;
using Cirrious.MvvmCross.Views;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace AlphanumericOz.UnitTests
{
    [TestFixture] [ExcludeFromCodeCoverage]
    public class RouteRoadCountsTests : MvxIoCSupportingTest
    {
        protected MockDispatcher MockDispatcher { get; private set; }

        protected override void AdditionalSetup()
        {
            MockDispatcher = new MockDispatcher();
            Ioc.RegisterSingleton<IMvxViewDispatcher>(MockDispatcher);
            Ioc.RegisterSingleton<IMvxMainThreadDispatcher>(MockDispatcher);
            Ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());

            var routeGenesisService = new RoutesGenesisService();
            Ioc.RegisterSingleton<IRoutesGenesisService>(routeGenesisService);
        }

        //Test Constants
        const int M1Count = 4;
        const int M2Count = 4;
        const int M3Count = 5;
        const int M4Count = 1;
        const int M5Count = 3;
        const int M6Count = 1;
        const int M7Count = 4;
        const int M15Count = 1;
        const int A3Count = 2;
        const int A5Count = 1;
        const int A7Count = 1;
        const int Metroad2Count = 4;
        const int Metroad5Count = 11;
        const int NR13Count = 2;


        [Test]
        public void M1RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M1";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M1Count, viewModel.Roads.Count);
        }

        [Test]
        public void M2RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M2";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M2Count, viewModel.Roads.Count);
        }

        [Test]
        public void M3RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M3";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M3Count, viewModel.Roads.Count);
        }

        [Test]
        public void M4RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M4";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M4Count, viewModel.Roads.Count);
        }

        [Test]
        public void M5RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M5";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M5Count, viewModel.Roads.Count);
        }

        [Test]
        public void M6RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M6";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M6Count, viewModel.Roads.Count);
        }

        [Test]
        public void M7RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M7";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M7Count, viewModel.Roads.Count);
        }

        [Test]
        public void M15RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "M15";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(M15Count, viewModel.Roads.Count);
        }

        [Test]
        public void A3RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "A3";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(A3Count, viewModel.Roads.Count);
        }

        [Test]
        public void A5RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "A5";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(A5Count, viewModel.Roads.Count);
        }

        [Test]
        public void A7RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "A7";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(A7Count, viewModel.Roads.Count);
        }

        [Test]
        public void Metroad2RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "Metroad 2";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(Metroad2Count, viewModel.Roads.Count);
        }

        [Test]
        public void Metroad5RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "Metroad 5";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(Metroad5Count, viewModel.Roads.Count);
        }

        [Test]
        public void NR13RoadCountTest()
        {
            // Arrange
            ClearAll();
            base.Setup();
            var routeNumber = "National Route 13";

            // Act
            var viewModel = new RouteViewModel(Mvx.Resolve<IRoutesGenesisService>());
            viewModel.Init(routeNumber);
            // Assert
            Assert.AreEqual(NR13Count, viewModel.Roads.Count);
        }
    }
}
