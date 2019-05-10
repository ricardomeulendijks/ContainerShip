using System;
using System.Collections.Generic;
using System.Text;
using ContainerSchip.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = ContainerSchip.Logic.Type;

namespace ContainerSchip.Test
{
    [TestClass]
    public class SliceTest
    {
        private Ship _ship;
        private List<Container> _containers = new List<Container>();

        [TestInitialize]
        public void Prep()
        {
            _ship = new Ship(6,4);

            for (int i = 0; i < 25; i++)
            {
                Container container = new Container()
                {
                    Placed = true,
                    Type = Type.Normal
                };

                container.SetWeight(2400);
                _containers.Add(container);
            }
        }

        [TestMethod]
        public void SliceAddsBlockingContainersToList()
        {
            _ship.PlaceNormal(_containers);
            List<Container> blocked = _ship.ShipSides[0].ShipSlices[0].GetblockingContainer(1, 1);

            Assert.AreEqual(1, blocked.Count);

        }

    }
}
