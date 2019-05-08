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
    public class SpotTest
    {
        private Ship _ship;
        private List<Container> _containers = new List<Container>();

        [TestInitialize]
        public void Prep()
        {
            _ship = new Ship(1,2);
        }

        [TestMethod]
        public void HeavierThenMaxWeightCanNotBeAdded()
        {
            // Heavy Container
            Container container = new Container();
            container.Placed = false;
            container.Type = Type.Normal;
            container.SetWeight(35000);
            _containers.Add(container);

            // Normal container
            Container container1 = new Container();
            container1.Placed = false;
            container1.Type = Type.Normal;
            container1.SetWeight(3000);
            _containers.Add(container1);

            // Method returns containers that are not placed. 
            Assert.AreEqual(1,_ship.Place(_containers).Count); 
        }



    }
}
