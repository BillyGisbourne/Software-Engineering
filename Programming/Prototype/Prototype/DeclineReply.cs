using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class DeclineReply : Form
    {
        public DeclineReply()
        {
            InitializeComponent();
        }

        private void DeclineReply_Load(object sender, EventArgs e)
        {
            DeclineTextBox.Text = ReplySelectionForm.declineReply;
        }

        private void DeclineSaveBtn_Click(object sender, EventArgs e)
        {
            ReplySelectionForm.declineReply = DeclineTextBox.Text;
            Hide();
        }
    }
}
