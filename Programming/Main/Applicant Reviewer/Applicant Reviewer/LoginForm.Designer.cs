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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(193, 36);
            this.UsernameBox.MaxLength = 40;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(173, 20);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(193, 63);
            this.PasswordBox.MaxLength = 20;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(242, 112);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(274, 86);
            this.ForgotPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(92, 13);
            this.ForgotPasswordLabel.TabIndex = 5;
            this.ForgotPasswordLabel.Text = "Forgot Password?";
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 167);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ForgotPasswordLabel;
    }
}

