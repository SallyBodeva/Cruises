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
        private ShipService sService;
        private int voyageId;
        private int voyageIindex;
        private static List<Voyage> voyages;
        public VoyagesCatalogFormApp()
        {
            InitializeComponent();
            vService = new VoyageService();
            aService = new AdditionalService();
            hService = new HarbourService();
            sService = new ShipService();
        }

        private void VoyagesCatalogFormApp_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox4.SendToBack();
                voyages = vService.GetVoyages();
                voyageId = voyages[0].Id ;
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
                textBoxName.Text = vService.GetVoyageNameById(voyageId);
                pictureBox1.Load(sService.GetShipImageById(voyageId));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                voyages = vService.GetVoyages();
                Voyage v = voyages[0];
                if (voyageId != v.Id)
                {
                    voyageIindex--;
                    voyageId = voyages[voyageIindex].Id;
                }
                DataFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void buttonNetx_Click(object sender, EventArgs e)
        {
            try
            {
                voyages = vService.GetVoyages();
                Voyage v = voyages[voyages.Count-1];
                if (voyageId != v.Id)
                {
                    voyageIindex++;
                    voyageId=voyages[voyageIindex].Id;
                }
                DataFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

       
    }
}
