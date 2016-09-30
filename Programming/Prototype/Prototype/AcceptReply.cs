using System;
using System.Windows.Forms;
using System.IO;

namespace Prototype
{
    public partial class AcceptReply : Form
    {
        ReplySelectionForm replySelectionForm = new ReplySelectionForm();

        public AcceptReply()
        {
            InitializeComponent();
        }

        private void AcceptReply_Load(object sender, EventArgs e)
        {
            AcceptTextBox.Text = File.ReadAllText(replySelectionForm.acceptRepliesLoc);
        }

        private void AcceptSaveBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(replySelectionForm.acceptRepliesLoc, AcceptTextBox.Text);
            Hide();
        }
    }
}
