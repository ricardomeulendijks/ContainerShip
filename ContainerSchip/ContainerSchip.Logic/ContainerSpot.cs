using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class ContainerSpot
    {
        public Container Container { get; private set; }
        public bool Cooled { get; set; }
        public bool SpotFilled;


        public bool AddContainer(Container container)
        {
            if (container.Weight > Container.MaxWeight)
            {
                Console.WriteLine("The weight of the container provided is too high");
                return false;
            }

            if (SpotFilled == true || Container != null) throw new Exception("You are trying to add an cooled container to a normal spot! ");
            if (container.Type == Type.Cooled && Cooled == false) throw new Exception("You are trying to add an cooled container to a normal spot! ");
            
            // Place Container
            Container = container;
            Container.Placed = true;
            SpotFilled = true;
            return true;

        }
    }
}
