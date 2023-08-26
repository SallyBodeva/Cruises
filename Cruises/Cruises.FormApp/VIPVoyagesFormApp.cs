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
    public partial class VIPVoyagesFormApp : Form
    {
        private HarbourService harbourService;
        private ShipService shipService;
        private VoyageService vServic;
        private List<string> harbours;
        private List<string> ships;
        public VIPVoyagesFormApp()
        {
            InitializeComponent();
            harbourService = new HarbourService();
            shipService = new ShipService();
            vServic = new VoyageService();
        }

        private void VIPVoyagesFormApp_Load(object sender, EventArgs e)
        {
            harbours = harbourService.GetBasicHarbourInfo();
            harbours.ForEach(x => comboBoxFH.Items.Add(x));
            harbours.ForEach(x => comboBoxTH.Items.Add(x));
            ships = shipService.GetBasicShipInfo();
            ships.ForEach(x => comboBoxShip.Items.Add(x));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string fH = comboBoxFH.Text.Split(" - ").FirstOrDefault();
            string tH = comboBoxTH.Text.Split(" - ").FirstOrDefault();
            int duration = int.Parse(textBoxDuration.Text);
            string ship = comboBoxShip.Text.Split(" - ").FirstOrDefault();
            string result = vServic.CreateVoyage(name, fH, tH, duration, ship, 200);
            MessageBox.Show(result);

            textBoxName.Text = string.Empty;
            comboBoxFH.Text = string.Empty;
            comboBoxTH.Text = string.Empty;
            textBoxDuration.Text = string.Empty;
            comboBoxShip.Text = string.Empty;
        }
    }
}
