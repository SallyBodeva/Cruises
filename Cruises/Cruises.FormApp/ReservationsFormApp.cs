using Cruises.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cruises.FormApp
{
    public partial class ReservationsFormApp : Form
    {
        private PassengerService pService;
        private VoyageService vService;
        public ReservationsFormApp()
        {
            InitializeComponent();
            pService = new PassengerService();
            vService = new VoyageService();
        }

        private void buttonMakeReservation_Click(object sender, EventArgs e)
        {
            string fName = textBoxFName.Text;
            string lName = textBoxLname.Text;
            string phoneNum = textBoxPhoneNum.Text;
            if (phoneNum.Count() != 10)
            {
                MessageBox.Show("Phone number should be 10 symbols...");
                return;
            }
            int age = int.Parse(textBoxAge.Text);
            bool isStudent = radioButtonStudent.Checked;
            bool isRetiree = radioButtonRetiree.Checked;
            string result = string.Empty;
            if (!pService.IsPassengerAlreayOurClient(phoneNum))
            {
                result = pService.AddPassenger(fName, lName, phoneNum, age, isStudent, isRetiree);
            }
            else
            {
                result = "Our old client pick a new adventure";
            }
            SharingData.Information = phoneNum;
            int idPassenger = pService.GetPassengerIdByPhoneNum(phoneNum);
            int idVoyage = vService.GetVoyageIdByName(comboBoxVoyages.Text);
            DateTime date = dateTimePicker1.Value;
            string resultManytoManyTables = pService.MatchPassengerToVoyage(idPassenger,idVoyage,date);
            string finalResult = $"{result}{Environment.NewLine}{resultManytoManyTables}";
            MessageBox.Show(finalResult);
            ReceiptFormApp receiptFormApp = new ReceiptFormApp();
            receiptFormApp.ShowDialog();
        }

        private void ReservationsFormApp_Load(object sender, EventArgs e)
        {
            List<string> voyagesNames = vService.GetVoyagesName();
            voyagesNames.ForEach(x => comboBoxVoyages.Items.Add(x));
        }

    }
}
