﻿namespace PresentationTier
{
    partial class RecruitmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecruitmentForm));
            this.recruitmentRequestDataGrid = new System.Windows.Forms.DataGridView();
            this.createRecruitmentRequestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentRequestDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recruitmentRequestDataGrid
            // 
            this.recruitmentRequestDataGrid.AllowUserToAddRows = false;
            this.recruitmentRequestDataGrid.AllowUserToDeleteRows = false;
            this.recruitmentRequestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recruitmentRequestDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recruitmentRequestDataGrid.Location = new System.Drawing.Point(0, 0);
            this.recruitmentRequestDataGrid.Name = "recruitmentRequestDataGrid";
            this.recruitmentRequestDataGrid.ReadOnly = true;
            this.recruitmentRequestDataGrid.RowHeadersWidth = 51;
            this.recruitmentRequestDataGrid.RowTemplate.Height = 24;
            this.recruitmentRequestDataGrid.Size = new System.Drawing.Size(1080, 450);
            this.recruitmentRequestDataGrid.TabIndex = 0;
            this.recruitmentRequestDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RecruitmentRequestDataGrid_CellFormatting);
            this.recruitmentRequestDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RecruitmentRequestDataGrid_CellMouseClick);
            // 
            // createRecruitmentRequestButton
            // 
            this.createRecruitmentRequestButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createRecruitmentRequestButton.Location = new System.Drawing.Point(0, 412);
            this.createRecruitmentRequestButton.Name = "createRecruitmentRequestButton";
            this.createRecruitmentRequestButton.Size = new System.Drawing.Size(1080, 38);
            this.createRecruitmentRequestButton.TabIndex = 1;
            this.createRecruitmentRequestButton.Text = "Create Recruitment Request";
            this.createRecruitmentRequestButton.UseVisualStyleBackColor = true;
            this.createRecruitmentRequestButton.Click += new System.EventHandler(this.CreateRecruitmentRequestButton_Click);
            // 
            // RecruitmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.createRecruitmentRequestButton);
            this.Controls.Add(this.recruitmentRequestDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecruitmentForm";
            this.Text = "Recruitments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageRecruitmentRequest_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentRequestDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recruitmentRequestDataGrid;
        private System.Windows.Forms.Button createRecruitmentRequestButton;
    }
}