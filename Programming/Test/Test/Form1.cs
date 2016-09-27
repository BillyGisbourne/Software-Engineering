using System;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class loginForm : Form
    {
        private string userDataLoc = "userData.txt";

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(userBox.Text)) && (!string.IsNullOrEmpty(passBox.Text)))
            {
                if (File.ReadAllText(userDataLoc).Contains(Environment.NewLine + userBox.Text + ":"))
                {
                    if (File.ReadAllText(userDataLoc).Contains(Environment.NewLine + userBox.Text + ":" + passBox.Text))
                    {
                        MessageBox.Show("Logged In");
                        Application.Exit();
                    }
                    else
                        MessageBox.Show("Password is incorrect, please try again");
                }
                else
                    MessageBox.Show("Username doesn't exist, try signing up.");
            }
            else
                MessageBox.Show("Please enter your login information.");
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(userBox.Text)) && (!string.IsNullOrEmpty(passBox.Text)))
            {
                if (!File.Exists(userDataLoc))
                {
                    File.Create(userDataLoc);
                }
                else
                {
                    if (File.ReadAllText(userDataLoc).Contains(Environment.NewLine + userBox.Text + ":"))
                    {
                        MessageBox.Show("Username already exists, please try another.");
                    }
                    else
                        WriteData(userBox.Text, passBox.Text);
                }
            }
        }

        private void WriteData(string username, string password)
        {
            File.AppendAllText(userDataLoc, Environment.NewLine + username + ":" + password);
        }
    }
}
