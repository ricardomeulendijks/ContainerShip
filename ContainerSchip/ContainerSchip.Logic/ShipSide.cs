using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class ShipSide
    {
        public List<ShipSlice> ShipSlices { get; set; } = new List<ShipSlice>();

        public ShipSide(int length, int width, int height)
        {
            GenerateShipSlices(width,length,height);
        }

        private void GenerateShipSlices(int width, int length, int height)
        {
            for (int i = 0; i < width; i++)
            {
                ShipSlice slice = new ShipSlice(length, height);
                ShipSlices.Add(slice);
            }
        }

        public List<HighValueIndex> GetHighValueIndexes()
        {
            List<HighValueIndex> values = new List<HighValueIndex>();

            foreach (var slice in ShipSlices)
            {
                for (int tower = 0; tower < slice.Towers.Count; tower++)
                {
                    for (int spot = 0; spot < slice.Towers[tower].ContanerSpots.Count; spot++)
                    {
                        if (slice.PosibleToAddHighValueContainer(tower, spot))
                        {
                            HighValueIndex index = new HighValueIndex();
                            index.Spot = spot;
                            index.Tower = tower;
                            index.Slice = ShipSlices.IndexOf(slice);
                            values.Add(index);
                        }
                    }
                }
            }

            return values;
        }

        public int GetMostEmptyCooledSlice()
        {
            return ShipSlices.IndexOf(ShipSlices.Find(c => c.Towers[0].CalculateWeight() == ShipSlices.Min(a => a.Towers[0].CalculateWeight())));
        }

        public int GetMostEmptySlice()
        {
            return ShipSlices.IndexOf(ShipSlices.Find(c => c.CalculateWeight() == ShipSlices.Min(a => a.CalculateWeight())));
        }

        public int CalculateWeight()
        {
            int weight = 0;
            foreach (var slice in ShipSlices)
            {
                weight = weight + slice.CalculateWeight();
            }

            return weight; 
        }
    }
}
