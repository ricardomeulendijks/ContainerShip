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
            if (SpotFilled == true || Container != null) return false;

            Container = container;
            Container.Placed = true;
            SpotFilled = true;
            return true;

        }
    }
}
