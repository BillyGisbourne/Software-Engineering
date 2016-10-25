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
using System.IO;

namespace Applicant_Reviewer
{
    public partial class PositionOptions : MetroForm
    {
        private string tempFile = Environment.SpecialFolder.MyComputer.ToString() + @"/temp.txt";

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

            SavePreviousUser();
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
            CreatePositionForm newCreate = new CreatePositionForm();
            newCreate.Show();
            Visible = false;
        }

        private void ViewPositionsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View");
            ViewPositionsForm newView = new ViewPositionsForm();
            newView.Show();
            Visible = false;
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

        private void PositionOptions_Load(object sender, EventArgs e)
        {
        }

        internal void SavePreviousUser()
        {

            File.WriteAllText(tempFile,showUser.Text + Environment.NewLine + showRole.Text);
        }

        internal void LoadPreviousUser()
        {
            string[] userData = File.ReadAllLines(tempFile);
            showUser.Text = userData[0];
            showRole.Text = userData[1];
        }
    }
}
