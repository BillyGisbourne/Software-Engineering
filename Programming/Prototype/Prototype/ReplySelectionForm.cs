using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Prototype
{

    public partial class ReplySelectionForm : Form
    {
        /// <summary>
        /// Only used in Prototype
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// PDF Location
        /// </summary>
        private string pdfLoc = "pdf.txt";

        private string jobRole = "Administrator";

        /// <summary>
        /// Location of where replies are stored //TODO: Change to database
        /// </summary>
        public string acceptRepliesLoc = "acceptReplies.txt";
        public string declineRepliesLoc = "declineReplies.txt";

        /// <summary>
        /// Get designated for acceptReplies
        /// </summary>
        public string GetAcceptReply()
        {
            string reply = File.ReadAllText(acceptRepliesLoc);

            reply = ProcessReply(reply);

            return reply;
        }

        /// <summary>
        /// Get designated for declineReplies
        /// </summary>
        public string GetDeclineReply()
        {
            string reply = File.ReadAllText(declineRepliesLoc);

            reply = ProcessReply(reply);

            return reply;
        }

        /// <summary>
        /// Changed all the Reply code to fit all the Applicant information
        /// </summary>
        /// <param name="reply">Input the reply (unformatted)</param>
        /// <returns>Returns the reply (formatted)</returns>
        private string ProcessReply(string reply)
        {
            if (reply.Contains("{NAME}") || reply.Contains("{name}"))
            {
                reply = reply.Replace("{NAME}", label2.Text);
                reply = reply.Replace("{name}", label2.Text);
            }
            if (reply.Contains("{EMAIL}") || reply.Contains("{email}"))
            {
                reply = reply.Replace("{EMAIL}", label4.Text);
                reply = reply.Replace("{email}", label4.Text);
            }
            if (reply.Contains("{ROLE}") || reply.Contains("{role}"))
            {
                reply = reply.Replace("{ROLE}", jobRole);
                reply = reply.Replace("{role}", jobRole);
            }

            return reply;
        }

        public ReplySelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load, Loads the first applicant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplySelectionForm_Load(object sender, EventArgs e)
        {
            NextApplicant();
        }

        private void DatabaseGrabBtn_Click(object sender, EventArgs e)
        {
            if ((AcceptRadio.Checked == false) && (DeclineRadio.Checked == false))
                MessageBox.Show("Please either accept or decline the applicant using the radio buttons.");
            else
                ReplyToApplicant();
        }

        /// <summary>
        /// Built in replies
        /// TODO: Add in Custom replies
        /// </summary>
        private void ReplyToApplicant()
        {
            WriteToFile(pdfLoc, GetReplyString());
            NextApplicant();
            AcceptRadio.Checked = false;
            DeclineRadio.Checked = false;
        }

        /// <summary>
        /// Gets the desired reply string using checks
        /// </summary>
        /// <returns>Either Accept Reply or Decline Reply</returns>
        public string GetReplyString()
        {
            string reply = "";

            if (AcceptRadio.Checked == true)
            {
                reply = GetAcceptReply();
            }

            if (DeclineRadio.Checked == true)
            {
                reply = GetDeclineReply();
            }

            return reply;
        }

        /// <summary>
        /// Writes specified text to a file and appends it
        /// </summary>
        /// <param name="location">Location of File to write to</param>
        /// <param name="text">Text to write</param>
        private void WriteToFile(string location, string text)
        {
            string spacer = Environment.NewLine + 
                            "--------------------------------------------"
                            + Environment.NewLine;

            File.AppendAllText(location, text);
            File.AppendAllText(location, spacer);
        }

        /// <summary>
        /// Generates the next applicant from a Database
        /// </summary>
        private void NextApplicant()
        {
            counter++;
            label2.Text = "Test" + counter; //TODO: Change to database 'First_Name' + 'Last_Name'
            label4.Text = "Test@hotmail.com" + counter; //TODO: Change to database 'Email'
            CoverLetterBox.Text = "Cover letter fill = " + label2.Text + label4.Text; //TODO: Change to database 'Cover_Letter'
            SearchNextApplicant();
        }

        /// <summary>
        /// Searches for next repliable applicant
        /// </summary>
        private void SearchNextApplicant()
        {
            if (File.ReadAllText(pdfLoc).Contains(label2.Text)) //Reads all the text from the PDF and searches for a name match
            {
                NextApplicant(); //Loops back to the Next Applicant
            }
        }

        /// <summary>
        /// Method to change the layout of the main form; showing the covering letter
        /// </summary>
        private void ShowCoveringLetter()
        {
            AcceptRadio.Location = new Point(170, 580);
            DeclineRadio.Location = new Point(285, 580);
            DatabaseGrabBtn.Location = new Point(170, 603);
            ReplySelectionForm.ActiveForm.Size = new Size(502, 678);

            CoverLetterBox.Show();
            ShowCLBtn.Hide();
            HideCLBtn.Show();
        }

        /// <summary>
        /// Method to change the layout of the main form; hiding the covering letter
        /// </summary>
        private void HideCoveringLetter()
        {
            AcceptRadio.Location = new Point(170, 115);
            DeclineRadio.Location = new Point(285, 115);
            DatabaseGrabBtn.Location = new Point(170, 138);
            ReplySelectionForm.ActiveForm.Size = new Size(502, 218);

            CoverLetterBox.Hide();
            ShowCLBtn.Show();
            HideCLBtn.Hide();
        }

        private void ShowCLBtn_Click(object sender, EventArgs e)
        {
            ShowCoveringLetter();
        }

        private void HideCLBtn_Click(object sender, EventArgs e)
        {
            HideCoveringLetter();
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            NextApplicant();
        }

        private void DeclineReplyBtn_Click(object sender, EventArgs e)
        {
            DeclineReply DeclineSettings = new DeclineReply();

            DeclineSettings.Show();
        }

        private void AcceptReplyBtn_Click(object sender, EventArgs e)
        {
            AcceptReply AcceptSettings = new AcceptReply();
            AcceptSettings.Show();
        }
    }
}
