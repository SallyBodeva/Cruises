using Cruises.Models;
using Cruises.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
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
        private int currentCrewMemberIndex = 0;
        public CrewFormApp()
        {
            InitializeComponent();
            aService = new AdditionalService();
            cService = new CrewService();
        }

        private void CrewFormApp_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> crewMembers = cService.GetCrewMemberBasicInfo();
                crewMembers.ForEach(x => listBoxCrew.Items.Add(x));
                groupHire.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                totalPages = cService.GetCrewPagesCount(itemsPerPage);
                labelPageNum.Text = $"{currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
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

        private void buttonFire_Click(object sender, EventArgs e)
        {
            try
            {
                currentCrewMemberIndex = int.Parse(textBoxIdFire.Text);
                CrewMember cm = cService.GetCrewMemberById(currentCrewMemberIndex);
                string result = cService.DeleteCrewMemberById(currentCrewMemberIndex);
                MessageBox.Show(result);
            }
            catch (Exception )
            {
                MessageBox.Show($"Crew member cannot be fired due to his still remainnig voyages...");
            }
            textBoxIdFire.Text = string.Empty;
            textBoxFNFire.Text = string.Empty;
            textBoxLNFire.Text = string.Empty;
        }

        private void radioButtonHire_Click(object sender, EventArgs e)
        {
            groupHire.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void radioButtonFire_Click(object sender, EventArgs e)
        {
            groupHire.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void radioButtonUpdateRaiting_Click(object sender, EventArgs e)
        {
            groupHire.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void listBoxCrew_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string memberInfo = listBoxCrew.Text;
                currentCrewMemberIndex = int.Parse(memberInfo.Split(" ").First());
                CrewMember cm = cService.GetCrewMemberById(currentCrewMemberIndex);
                if (cm != null)
                {
                    if (radioButtonFire.Checked)
                    {
                        textBoxIdFire.Text = (cm.Id).ToString();
                        textBoxFNFire.Text = cm.FirstName;
                        textBoxLNFire.Text = cm.LastName;
                    }
                    else if (radioButtonUpdateRaiting.Checked)
                    {
                        textBoxIdUpdate.Text = (cm.Id).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                currentCrewMemberIndex = int.Parse(textBoxIdUpdate.Text);
                CrewMember cm = cService.GetCrewMemberById(currentCrewMemberIndex);
                double newRating = double.Parse(textBoxNewRating.Text);
                string result = cService.UpdateCrewMemberRatingById(currentCrewMemberIndex, newRating);
                MessageBox.Show(result);
                textBoxNewRating.Text = String.Empty;
                textBoxIdUpdate.Text = String.Empty;
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
                if (currentPage <= 1) { return; }
                listBoxCrew.Items.Clear();
                List<string> list = cService.GetCrewMemberBasicInfo(--currentPage, itemsPerPage);
                list.ForEach(p => listBoxCrew.Items.Add(p));
                labelPageNum.Text = $"{currentPage} / {totalPages}";

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
                if (currentPage >= totalPages) { return; }
                listBoxCrew.Items.Clear();
                List<string> list = cService.GetCrewMemberBasicInfo(++currentPage, itemsPerPage);
                list.ForEach(p => listBoxCrew.Items.Add(p));
                labelPageNum.Text = $"{currentPage} / {totalPages}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
