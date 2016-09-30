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
            // 
            // AcceptReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 547);
            this.Controls.Add(this.AcceptSaveBtn);
            this.Name = "AcceptReply";
            this.Text = "AcceptReply";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptSaveBtn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}