using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerSchip.Logic;
using Container = ContainerSchip.Logic.Container;
using Type = ContainerSchip.Logic.Type;

namespace ContainerSchip
{
    public partial class Form1 : Form
    {
        private Ship ship;

        public Form1()
        {
            InitializeComponent();
            ship = new Ship(1, 2);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button BtnNew = new Button();
                    BtnNew.Height = 80;
                    BtnNew.Width = 80;
                    BtnNew.Location = new Point(80 * i, 80 * j);
                    BtnNew.Text = "spot";
                    this.Controls.Add(BtnNew);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Container> containers = new List<Container>();

            for (int i = 0; i < 10; i++)
            {
                Container container = new Container()
                {
                    Placed = false,
                    Type = Type.Normal,
                    Weight = 1005
                };

                containers.Add(container);
            }

            ship.Place(containers);

        }
    }
}
