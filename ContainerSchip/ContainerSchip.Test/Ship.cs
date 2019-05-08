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
            List<Container> containers = new List<Container>();

            for (int i = 0; i < 12; i++)
            {
                Container container = new Container()
                {
                    Placed = true,
                    Type = Type.Cooled
                };

                container.SetWeight(24000);

                containers.Add(container);
            }
            Assert.AreEqual(0,_ship.PlaceCooled(containers).Count);
            double side1 = _ship.ShipSides[0].CalculateWeight();
            double side2 = _ship.ShipSides[1].CalculateWeight();

            Trace.WriteLine(side1 + " / " + side2 + " Percentage " + _ship.GetLoadBalancingPercentage() + " %");

        }

        [TestMethod]
        public void LoadBalancingContainers()
        {
            List<Container> containers = new List<Container>();

            for (int i = 0; i < 11; i++)
            {
                Container container = new Container()
                {
                    Placed = true,
                    Type = Type.Normal
                };
                container.SetWeight(3000);

                containers.Add(container);              
            }

            Assert.AreEqual(0, _ship.Place(containers).Count);
            double side1 = _ship.ShipSides[0].CalculateWeight();
            double side2 = _ship.ShipSides[1].CalculateWeight();

            Trace.WriteLine(side1 + " / " + side2 + " Percentage "+ _ship.GetLoadBalancingPercentage() + " %");
        }


        [TestMethod]
        public void ShipIsMoreThen50PercentLoaded()
        {
            _ship = new Ship(1,2);

            List<Container> containers = new List<Container>();

            for (int i = 0; i < 10; i++)
            {
                Container container = new Container()
                {
                    Placed = true,
                    Type = Type.Normal
                };
                container.SetWeight(26000);

                containers.Add(container);
            }

            _ship.Place(containers); 
            Assert.AreEqual(true, _ship.ShipIsMoreThenFiftyPercentLoaded());

        }

    }
}
