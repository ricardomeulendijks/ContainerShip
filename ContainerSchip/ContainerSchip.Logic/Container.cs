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
        public int Weight { get; private set; } = MinWeight;
        public static int MinWeight { get; } = 4000;
        public static int MaxWeight { get; } = 30000;
        public static int MaxStackWeight { get; } = 120000;

        public bool Placed { get; set; }

        public void SetWeight(int value)
        {
            Weight = Weight + value;
        }

        public override string ToString()
        {
            return Type.ToString() + " " + Weight.ToString();
        }
    }
}
