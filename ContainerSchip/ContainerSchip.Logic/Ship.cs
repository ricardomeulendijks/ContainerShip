using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class Ship
    {
        private readonly Container _container = new Container();
        public List<ShipSide> shipSides = new List<ShipSide>();
        public int MaxLoad = 120000;



        public Ship(int length, int width)
        {
            if (width % 2 != 0) throw new ArgumentException("Width needs to be even");
            int height = (MaxLoad + _container.MinWeight) / _container.MinWeight; 
            int sideWidth = width/2; 


            shipSides.Add(new ShipSide(length,sideWidth,height));
            shipSides.Add(new ShipSide(length, sideWidth, height));

        }

    }
}
