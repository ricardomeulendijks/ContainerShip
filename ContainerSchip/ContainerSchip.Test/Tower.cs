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

        [TestInitialize]
        public void Prep()
        {
            for (int i = 0; i < 5; i++)
            {
                Container container = new Container()
                {
                    Placed = false,
                    Type = Type.Normal
                };
                container.SetWeight(10000);
                _containers.Add(container);
            }
            
        }

        [TestMethod]
        public void GetFirstEmptySpotInTower()
        {
            _ship = new Ship(1,2);
            _ship.Place(_containers);

            Assert.AreEqual(3,_ship.ShipSides[0].ShipSlices[0].Towers[0].GetFirstEmptySpot());
            Assert.AreEqual(2,_ship.ShipSides[1].ShipSlices[0].Towers[0].GetFirstEmptySpot());
        }

    }
}
