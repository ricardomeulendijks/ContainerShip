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
        List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            foreach (Type type in (Type[])Enum.GetValues(typeof(Type)))
            {
                CbType.Items.Add(type);
            }
        }

        private bool GenerateShip()
        {
            if (Length.Value == 0 || Width.Value == 0)
            {
                MessageBox.Show("No Input", "Geef juiste waarde");
                return false;
            }

            ship = new Ship(Convert.ToInt32(Length.Value), Convert.ToInt32(Width.Value));
            return true;
        }

        private void Reset()
        {
            cooledContainers.Clear();
            normalContainers.Clear();
            highValueContainers.Clear();
            libUnplaced.Items.Clear();
            LbContainers.Items.Clear();

            foreach (var button in buttons)
            {
                Controls.Remove(button);
            }
        }

        private void AddContainerToList()
        {
            Container container = new Container();
            container.Type = (Type)CbType.SelectedItem;
            container.SetWeight(Convert.ToInt32(NbWeight.Value));
            LbContainers.Items.Add(container);

            totalWeight = totalWeight + container.Weight;
            LbWeight.Text = totalWeight.ToString();

            switch (container.Type)
            {
                case Type.Cooled:
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

        private void GenerateButtons(int side, int width, int length, int startX, int startY)
        {
            int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;

            for (int x = 0; x < (width / 2); x++)
            {
                for (int y = 0; y < length; y++)
                {
                    Button gridButton = new Button();
                    gridButton.Top = startX + (x * ButtonHeight + Distance);
                    gridButton.Left = startY + (y * ButtonWidth + Distance);
                    gridButton.Width = ButtonWidth;
                    gridButton.Height = ButtonHeight;
                    gridButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    // Possible add Buttonclick event etc..
                    this.Controls.Add(gridButton);
                    gridButton.Click += new EventHandler(this.GridButton_Click);
                    List<int> Index = new List<int>() { x, y, side };
                    gridButton.Tag = Index;
                    buttons.Add(gridButton);
                }
            }
        }

        //  =========================== On click actions ! ====================================

        private void AddContainer_Click(object sender, EventArgs e)
        {
            if (CbType.SelectedItem == null || NbWeight.Value == 0)
            {
                MessageBox.Show("Voer een gewicht en type in");
                return;
            }

            AddContainerToList();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (!GenerateShip()) return;

            List<Container> unsorted = ship.PlaceContainers(normalContainers, cooledContainers, highValueContainers);

            foreach (var container in unsorted)
            {
                libUnplaced.Items.Add(container);
            }

            lbLoad.Text = "Verschil tussen containerdeel % " + ship.GetLoadBalancingPercentage();
            loadPercentage.Text = "Schip is % gevuld " + ship.GetLoadPercentage();

            // Generate buttons for each side
            GenerateButtons(0, ship.Width,ship.Length, 10,350);
            GenerateButtons(1, ship.Width, ship.Length, ship.Width * 30 , 350);
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            List<int> index = button.Tag as List<int>;

            int x = index[0];
            int y = index[1];
            int side = index[2];


            LbContainers.Items.Clear();
            foreach (var spot in ship.ShipSides[side].ShipSlices[x].Towers[y].ContanerSpots)
            {
                if(spot.Container != null) LbContainers.Items.Add(spot.Container);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ship == null) return; 

            if (!ship.ShipIsMoreThenFiftyPercentLoaded())
            {
                MessageBox.Show("Het schip moet minimaal 50% geladen zijn");
                return;
            }

            if (!ship.LoadBalancingIsOk())
            {
                MessageBox.Show("Het schip is niet in evenwicht. Kijk uit anders valt hij dadelijk nog om!");
                return;
            }

            MessageBox.Show("Het schip is onderweg!");
            Reset();
        }
    }
}
