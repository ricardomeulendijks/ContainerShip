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

        public List<Container> GetblockingContainers(int towerIndex, int height) 
        {
            List<Container> blockingContainers = new List<Container>();
            if (towerIndex > 0)
            {
                if (Towers[towerIndex - 1].ContanerSpots[height].Container != null) blockingContainers.Add(Towers[towerIndex - 1].ContanerSpots[height].Container);
            }

            if (towerIndex < Towers.Count - 1)
            {
                if (Towers[towerIndex + 1].ContanerSpots[height].Container != null) blockingContainers.Add(Towers[towerIndex + 1].ContanerSpots[height].Container);
            }

            return blockingContainers; 
        }

        public bool PosibleToAddContainer(int towerIndex, int height)
        {
            List<Container> blockingContainers = GetblockingContainers(towerIndex, height);

            // Container doesn't get blocked or container behind is not important
            if (blockingContainers.Count == 0 || blockingContainers[0].Type != Type.HighValue) return true;

            // Container got blocked
            if (blockingContainers.Count == 2) return false;

            // Other Container doesn't get blocked
            if (GetblockingContainers(towerIndex - 1, height).Count == 0 && GetblockingContainers(towerIndex + 1, height).Count == 0) return true;
            
            // Other Container gets blocked
            return false; 

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
