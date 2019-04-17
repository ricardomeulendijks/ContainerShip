using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class Container
    {
        public Type Type { get; set; }
        public int MinWeight { get; } = 4000; 
        public int Weight { get; set; }
        public bool Placed { get; set; }
    }
}
