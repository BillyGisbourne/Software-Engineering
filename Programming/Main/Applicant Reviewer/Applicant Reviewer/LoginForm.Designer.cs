using System;

namespace Applicant_Reviewer
{
    partial class LoginForm
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
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.EmailBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.ForgotPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(105, 148);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailBox.CustomBackground = true;
            this.EmailBox.Location = new System.Drawing.Point(23, 65);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PromptText = "Email";
            this.EmailBox.Size = new System.Drawing.Size(239, 23);
            this.EmailBox.TabIndex = 0;
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordBox.CustomBackground = true;
            this.PasswordBox.Location = new System.Drawing.Point(23, 95);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.PromptText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(239, 23);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.CustomBackground = true;
            this.ForgotPasswordLabel.CustomForeColor = true;
            this.ForgotPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(164, 121);
            this.ForgotPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(98, 15);
            this.ForgotPasswordLabel.TabIndex = 2;
            this.ForgotPasswordLabel.Text = "Forgot Password?";
            this.ForgotPasswordLabel.UseStyleColors = true;
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 185);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox EmailBox;
        private MetroFramework.Controls.MetroTextBox PasswordBox;
        private MetroFramework.Controls.MetroLabel ForgotPasswordLabel;
    }
}

