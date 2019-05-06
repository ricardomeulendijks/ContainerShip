using System;
using System.Diagnostics;
using ContainerSchip.Logic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = ContainerSchip.Logic.Type;

namespace ContainerSchip.Test
{
    [TestClass]
    public class GridTest
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
        [ExpectedException(typeof(ArgumentException))]
        public void ShipThrowsExeptionByOddWidth()
        {
            _width = 5;
            _ship = new Ship(_length,_width);
        }

        [TestMethod]
        public void ShipHasTwoSides()
        {
            _ship = new Ship(_length, _width);
            int sides = _ship.ShipSides.Count; 

            Assert.AreEqual(2, sides);
        }

        [TestMethod]
        public void RowSizeIsEqualWithShipSize()
        {
            _ship = new Ship(_length, _width);
            int rowLength = _ship.ShipSides[0].ShipSlices[0].Towers.Count;
            Trace.WriteLine(rowLength);

            Assert.AreEqual(rowLength, _length); 
        }

        [TestMethod]
        public void AnyFirstSpotsAreCooled()
        {
            _ship = new Ship(_length, _width);

            // for every side
            for (int side = 0; side < _ship.ShipSides.Count; side++)
            {
                // for every slice
                for (int slice = 0; slice < _ship.ShipSides[side].ShipSlices.Count; slice++)
                {
                    // for every tower exept the first
                    for (int tower = 1; tower < _ship.ShipSides[side].ShipSlices[slice].Towers.Count; tower++)
                    {
                        // for every spot
                        for (int spot = 0;
                            spot < _ship.ShipSides[side].ShipSlices[slice].Towers[tower].ContanerSpots.Count;
                            spot++)
                        {
                            if (_ship.ShipSides[side].ShipSlices[slice].Towers[0].ContanerSpots[spot].Cooled == false)
                            {
                                Assert.Fail();
                            }
                        }
                    }
                }
            }
            Trace.WriteLine("Every spot is cooled");
            Assert.IsTrue(true);
            
        }

        [TestMethod]
        public void AnySpotsAreNormalExeptTheFirst()
        {
            _ship = new Ship(_length, _width);
            
            // for every side
            for (int side = 0; side < _ship.ShipSides.Count; side++)
            {
                // for every slice
                for (int slice = 0; slice < _ship.ShipSides[side].ShipSlices.Count; slice++)
                {
                    // for every tower exept the first
                    for (int tower = 1; tower < _ship.ShipSides[side].ShipSlices[slice].Towers.Count; tower++)
                    {
                        // for every spot
                        for (int spot = 0; spot < _ship.ShipSides[side].ShipSlices[slice].Towers[tower].ContanerSpots.Count; spot++)
                        {
                            if (_ship.ShipSides[side].ShipSlices[slice].Towers[tower].ContanerSpots[spot].Cooled == true)
                            {
                                Assert.Fail();
                            }
                        }
                    }
                }
            }

            Trace.WriteLine("Every spot is normal");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SpotsAreNeverHigherThenNeeded()
        {
            _ship = new Ship(_length, _width);
            _container = new Container();

            int shipHeight = _ship.ShipSides[0].ShipSlices[0].Towers[0].Height;
            int maxHeight = (Ship.MaxHeightLoad + Container.MinWeight) / Container.MinWeight;

            Trace.WriteLine("Schiphoogte: " + shipHeight);
            Trace.WriteLine("Maximale hoogte: " + maxHeight);
            Assert.AreEqual(shipHeight,maxHeight);
        }


    }
}
