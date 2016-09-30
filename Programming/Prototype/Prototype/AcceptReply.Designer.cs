namespace Prototype
{
    partial class AcceptReply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AcceptSaveBtn = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AcceptSaveBtn
            // 
            this.AcceptSaveBtn.Location = new System.Drawing.Point(189, 512);
            this.AcceptSaveBtn.Name = "AcceptSaveBtn";
            this.AcceptSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptSaveBtn.TabIndex = 0;
            this.AcceptSaveBtn.Text = "Save";
            this.AcceptSaveBtn.UseVisualStyleBackColor = true;
            this.AcceptSaveBtn.Click += new System.EventHandler(this.AcceptSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codes:\r\n\r\nApplicant Name: {NAME}\r\nApplicant Email: {EMAIL}\r\nApplicant Role: {ROLE" +
    "}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AcceptTextBox
            // 
            this.AcceptTextBox.Location = new System.Drawing.Point(12, 12);
            this.AcceptTextBox.Multiline = true;
            this.AcceptTextBox.Name = "AcceptTextBox";
            this.AcceptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AcceptTextBox.Size = new System.Drawing.Size(297, 494);
            this.AcceptTextBox.TabIndex = 4;
            // 
            // AcceptReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptTextBox);
            this.Controls.Add(this.AcceptSaveBtn);
            this.Name = "AcceptReply";
            this.Text = "AcceptReply";
            this.Load += new System.EventHandler(this.AcceptReply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptSaveBtn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AcceptTextBox;
    }
}