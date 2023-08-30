﻿using Cruises.Service;
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
    public partial class AssignVoyageToCrewFormApp : Form
    {
        private VoyageService voyageService;
        private CrewService crewService;
        int currentVoyagePage = 1;
        int totalVoyagePage = 1;


        int currentCrewPage = 1;
        int totalCrewPage = 1;
        public AssignVoyageToCrewFormApp()
        {
            InitializeComponent();
            voyageService = new VoyageService();
            crewService = new CrewService();
        }

        private void AssignVoyageToCrewFormApp_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxCrew.Items.Clear();
                listBoxVoyages.Items.Clear();
                listBoxTeam.Items.Clear();
                labelChosenVoyage.Text = "-";

                List<string> voyages = voyageService.GetVoyagesInfo();
                voyages.ForEach(a => listBoxVoyages.Items.Add(a));

                List<string> crew = crewService.GetCrewInfo();
                crew.ForEach(p => listBoxCrew.Items.Add(p));

                comboBoxCount.SelectedIndex = 0;
                comboBoxCount.Enabled = false;

                labelSteps.Text = "Step 1: choose voyage";

                totalVoyagePage = voyageService.GetVoyagesPagesCount(10);
                labelPagesVoyages.Text = $"{currentVoyagePage} / {totalVoyagePage}";
                buttonPrevousV.Enabled = true;
                buttonNetxV.Enabled = true;

                totalCrewPage = crewService.GetCrewPagesCount();
                labelPagesCrew.Text = $"{currentCrewPage} / {totalCrewPage}";
                buttonPreviousCrew.Enabled = false;
                buttonNextCrew.Enabled = false;

                listBoxCrew.Enabled = false;
                listBoxVoyages.Enabled = true;
                listBoxTeam.Enabled = false;

                buttonAdd.Enabled = false;


                buttonPreviousCrew.Enabled = true;
                buttonNextCrew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxVoyages_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                comboBoxCount.Enabled = true;
                listBoxCrew.Enabled = true;
                listBoxVoyages.Enabled = false;
                labelSteps.Text = "Step 2 - select crew members";

                labelChosenVoyage.Text = listBoxVoyages.Text;
                buttonPrevousV.Enabled = false;
                buttonNetxV.Enabled = false;

                buttonNextCrew.Enabled = true;
                buttonPreviousCrew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxCrew_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string crewMember = listBoxCrew.Text;
                string crewMemberId = crewMember.Split(" - ").FirstOrDefault();
                foreach (var item in listBoxTeam.Items)
                {
                    string id = item.ToString().Split(" - ").FirstOrDefault();
                    if (crewMemberId == id)
                    {
                        MessageBox.Show("This employee is already selected");
                        return;
                    }
                }
                listBoxTeam.Items.Add(crewMember);

                if (listBoxTeam.Items.Count >= int.Parse(comboBoxCount.Text))
                {
                    listBoxCrew.Enabled = false;
                    buttonAdd.Enabled = true;

                    buttonNextCrew.Enabled = false;
                    buttonPreviousCrew.Enabled = false;

                    labelSteps.Text = "Step 3 - Confirm data";
                    comboBoxCount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int voyage = int.Parse(labelChosenVoyage.Text.Split(" - ").FirstOrDefault());
                List<int> crew = new List<int>();
                foreach (var item in listBoxTeam.Items)
                {
                    int crewMemberId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
                    crew.Add(crewMemberId);
                }
                string result = crewService.AddVoayeTeam(voyage, crew);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.AssignVoyageToCrewFormApp_Load(sender, e);
        }

        private void buttonPrevousV_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVoyagePage > 1)
                {
                    currentVoyagePage--;
                    labelPagesVoyages.Text = $"{currentVoyagePage} / {totalVoyagePage}";
                    listBoxVoyages.Items.Clear();

                    List<string> voyages = voyageService.GetVoyagesInfo(currentVoyagePage);
                    voyages.ForEach(a => listBoxVoyages.Items.Add(a));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNetxV_Click(object sender, EventArgs e)
        {
            try
            { 
                if (currentVoyagePage < totalVoyagePage)
                {
                    currentVoyagePage++;
                    labelPagesVoyages.Text = $"{currentVoyagePage} / {totalVoyagePage}";
                    listBoxVoyages.Items.Clear();

                    List<string> voyages = voyageService.GetVoyagesInfo(currentVoyagePage);
                    voyages.ForEach(a => listBoxVoyages.Items.Add(a));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPreviousCrew_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentCrewPage > 1)
                {
                    currentCrewPage--;
                    labelPagesCrew.Text = $"{currentCrewPage} / {totalCrewPage}";
                    listBoxCrew.Items.Clear();

                    List<string> crew = crewService.GetCrewMemberBasicInfo(currentCrewPage);
                    crew.ForEach(p => listBoxCrew.Items.Add(p));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNextCrew_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentCrewPage < totalCrewPage)
                {
                    currentCrewPage++;
                    labelPagesCrew.Text = $"{currentCrewPage} / {totalCrewPage}";
                    listBoxCrew.Items.Clear();

                    List<string> crew = crewService.GetCrewMemberBasicInfo(currentCrewPage);
                    crew.ForEach(p => listBoxCrew.Items.Add(p));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTeam.Items.Clear();
        }

    }
}
