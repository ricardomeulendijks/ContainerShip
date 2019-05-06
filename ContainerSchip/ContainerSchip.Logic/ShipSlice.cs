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
            GenerateOneCooledTower(height);
            GenerateMultipleNormalTowers(length, height);
        }

        private void GenerateOneCooledTower(int height)
        {
            ShipTower cooled = new ShipTower(height, Type.Cooled);
            cooled.Type = Type.Cooled;
            Towers.Add(cooled);
        }

        private void GenerateMultipleNormalTowers(int shiplength, int height)
        {
            for (int i = 0; i < shiplength - 1; i++)
            {
                ShipTower tower = new ShipTower(height, Type.Normal);
                tower.Type = Type.Normal;
                Towers.Add(tower);
            }
        }

        public int GetMostEmptyTower()
        {
            return Towers.IndexOf(Towers.Find(c => c.CalculateWeight() == Towers.Min(a => a.CalculateWeight())));
        }

        public int CalculateWeight()
        {
            int weight = 0;
            foreach (var tower in Towers)
            {
               weight = weight + tower.CalculateWeight();
            }

            return weight;
        }
    }
}
