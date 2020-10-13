﻿using System;

namespace PresentationTier
{
    partial class Main
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
            this.loggedinUserLabel = new System.Windows.Forms.Label();
            this.eventRequestButton = new System.Windows.Forms.Button();
            this.createClientButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.assignmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedinUserLabel
            // 
            this.loggedinUserLabel.AutoSize = true;
            this.loggedinUserLabel.Location = new System.Drawing.Point(608, 9);
            this.loggedinUserLabel.Name = "loggedinUserLabel";
            this.loggedinUserLabel.Size = new System.Drawing.Size(0, 17);
            this.loggedinUserLabel.TabIndex = 0;
            // 
            // eventRequestButton
            // 
            this.eventRequestButton.Location = new System.Drawing.Point(16, 16);
            this.eventRequestButton.Name = "eventRequestButton";
            this.eventRequestButton.Size = new System.Drawing.Size(200, 23);
            this.eventRequestButton.TabIndex = 6;
            this.eventRequestButton.Text = "event requests";
            this.eventRequestButton.UseVisualStyleBackColor = true;
            this.eventRequestButton.Click += new System.EventHandler(this.EventRequestButton_Click);
            // 
            // createClientButton
            // 
            this.createClientButton.Location = new System.Drawing.Point(16, 50);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(200, 23);
            this.createClientButton.TabIndex = 6;
            this.createClientButton.Text = "Create client";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.CreateClientButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(16, 84);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(200, 23);
            this.staffButton.TabIndex = 6;
            this.staffButton.Text = "Review staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.Location = new System.Drawing.Point(16, 118);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(200, 23);
            this.eventButton.TabIndex = 6;
            this.eventButton.Text = "Event";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.EventButton_Click);
            // 
            // assignmentButton
            // 
            this.assignmentButton.Location = new System.Drawing.Point(16, 147);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(200, 23);
            this.assignmentButton.TabIndex = 7;
            this.assignmentButton.Text = "Assignment";
            this.assignmentButton.UseVisualStyleBackColor = true;
            this.assignmentButton.Click += new System.EventHandler(this.AssignmentButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignmentButton);
            this.Controls.Add(this.loggedinUserLabel);
            this.Controls.Add(this.eventRequestButton);
            this.Controls.Add(this.createClientButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.eventButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label loggedinUserLabel;
        private System.Windows.Forms.Button eventRequestButton;
        private System.Windows.Forms.Button createClientButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button assignmentButton;
    }
}