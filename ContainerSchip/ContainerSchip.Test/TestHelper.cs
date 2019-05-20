using System.Collections.Generic;
using System.Text;
using ContainerSchip.Logic;
using Type = System.Type;

namespace ContainerSchip.Test
{
    public class TestHelper
    {
        public List<Container> GenerateContainers(Logic.Type type, int weight, int amount)
        {
            List<Container> containers = new List<Container>();
            for (int i = 0; i < amount; i++)
            {
                Container container = new Container()
                {
                    Placed = false,
                    Type = type
                };
                container.SetWeight(weight);
                containers.Add(container);
            }
            return containers;
        }
    }
}
