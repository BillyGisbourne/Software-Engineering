using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Runtime.InteropServices;

namespace Applicant_Reviewer
{
    public partial class LoginForm : MetroForm
    {
        private string forgotPassLink = "http://www.google.com/";

        public LoginForm()
        {
            InitializeComponent();
            RandomStyle();
            InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            EmailBox.Text = ".";
            PasswordBox.Text = ".";
            EmailBox.Text = "";
            PasswordBox.Text = "";
        }

        /// <summary>
        /// Sends user to reset password link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            Process.Start(forgotPassLink); // debugging
        }

        /// <summary>
        /// Button click handler, if clicked, checks against LoginProcessor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginProcessor newLoginAttempt = new LoginProcessor();
            newLoginAttempt.Login(EmailBox.Text, PasswordBox.Text);
        }

        /// <summary>
        /// If this form is closed, exits entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
                
        private void RandomStyle()
        {
            int randomNumber;

            Random rnd = new Random();

            randomNumber = rnd.Next(1, 14);

            switch (randomNumber)
            {
                case 1:
                    Style = MetroFramework.MetroColorStyle.Black;
                    break;
                case 2:
                    Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case 3:
                    Style = MetroFramework.MetroColorStyle.Brown;
                    break;
                case 4:
                    Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case 5:
                    Style = MetroFramework.MetroColorStyle.Lime;
                    break;
                case 6:
                    Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 7:
                    Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 8:
                    Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 9:
                    Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 10:
                    Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 11:
                    Style = MetroFramework.MetroColorStyle.Silver;
                    break;
                case 12:
                    Style = MetroFramework.MetroColorStyle.Teal;
                    break;
                case 13:
                    Style = MetroFramework.MetroColorStyle.White;
                    break;
                case 14:
                    Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
            }
        }
    }
}
