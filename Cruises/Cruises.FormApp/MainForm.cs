using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruises.FormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CrewFormaAppButon_Click(object sender, EventArgs e)
        {
            CrewFormApp crewFormApp = new CrewFormApp();
            crewFormApp.ShowDialog();
        }

        private void buttonVoyagesCatalog_Click(object sender, EventArgs e)
        {
            VoyagesCatalogFormApp vCFA = new VoyagesCatalogFormApp();
            vCFA.ShowDialog();
        }

        private void buttonResevation_Click(object sender, EventArgs e)
        {
            ReservationsFormApp rFA = new ReservationsFormApp();
            rFA.ShowDialog();
        }

        private void buttonShipsCatalog_Click(object sender, EventArgs e)
        {
            ShipsCatalogFormApp sFA = new ShipsCatalogFormApp();
            sFA.ShowDialog();
        }

        private void buttonVIP_Click(object sender, EventArgs e)
        {
            VIPVoyagesFormApp vFA = new VIPVoyagesFormApp();
            vFA.ShowDialog();
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            AssignVoyageToCrewFormApp aFA = new AssignVoyageToCrewFormApp();
            aFA.ShowDialog();
        }
    }
}
