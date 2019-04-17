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

        public ShipTower(int height, Type type)
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

            for (int i = 0; i < height; i++)
            {
                ContainerSpot normalSpot = new ContainerSpot() { Cooled = false, SpotFilled = false };
                ContanerSpots.Add(normalSpot);
                Type = Type.Normal;
            }
        }
    }
}
