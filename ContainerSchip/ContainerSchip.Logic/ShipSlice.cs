using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class ShipSlice
    {
        public List<ShipTower> Towers { get; set; } = new List<ShipTower>();

        public ShipSlice(int length, int height)
        {
            ShipTower cooled = new ShipTower(height, Type.Cooled);
            cooled.Type = Type.Cooled;

            Towers.Add(cooled);

            for (int i = 0; i < length - 1; i++)
            {
                ShipTower tower = new ShipTower(height, Type.Normal);
                tower.Type = Type.Normal;
                Towers.Add(tower);
            }
        }
    }
}
