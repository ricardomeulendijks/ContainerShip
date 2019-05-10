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
            for (int i = 0; i < 10; i++)
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
            _ship = new Ship(4, 4);

            _ship.PlaceNormal(_containers);
            List<Container> blocked = _ship.ShipSides[0].ShipSlices[0].GetblockingContainers(1,0);

            Assert.AreEqual(2, blocked.Count);
        }

        [TestMethod]
        public void NotpossibleToAddOnPlaceWhereAlreadyContainerExists()
        {
            _ship = new Ship(2, 2);

            _ship.PlaceNormal(_containers);
            Assert.AreEqual(false,_ship.ShipSides[0].ShipSlices[0].PosibleToAddContainer(1, 1));
        }

        [TestMethod]
        public void PossibleToAddHighValue()
        {
            _ship = new Ship(2, 2);

            _ship.PlaceNormal(_containers);
            Assert.AreEqual(true, _ship.ShipSides[0].ShipSlices[0].PosibleToAddContainer(1, 3));
        }

    }
}
