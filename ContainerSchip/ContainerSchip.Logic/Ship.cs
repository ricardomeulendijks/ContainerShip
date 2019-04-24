using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class Ship
    {
        private readonly Container _container = new Container();
        public List<ShipSide> ShipSides = new List<ShipSide>();
        public int MaxLoad = 120000;

        public Ship(int length, int width)
        {
            int height = GetMaxHeightOfRows();
            if(!WidthOfShipIsEven(width)) throw new ArgumentException("Sides are not equal");
            GenerateShipSides(width,length,height);
        }

        private void GenerateShipSides(int width, int length, int height)
        {
            int sideWidth = width / 2;

            ShipSides.Add(new ShipSide(length, sideWidth, height));
            ShipSides.Add(new ShipSide(length, sideWidth, height));
        }

        private bool WidthOfShipIsEven(int width)
        {
            return width % 2 == 0;
        }

        private int GetMaxHeightOfRows()
        {
            return (MaxLoad + _container.MinWeight) / _container.MinWeight;
        }

        public void AddCooledContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
               
            }
        }

    }
}
