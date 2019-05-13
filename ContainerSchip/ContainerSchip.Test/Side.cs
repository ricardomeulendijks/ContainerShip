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
    public class SideTest
    {
        private Ship _ship;
        private List<Container> _containers = new List<Container>(); 

        [TestInitialize]
        public void Prep()
        {

        }

        [TestMethod]
        public void GetSliceWithTheMostEmptyCooledTower()
        {
            _ship = new Ship(1, 4);
            Container container = new Container();
            container.Type = Type.Cooled; 
            container.SetWeight(24000);
            _containers.Add(container);

            _ship.PlaceCooled(_containers);

            Assert.AreEqual(1, _ship.ShipSides[0].GetMostEmptyCooledSlice()); 
        }

        [TestMethod]
        public void GetAllPossibleHighValueIndexes()
        {
            _ship = new Ship(4, 4);
            Assert.AreEqual(8, _ship.ShipSides[0].GetHighValueIndexes().Count);
            Assert.AreEqual(8, _ship.ShipSides[1].GetHighValueIndexes().Count);
        }

    }
}
