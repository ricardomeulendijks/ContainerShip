using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class Ship
    {
        private readonly Container _container = new Container();
        public List<ShipSide> ShipSides = new List<ShipSide>();
        public static int MaxHeightLoad = 120000;

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
            return (MaxHeightLoad + Container.MinWeight) / Container.MinWeight;
        }

        public int GetMostEmptySide()
        {
            return ShipSides[0].CalculateWeight() <= ShipSides[1].CalculateWeight() ? 0 : 1;
        }

        public bool Place(List<Container> containers)
        {
            int index = 0;
            foreach (var container in containers)
            {
                ShipSide side = ShipSides[GetMostEmptySide()];
                ShipSlice shipslice = side.ShipSlices[side.GetMostEmptySlice()];
                ShipTower tower = shipslice.Towers[shipslice.GetMostEmptyTower()];
                ContainerSpot spot = tower.ContanerSpots[tower.GetFirstEmptySpot()];
                if (!spot.AddContainer(container)) return false;
                index++;
            }

            Console.WriteLine(index + " Containers Placed of " + containers.Count);

            return true;
        }
    }
}
