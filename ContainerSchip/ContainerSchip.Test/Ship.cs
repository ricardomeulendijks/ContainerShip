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
        }

        [TestMethod]
        public void LoadBalancingContainers()
        {
            Ship ship = new Ship(_length,_width);
            List<Container> containers = new List<Container>();

            for (int i = 0; i < 11; i++)
            {
                Container container = new Container()
                {
                    Placed = true,
                    Type = Type.Normal,
                    Weight = 3000
                };

                containers.Add(container);              
            }

            Assert.IsTrue(ship.Place(containers));



            Trace.WriteLine(ship.ShipSides[0].CalculateWeight() + " / " + ship.ShipSides[1].CalculateWeight());
        }


    }
}
