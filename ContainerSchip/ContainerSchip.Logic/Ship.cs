using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ContainerSchip.Logic
{
    public class Ship
    {
        private readonly Container _container = new Container();
        public List<ShipSide> ShipSides = new List<ShipSide>();
        private readonly Random random = new Random();

        public int Length;
        public int Width; 

        public Ship(int length, int width)
        {
            Length = length;
            Width = width; 
            int height = GetMaxHeightOfRows();
            if(!WidthOfShipIsEven(Width)) throw new ArgumentException("Sides are not equal");
            GenerateShipSides(Width,length,height);
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

        public bool ShipIsMoreThenFiftyPercentLoaded()
        {
            if (GetLoadPercentage() <= 50) return false;
            return true; 
        }

        public double GetLoadPercentage()
        {
            double actualWeight = ShipSides[0].CalculateWeight() + ShipSides[1].CalculateWeight();
            double maxWeight = Length * Width * (Container.MaxStackWeight + Container.MaxWeight);

            double percentage = (double)(actualWeight / maxWeight) * 100;

            Console.WriteLine("Ship is " + percentage + "% loaded");
            return percentage;
        }

        private int GetMaxHeightOfRows()
        {
            return (Container.MaxStackWeight + Container.MinWeight) / Container.MinWeight;
        }

        public int GetMostEmptySide()
        {
            return ShipSides[0].CalculateWeight() <= ShipSides[1].CalculateWeight() ? 0 : 1;
        }

        public double GetLoadBalancingPercentage()
        {
            double side1 = ShipSides[0].CalculateWeight();
            double side2 = ShipSides[1].CalculateWeight();

            if (side1 > side2)
            {
                return (side1 - side2) / side1 * 100;
            }
            else
            {
                return (side1 - side2) / side2 * 100;
            }
        }

        public bool LoadBalancingIsOk()
        {
            return GetLoadBalancingPercentage() < 20;
        }

        public List<Container> PlaceContainers(List<Container> normal, List<Container> cooled, List<Container> highValue)
        {
            List<Container> unsorted = new List<Container>();

            if (normal.Count > 0) unsorted.AddRange(PlaceNormal(normal)); 
            if (cooled.Count > 0) unsorted.AddRange(PlaceCooled(cooled)); 
            if (highValue.Count > 0) unsorted.AddRange(PlaceHighValue(highValue));

            return unsorted; 
        }

        public List<Container> PlaceCooled(List<Container> cooledContainers)
        {
            List<Container> unplaced = new List<Container>();
            foreach (var container in cooledContainers)
            {
                ShipSide side = ShipSides[GetMostEmptySide()];
                ShipSlice slice = side.ShipSlices[side.GetMostEmptyCooledSlice()];
                ShipTower tower = slice.Towers[0];
                if (!tower.ContainerFits(container))
                {
                    unplaced.Add(container);
                }
                else
                {
                    ContainerSpot spot = tower.ContanerSpots[tower.GetFirstEmptySpot()];
                    if (!spot.AddContainer(container)) unplaced.Add(container);
                }
            }
            Console.WriteLine(unplaced.Count + " Containers not placed");
            return unplaced;
        }

        public List<Container> PlaceNormal (List<Container> normalContainers)
        {
            List<Container> unplaced = new List<Container>();
            foreach (var container in normalContainers)
            {
                ShipSide side = ShipSides[GetMostEmptySide()];
                ShipSlice shipslice = side.ShipSlices[side.GetMostEmptySlice()];
                ShipTower tower = shipslice.Towers[shipslice.GetMostEmptyTower()];

                if (!tower.ContainerFits(container)) 
                {
                    unplaced.Add(container);
                }
                else
                {
                    ContainerSpot spot = tower.ContanerSpots[tower.GetFirstEmptySpot()];
                    if (!spot.AddContainer(container)) unplaced.Add(container);
                }
            }

            Console.WriteLine("Containers not placed " + unplaced.Count);
            return unplaced;
        }
        
        public List<Container> PlaceHighValue (List<Container> highValueContainers)
        {
            List<Container> unplaced = new List<Container>();

            foreach (var container in highValueContainers)
            {
                ShipSide side = ShipSides[GetMostEmptySide()];
                List<HighValueIndex> indexes = side.GetHighValueIndexes();

                if (indexes.Count == 0)
                {
                    unplaced.Add(container);
                    continue;
                }

                HighValueIndex index = indexes[random.Next(0, indexes.Count)];
                if (!side.ShipSlices[index.Slice].Towers[index.Tower].ContanerSpots[index.Spot].AddContainer(container)) unplaced.Add(container);
            }

            return unplaced; 
        }
    }
}
