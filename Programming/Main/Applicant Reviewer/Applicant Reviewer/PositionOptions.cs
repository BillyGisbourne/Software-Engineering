using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicant_Reviewer
{
    public partial class PositionOptions : MetroForm
    {
        public PositionOptions()
        {
            InitializeComponent();
            LoginForm newLogin = new LoginForm();
        }

        internal void FillDetails(string firstname, string lastname, int rights)
        {
            //email = email.Split('@')[0];
            //email = email.First().ToString().ToUpper() + email.Substring(1);
            showUser.Text += firstname + " " + lastname;

            switch (rights)
            {
                case 1:
                    showRole.Text += "Staff Member";
                    break;
                case 2:
                    showRole.Text += "HR Member";
                    break;
                case 3:
                    showRole.Text += "Admin";
                    break;
            }
        }

        internal void CheckVisible(int rights)
        {
            switch (rights)
            {
                case 1:
                case 2:
                    CreatePositionsBtn.Hide();
                    ViewPositionsBtn.Size = new Size(398, 117);
                    ViewPositionsBtn.Location = new Point(23, 149);
                    break;
            }
        }

        private void CreatePositionsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create");
            Application.Exit();
        }

        private void ViewPositionsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View");
            Application.Exit();
        }

        private void PositionOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var newLogout = new LogoutProcessor();

            newLogout.Logout();
        }
    }
}
