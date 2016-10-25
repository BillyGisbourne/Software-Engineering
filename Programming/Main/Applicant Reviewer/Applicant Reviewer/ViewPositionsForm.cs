using MetroFramework.Forms;
using System;

namespace Applicant_Reviewer
{
    public partial class ViewPositionsForm : MetroForm
    {
        public ViewPositionsForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var previousWindow = new PositionOptions();
            previousWindow.LoadPreviousUser();
            previousWindow.Visible = true;
            Hide();
        }

        private void ViewApplicantBtn_Click(object sender, EventArgs e)
        {
            ApplicantList.SelectedIndex = 2;
        }
    }
}
