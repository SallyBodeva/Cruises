using Cruises.Models;
using Cruises.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cruises.FormApp
{
    public partial class ReceiptFormApp : Form
    {
        private VoyageService voyageService;
        private PassengerService passengerService;
        public ReceiptFormApp()
        {
            InitializeComponent();
            voyageService = new VoyageService();
            passengerService = new PassengerService();
        }

        private void ReceiptFormApp_Load(object sender, EventArgs e)
        {
            int passengerId = voyageService.GetLastAddedPassenger();
            textBoxName.Text = passengerService.GetPassengerNameById(passengerId);
            textBoxPhoneNum.Text = passengerService.GetPassengerPhoneById(passengerId);
            Passenger p = passengerService.GetPassengerById(passengerId);
            if (p.IsRetiree || p.IsStudent)
            {
                decimal price = passengerService.GetPassengerTiocketPriceById(passengerId) / 2;
                textBoxPrice.Text = Math.Round(price,2).ToString();
            }
            else
            {
                textBoxPrice.Text = passengerService.GetPassengerTiocketPriceById(passengerId).ToString();
            }
        }
    }
}
