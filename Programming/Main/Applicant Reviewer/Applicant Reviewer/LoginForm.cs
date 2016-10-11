using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Applicant_Reviewer
{
    public partial class LoginForm : Form
    {

        private string forgotPassLink = "http://www.google.com/";
        private string username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
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
    }
}
