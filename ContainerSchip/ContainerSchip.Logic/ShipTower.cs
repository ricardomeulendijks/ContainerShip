using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class ShipTower
    {
        public List<ContainerSpot> ContanerSpots { get; set; } = new List<ContainerSpot>();
        public Type Type { get; set; }
        public int Height { get; set; }

        public ShipTower(int height, Type type)
        {
            Height = height;
            GenerateSpots(type,height);
        }

        private void GenerateSpots(Type type, int height)
        {
            if (type == Type.Cooled)
            {
                for (int i = 0; i < height; i++)
                {
                    ContainerSpot cooledSpot = new ContainerSpot() { Cooled = true, SpotFilled = false };
                    ContanerSpots.Add(cooledSpot);
                    Type = Type.Cooled;
                }
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    ContainerSpot normalSpot = new ContainerSpot() { Cooled = false, SpotFilled = false };
                    ContanerSpots.Add(normalSpot);
                    Type = Type.Normal;
                }
            }
        }

        public bool ContainerFits(Container container)
        {
            return (CalculateWeight() + container.Weight <= Ship.MaxHeightLoad);
        }

        public int CalculateWeight()
        {
            int weight = 0; 
            foreach (var spot in ContanerSpots)
            {
                if (spot.Container != null)
                {
                    weight = weight + spot.Container.Weight;
                }
            }

            return weight; 
        }

        public int GetFirstEmptySpot()
        {
            int index = -1;
            for (int i = 0; i < ContanerSpots.Count; i++)
            {
                if (!ContanerSpots[i].SpotFilled)
                {
                    index = i;
                    break;
                }
            }

            return index; 
        }

    }
}
