using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicant_Reviewer
{
    class LogoutProcessor
    {
        internal void Logout()
        {
            DialogResult newDialog = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                var LoginForm = new LoginForm();

                PositionOptions.ActiveForm.Dispose();
                LoginForm.BringToFront();
                LoginForm.Show();
            }
        }
    }
}
