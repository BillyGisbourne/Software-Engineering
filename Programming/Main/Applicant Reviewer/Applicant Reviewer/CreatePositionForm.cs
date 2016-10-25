using System; 
using MetroFramework.Forms;

namespace Applicant_Reviewer
{
    public partial class CreatePositionForm : MetroForm
    {
        public CreatePositionForm()
        {
            InitializeComponent();
            InitializePlaceholders();
            PosTitleBox.Focus();
        }
        
        private void InitializePlaceholders()
        {
            PosTitleBox.Text = ".";
            PosSalaryBox.Text = ".";
            PosStartBox.Text = ".";
            PosTitleBox.Text = "";
            PosSalaryBox.Text = "";
            PosStartBox.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var previousWindow = new PositionOptions();
            previousWindow.LoadPreviousUser();
            previousWindow.Visible = true;
            Hide();
        }
    }
}
