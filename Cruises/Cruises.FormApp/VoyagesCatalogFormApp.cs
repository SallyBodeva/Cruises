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
    public partial class VoyagesCatalogFormApp : Form
    {
        private VoyageService vService;
        private AdditionalService aService;
        private HarbourService hService;
        private int voyageId;
        private static List<Voyage> voyages;
        public VoyagesCatalogFormApp()
        {
            InitializeComponent();
            vService = new VoyageService();
            aService = new AdditionalService();
            hService = new HarbourService();
        }

        private void VoyagesCatalogFormApp_Load(object sender, EventArgs e)
        {
            voyages = vService.GetVoyages();
            Voyage v = voyages.First();
            voyageId = v.Id;
            DataFill();
        }

        private void DataFill()
        {
            textBoxFromHName.Text = vService.GetVoyageHarboursNameById(voyageId);
            textBoxFromCity.Text = hService.GetHarbourCityNameByVoyageId(voyageId);
            textBoxToHNmae.Text = vService.GetVoyageDestHarboursNameById(voyageId);
            textBoxToCity.Text = hService.GetDesHarbourCityNameByVoyageId(voyageId);
            textBoxDuration.Text = vService.GetVoyageDurationById(voyageId).ToString();
            textBoxShipName.Text = vService.GetVoyageShupNameById(voyageId);
            textBoxTicketPrice.Text = vService.GetVoyageTicketPriceById(voyageId).ToString();
            textBoxFromCountry.Text = hService.GetHarbourCountryNameByVoyageId(voyageId);
            textBoxToCountry.Text = hService.GetDesHarbourCountryNameByVoyageId(voyageId);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            voyages = vService.GetVoyages();
            Voyage v = voyages.First();
            if (voyageId!=v.Id)
            {
                voyageId--;
            }
            DataFill();
        }

        private void buttonNetx_Click(object sender, EventArgs e)
        {
            voyages = vService.GetVoyages();
            Voyage v = voyages.Last();
            if (voyageId != v.Id)
            {
                voyageId++;
            }
            DataFill();
        }
    }
}
