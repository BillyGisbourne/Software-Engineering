using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicant_Reviewer
{
    public partial class BackgroundForm : MetroForm
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Show();
            Visible = false;
        }

        private void BackgroundForm_VisibleChanged(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
