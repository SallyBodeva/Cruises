using Cruises.Models;
using Cruises.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cruises.FormApp
{
    public partial class ShipsCatalogFormApp : Form
    {
        private ShipService shipService;
        private int shipId;
        private static List<Ship> ships;
        public ShipsCatalogFormApp()
        {
            InitializeComponent();
            shipService = new ShipService();
        }

        private void buttonPr_Click(object sender, EventArgs e)
        {
            ships = shipService.GetShips();
            Ship s = ships.First();
            if (shipId != s.Id)
            {
                shipId--;
            }
            DataFill();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            ships = shipService.GetShips();
            Ship s = ships.Last();
            Ship sF = ships.First();
            if (shipId != s.Id)
            {
                shipId++;
            }
            else
            {
                shipId = sF.Id;
            }
            DataFill();
        }

        private void ShipsCatalogFormApp_Load(object sender, EventArgs e)
        {
            ships = shipService.GetShips();
            Ship s = ships.First();
            shipId = s.Id;
            DataFill();
        }
        private void DataFill()
        {
            textBoxName.Text = shipService.GetShipName(shipId);
            textBoxModel.Text = shipService.GetShipModel(shipId);
            textBoxCapacity.Text = shipService.GetShipCapacity(shipId).ToString();
            textBoxTyoeName.Text = shipService.GetShipType(shipId);
            pictureBox1.Load(shipService.GetShipImageURL(shipId));
        }

    }
}
