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
    }
}
