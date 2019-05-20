using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private readonly TestHelper _helper = new TestHelper();

        [TestInitialize]
        public void Prep()
        {
            _containers = _helper.GenerateContainers(Type.Normal, 2400, 10);
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
            Assert.AreEqual(false,_ship.ShipSides[0].ShipSlices[0].PosibleToAddHighValueContainer(1, 1));
        }

        [TestMethod]
        public void PossibleToAddHighValue()
        {
            _ship = new Ship(6,6);

            _ship.PlaceNormal(_containers);
            Assert.AreEqual(true, _ship.ShipSides[0].ShipSlices[0].PosibleToAddHighValueContainer(0,1));
        }

    }
}
