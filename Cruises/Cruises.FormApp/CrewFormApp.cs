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
    public partial class CrewFormApp : Form
    {
        private AdditionalService aService;
        private CrewService cService;
        private int currentPage = 1;
        private int itemsPerPage = 5;
        private int totalPages = 0;
        private int currentEmployeeIndex = 0;
        public CrewFormApp()
        {
            InitializeComponent();
            aService = new AdditionalService();
            cService = new CrewService();
        }

        private void CrewFormApp_Load(object sender, EventArgs e)
        {
            List<string> crewMembers = cService.GetCrewMemberBasicInfo();
            crewMembers.ForEach(x => listBoxCrew.Items.Add(x));
        }

        private void buttonHire_Click(object sender, EventArgs e)
        {
            try
            {
                string result = null;
                string firstName = textBoxFName.Text;
                string lastName = textBoxLName.Text;
                int age = int.Parse(textBoxAge.Text);
                double rating = 5.00;
                string position = textBoxPosition.Text;

                result = cService.AddCrewMember(firstName, lastName, age, rating, position);
                MessageBox.Show(result);
                ClearHirePanel();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        private void ClearHirePanel()
        {
            textBoxFName.Text = string.Empty;
            textBoxLName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxPosition.Text = string.Empty;
        }
    }
}
