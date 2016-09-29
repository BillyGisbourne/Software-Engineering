using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{

    public partial class ReplySelectionForm : Form
    {
        private int counter = 0;
        private string PDFLoc = "pdf.txt";
        private string reply;

        public ReplySelectionForm()
        {
            InitializeComponent();
        }

        private void ReplySelectionForm_Load(object sender, EventArgs e)
        {
            NextApplicant();
        }

        private void DatabaseGrabBtn_Click(object sender, EventArgs e)
        {
            ReplyToApplicant();
        }

        private void ReplyToApplicant()
        {
            if (AcceptRadio.Checked == true)
            {
                reply = "Dear " + label2.Text + ","
                        + Environment.NewLine
                        + Environment.NewLine +
                        "We are pleased to accept you as blah blah blah..."
                        + Environment.NewLine
                        + Environment.NewLine +
                        "Thanks,"
                        +Environment.NewLine +
                        "HappyTech";
            }
            if (DeclineRadio.Checked == true)
            {
                reply = "Dear " + label2.Text + ","
                        + Environment.NewLine
                        + Environment.NewLine +
                        "We are sad to decline you as blah blah blah..."
                        + Environment.NewLine
                        + Environment.NewLine +
                        "Sorry,"
                        + Environment.NewLine +
                        "HappyTech";
            }

            WriteToFile(PDFLoc, reply);
            NextApplicant();
        }

        private void WriteToFile(string location, string text)
        {
            string spacer = Environment.NewLine + 
                            "--------------------------------------------"
                            + Environment.NewLine;

            File.AppendAllText(location, text);
            File.AppendAllText(location, spacer);
        }

        private void NextApplicant()
        {
            counter++;
            label2.Text = "Test" + counter;
            label4.Text = "Test@hotmail.com" + counter;
            CoverLetterBox.Text = "Cover letter fill = " + label2.Text + label4.Text;
        }

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
    }
}
