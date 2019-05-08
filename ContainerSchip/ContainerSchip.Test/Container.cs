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
    public class ContainerTest
    {
        private Ship _ship;

        [TestInitialize]
        public void Prep()
        {

        }

        [TestMethod]
        public void SetWeight()
        {
            int weight = 3500; 

            Container container = new Container()
            {
                Placed = false,
                Type = Type.Normal
            };
                container.SetWeight(weight);

            Trace.WriteLine(weight + Container.MinWeight + " / " +container.Weight);
            Assert.AreEqual(weight + Container.MinWeight, container.Weight );
        }

    }
}
