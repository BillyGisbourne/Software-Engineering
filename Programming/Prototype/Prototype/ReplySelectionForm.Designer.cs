namespace Prototype
{
    partial class ReplySelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplySelectionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseGrabBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AcceptRadio = new System.Windows.Forms.RadioButton();
            this.DeclineRadio = new System.Windows.Forms.RadioButton();
            this.ShowCLBtn = new System.Windows.Forms.Button();
            this.HideCLBtn = new System.Windows.Forms.Button();
            this.CoverLetterBox = new System.Windows.Forms.TextBox();
            this.SkipBtn = new System.Windows.Forms.Button();
            this.AcceptReplyBtn = new System.Windows.Forms.Button();
            this.DeclineReplyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DatabaseGrabBtn
            // 
            resources.ApplyResources(this.DatabaseGrabBtn, "DatabaseGrabBtn");
            this.DatabaseGrabBtn.Name = "DatabaseGrabBtn";
            this.DatabaseGrabBtn.UseVisualStyleBackColor = true;
            this.DatabaseGrabBtn.Click += new System.EventHandler(this.DatabaseGrabBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // AcceptRadio
            // 
            resources.ApplyResources(this.AcceptRadio, "AcceptRadio");
            this.AcceptRadio.Name = "AcceptRadio";
            this.AcceptRadio.UseVisualStyleBackColor = true;
            // 
            // DeclineRadio
            // 
            resources.ApplyResources(this.DeclineRadio, "DeclineRadio");
            this.DeclineRadio.Name = "DeclineRadio";
            this.DeclineRadio.UseVisualStyleBackColor = true;
            // 
            // ShowCLBtn
            // 
            resources.ApplyResources(this.ShowCLBtn, "ShowCLBtn");
            this.ShowCLBtn.Name = "ShowCLBtn";
            this.ShowCLBtn.UseVisualStyleBackColor = true;
            this.ShowCLBtn.Click += new System.EventHandler(this.ShowCLBtn_Click);
            // 
            // HideCLBtn
            // 
            resources.ApplyResources(this.HideCLBtn, "HideCLBtn");
            this.HideCLBtn.Name = "HideCLBtn";
            this.HideCLBtn.UseVisualStyleBackColor = true;
            this.HideCLBtn.Click += new System.EventHandler(this.HideCLBtn_Click);
            // 
            // CoverLetterBox
            // 
            resources.ApplyResources(this.CoverLetterBox, "CoverLetterBox");
            this.CoverLetterBox.Name = "CoverLetterBox";
            this.CoverLetterBox.ReadOnly = true;
            // 
            // SkipBtn
            // 
            resources.ApplyResources(this.SkipBtn, "SkipBtn");
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.UseVisualStyleBackColor = true;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // AcceptReplyBtn
            // 
            resources.ApplyResources(this.AcceptReplyBtn, "AcceptReplyBtn");
            this.AcceptReplyBtn.Name = "AcceptReplyBtn";
            this.AcceptReplyBtn.UseVisualStyleBackColor = true;
            this.AcceptReplyBtn.Click += new System.EventHandler(this.AcceptReplyBtn_Click);
            // 
            // DeclineReplyBtn
            // 
            resources.ApplyResources(this.DeclineReplyBtn, "DeclineReplyBtn");
            this.DeclineReplyBtn.Name = "DeclineReplyBtn";
            this.DeclineReplyBtn.UseVisualStyleBackColor = true;
            this.DeclineReplyBtn.Click += new System.EventHandler(this.DeclineReplyBtn_Click);
            // 
            // ReplySelectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeclineReplyBtn);
            this.Controls.Add(this.AcceptReplyBtn);
            this.Controls.Add(this.SkipBtn);
            this.Controls.Add(this.DeclineRadio);
            this.Controls.Add(this.AcceptRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabaseGrabBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoverLetterBox);
            this.Controls.Add(this.ShowCLBtn);
            this.Controls.Add(this.HideCLBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReplySelectionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.ReplySelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DatabaseGrabBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton AcceptRadio;
        private System.Windows.Forms.RadioButton DeclineRadio;
        private System.Windows.Forms.Button ShowCLBtn;
        private System.Windows.Forms.Button HideCLBtn;
        private System.Windows.Forms.TextBox CoverLetterBox;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.Button AcceptReplyBtn;
        private System.Windows.Forms.Button DeclineReplyBtn;
        private System.Windows.Forms.Label label2;
    }
}

