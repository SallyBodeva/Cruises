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
        private int shipIndex;
        private static List<Ship> ships;
        public ShipsCatalogFormApp()
        {
            InitializeComponent();
            shipService = new ShipService();
        }

        private void buttonPr_Click(object sender, EventArgs e)
        {
            try
            {
                ships = shipService.GetShips();
                Ship s = ships[0];
                if (shipId != s.Id)
                {
                    shipIndex--;
                    shipId = ships[shipIndex - 1].Id;
                }
                DataFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                ships = shipService.GetShips();
                Ship s = ships.Last();
                Ship sF = ships.First();
                if (shipId != s.Id)
                {
                    shipIndex++;
                    shipId= ships[shipIndex].Id;
                }
                else
                {
                    shipId = sF.Id;
                }
                DataFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShipsCatalogFormApp_Load(object sender, EventArgs e)
        {
            try
            {
                ships = shipService.GetShips();
                shipId = ships[0].Id;
                DataFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void DataFill()
        {
            try
            {
                textBoxName.Text = shipService.GetShipName(shipId);
                textBoxModel.Text = shipService.GetShipModel(shipId);
                textBoxCapacity.Text = shipService.GetShipCapacity(shipId).ToString();
                textBoxTyoeName.Text = shipService.GetShipType(shipId);
                pictureBox1.Load(shipService.GetShipImageURL(shipId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
