using System;
using System.Collections.Generic;
using System.Diagnostics;
using ContainerSchip.Logic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = ContainerSchip.Logic.Type;

namespace ContainerSchip.Test
{
    [TestClass]
    public class ShipTest
    {
        private Ship _ship;
        private Container _container;
        private readonly TestHelper _helper = new TestHelper(); 
        private int _length;
        private int _width;

        [TestInitialize]
        public void Prep()
        {
            _length = 5;
            _width = 6;
            _ship = new Ship(_length,_width);
        }


        [TestMethod]
        public void PlaceCooledContainers()
        {
            List<Container> containers = _helper.GenerateContainers(Type.Cooled, 24000, 12);

            Assert.AreEqual(0,_ship.PlaceCooled(containers).Count);
            double side1 = _ship.ShipSides[0].CalculateWeight();
            double side2 = _ship.ShipSides[1].CalculateWeight();

            Trace.WriteLine(side1 + " / " + side2 + " Percentage " + _ship.GetLoadBalancingPercentage() + " %");

        }

        [TestMethod]
        public void LoadBalancingContainers()
        {
            List<Container> containers = _helper.GenerateContainers(Type.Normal, 3000, 11);

            Assert.AreEqual(0, _ship.PlaceNormal(containers).Count);
            double side1 = _ship.ShipSides[0].CalculateWeight();
            double side2 = _ship.ShipSides[1].CalculateWeight();

            Trace.WriteLine(side1 + " / " + side2 + " Percentage "+ _ship.GetLoadBalancingPercentage() + " %");
        }


        [TestMethod]
        public void ShipIsMoreThen50PercentLoaded()
        {
            _ship = new Ship(1,2);

            List<Container> containers = _helper.GenerateContainers(Type.Normal, 26000, 10);

            _ship.PlaceNormal(containers); 
            Assert.AreEqual(true, _ship.ShipIsMoreThenFiftyPercentLoaded());

        }

        [TestMethod]
        public void PlaceAllContainers()
        {
            List<Container> normal = _helper.GenerateContainers(Type.Normal, 1000, 10);
            List<Container> cooled = _helper.GenerateContainers(Type.Cooled, 1000, 10);
            List<Container> highValue = _helper.GenerateContainers(Type.HighValue, 1000, 10);

            _ship = new Ship(5, 6);
            Assert.AreEqual(0, _ship.PlaceContainers(normal, cooled, highValue).Count);

        }


        [TestMethod]
        public void DiferenceBetweenSidesIsNotMoreThen20Percent()
        {
            List<Container> normal = _helper.GenerateContainers(Type.Normal, 1000, 11);
            List<Container> cooled = _helper.GenerateContainers(Type.Cooled, 1000, 10);
            List<Container> highValue = _helper.GenerateContainers(Type.HighValue, 1000, 10);

            _ship.PlaceContainers(normal, cooled, highValue); 

            double percentage = _ship.GetLoadBalancingPercentage(); 
            Trace.WriteLine(percentage + " %");
            Assert.IsTrue(_ship.GetLoadBalancingPercentage() < 20);

        }

    }
}
