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
    public partial class AssignCrewToVoyageFormApp : Form
    {
        VoyageService voyageService;
        CrewService crewService;

        int currentVoyagePage = 1;
        int totalVoyagePage = 1;


        int currentCrewPage = 1;
        int totalCrewPage = 1;
        public AssignCrewToVoyageFormApp()
        {
            InitializeComponent();
            voyageService = new VoyageService();
            crewService = new CrewService();
        }

        private void AssignCrewToVoyageFormApp_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxVoyages.Items.Clear();
                listBoxCrew.Items.Clear();
                listBoxChosenCrew.Items.Clear();

                List<string> voyages = voyageService.GetVoyagesInfo();
                voyages.ForEach(x => listBoxVoyages.Items.Add(x));

                List<string> crew = crewService.GetCrewInfo();
                crew.ForEach(x => listBoxCrew.Items.Add(x));

                comboBox1.SelectedIndex = 0;
                comboBox1.Enabled = false;

                labelSteps.Text = "Step 1: choose voyage";

                totalCrewPage = crewService.GetCrewPagesCount(10);
                labelPagesCrew.Text = $"{currentCrewPage} / {totalCrewPage}";
                buttonPrePageCrew.Enabled = false;
                buttonNextPageCrew.Enabled = false;

                listBoxVoyages.Enabled = true;
                listBoxCrew.Enabled = false;
                listBoxChosenCrew.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
