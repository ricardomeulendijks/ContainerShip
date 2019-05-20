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
    public class TowerTest
    {
        private Ship _ship;
        private List<Container> _containers = new List<Container>();
        private readonly TestHelper _helper = new TestHelper();

        [TestInitialize]
        public void Prep()
        {
            _containers = _helper.GenerateContainers(Type.Normal, 10000, 5);
        }

        [TestMethod]
        public void GetFirstEmptySpotInTower()
        {
            _ship = new Ship(1,2);
            _ship.PlaceNormal(_containers);

            Assert.AreEqual(3,_ship.ShipSides[0].ShipSlices[0].Towers[0].GetFirstEmptySpot());
            Assert.AreEqual(2,_ship.ShipSides[1].ShipSlices[0].Towers[0].GetFirstEmptySpot());
        }



    }
}
