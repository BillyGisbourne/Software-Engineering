namespace Prototype
{
    partial class DeclineReply
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
            this.DeclineSaveBtn = new System.Windows.Forms.Button();
            this.DeclineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeclineSaveBtn
            // 
            this.DeclineSaveBtn.Location = new System.Drawing.Point(189, 512);
            this.DeclineSaveBtn.Name = "DeclineSaveBtn";
            this.DeclineSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.DeclineSaveBtn.TabIndex = 1;
            this.DeclineSaveBtn.Text = "Save";
            this.DeclineSaveBtn.UseVisualStyleBackColor = true;
            this.DeclineSaveBtn.Click += new System.EventHandler(this.DeclineSaveBtn_Click);
            // 
            // DeclineTextBox
            // 
            this.DeclineTextBox.Location = new System.Drawing.Point(12, 12);
            this.DeclineTextBox.Multiline = true;
            this.DeclineTextBox.Name = "DeclineTextBox";
            this.DeclineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DeclineTextBox.Size = new System.Drawing.Size(297, 494);
            this.DeclineTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Applicant Name: {NAME}\r\nApplicant Email: {EMAIL}\r\nApplicant Role: {ROLE}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeclineReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeclineTextBox);
            this.Controls.Add(this.DeclineSaveBtn);
            this.Name = "DeclineReply";
            this.Text = "DeclineReply";
            this.Load += new System.EventHandler(this.DeclineReply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeclineSaveBtn;
        private System.Windows.Forms.TextBox DeclineTextBox;
        private System.Windows.Forms.Label label1;
    }
}