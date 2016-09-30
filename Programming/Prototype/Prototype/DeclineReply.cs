using System;
using System.Windows.Forms;
using System.IO;

namespace Prototype
{
    public partial class DeclineReply : Form
    {
        ReplySelectionForm replySelectionForm = new ReplySelectionForm();

        public DeclineReply()
        {
            InitializeComponent();
        }

        private void DeclineReply_Load(object sender, EventArgs e)
        {
            DeclineTextBox.Text = File.ReadAllText(replySelectionForm.declineRepliesLoc);
        }

        private void DeclineSaveBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(replySelectionForm.declineRepliesLoc, DeclineTextBox.Text);
            Hide();
        }
    }
}
