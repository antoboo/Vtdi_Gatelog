using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vtdi_Gatelog
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }



        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Button Clicked");
        }



        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogInForm();
        }



        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Button Clicked");
        }



        private void gateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate List Button Clicked");
        }



        private void gateInToolStripMenuItem_Click(object sender, EventArgs e)
        {
             bool isLoggedIn = false;

            if (isLoggedIn)
            {
                GateIn gateIn = new GateIn();
                gateIn.MdiParent = this;
                gateIn.Show();
            }
            else
            {
                ShowLogInForm();
            }

        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Reports Button Clicked");
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Logs Button Clicked");
        }

        public void ShowLogInForm()
        {

            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }
    }
}
