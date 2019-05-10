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
        private int totalWeight = 0;
        private Ship ship;
        List<Container> cooledContainers = new List<Container>();
        List<Container> normalContainers = new List<Container>();
        List<Container> highValueContainers = new List<Container>();

        public Form1()
        {
            InitializeComponent();
            foreach (Type type in (Type[])Enum.GetValues(typeof(Type)))
            {

                CbType.Items.Add(type);
            }
        }

        private void GenerateShip_Click(object sender, EventArgs e)
        {
            if (Length.Value == 0 || Width.Value == 0)
            {
                MessageBox.Show("", "No Input");
            }
            else
            {
                ship = new Ship(Convert.ToInt32(Length.Value), Convert.ToInt32(Width.Value));
            }

        }

        private void AddContainer_Click(object sender, EventArgs e)
        {

            Container container = new Container()
            {
                Type = (Type)CbType.SelectedItem
            };

            container.SetWeight(Convert.ToInt32(NbWeight.Value));
            LbContainers.Items.Add(container);

            totalWeight = totalWeight + container.Weight;
            LbWeight.Text = totalWeight.ToString();

            switch (container.Type)
            {
                case Type.Cooled :
                    cooledContainers.Add(container);
                    break;
                case Type.Normal:
                   normalContainers.Add(container);
                    break;
                case Type.HighValue:
                    highValueContainers.Add(container);
                    break;
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (ship == null)
            {
                MessageBox.Show("First Create a ship");
                return; 
            }

            if(cooledContainers.Count > 0) ship.PlaceCooled(cooledContainers);
            if(normalContainers.Count > 0) ship.PlaceNormal(normalContainers);
            GenerateButtons(ship.Width,ship.Length);
        }

        private void GenerateButtons(int width, int length)
        {
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 10;
            int start_y = 350;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    // Possible add Buttonclick event etc..
                    this.Controls.Add(tmpButton);
                }

            }
        }
    }
}
