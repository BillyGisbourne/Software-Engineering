﻿using System;

namespace Applicant_Reviewer
{
    partial class PositionOptions
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
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.ViewPositionsBtn = new MetroFramework.Controls.MetroButton();
            this.CreatePositionsBtn = new MetroFramework.Controls.MetroButton();
            this.showUser = new MetroFramework.Controls.MetroLabel();
            this.showRole = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(23, 101);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ViewPositionsBtn
            // 
            this.ViewPositionsBtn.Location = new System.Drawing.Point(225, 149);
            this.ViewPositionsBtn.Name = "ViewPositionsBtn";
            this.ViewPositionsBtn.Size = new System.Drawing.Size(196, 117);
            this.ViewPositionsBtn.TabIndex = 6;
            this.ViewPositionsBtn.Text = "View Positions";
            this.ViewPositionsBtn.Click += new System.EventHandler(this.ViewPositionsBtn_Click);
            // 
            // CreatePositionsBtn
            // 
            this.CreatePositionsBtn.Location = new System.Drawing.Point(23, 149);
            this.CreatePositionsBtn.Name = "CreatePositionsBtn";
            this.CreatePositionsBtn.Size = new System.Drawing.Size(196, 117);
            this.CreatePositionsBtn.TabIndex = 7;
            this.CreatePositionsBtn.Text = "Create Positions";
            this.CreatePositionsBtn.Click += new System.EventHandler(this.CreatePositionsBtn_Click);
            // 
            // showUser
            // 
            this.showUser.AutoSize = true;
            this.showUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.showUser.Location = new System.Drawing.Point(23, 31);
            this.showUser.Name = "showUser";
            this.showUser.Size = new System.Drawing.Size(118, 25);
            this.showUser.TabIndex = 8;
            this.showUser.Text = "Logged in as: ";
            // 
            // showRole
            // 
            this.showRole.AutoSize = true;
            this.showRole.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.showRole.Location = new System.Drawing.Point(23, 56);
            this.showRole.Name = "showRole";
            this.showRole.Size = new System.Drawing.Size(54, 25);
            this.showRole.TabIndex = 9;
            this.showRole.Text = "Role: ";
            // 
            // PositionOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.showRole);
            this.Controls.Add(this.showUser);
            this.Controls.Add(this.CreatePositionsBtn);
            this.Controls.Add(this.ViewPositionsBtn);
            this.Controls.Add(this.LogoutBtn);
            this.MaximizeBox = false;
            this.Name = "PositionOptions";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionOptions_FormClosing);
            this.Load += new System.EventHandler(this.PositionOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private MetroFramework.Controls.MetroButton ViewPositionsBtn;
        private MetroFramework.Controls.MetroButton CreatePositionsBtn;
        private MetroFramework.Controls.MetroLabel showUser;
        private MetroFramework.Controls.MetroLabel showRole;
    }
}