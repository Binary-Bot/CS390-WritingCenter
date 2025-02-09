﻿namespace WritingCenterForms
{
    partial class AcctManagePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadCsvButton = new System.Windows.Forms.Button();
            this.manualEntryButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.DBExportButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AcctDisplayListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadCsvButton
            // 
            this.uploadCsvButton.Location = new System.Drawing.Point(207, 45);
            this.uploadCsvButton.Name = "uploadCsvButton";
            this.uploadCsvButton.Size = new System.Drawing.Size(83, 23);
            this.uploadCsvButton.TabIndex = 0;
            this.uploadCsvButton.Text = "Upload CSV";
            this.uploadCsvButton.UseVisualStyleBackColor = true;
            this.uploadCsvButton.Click += new System.EventHandler(this.uploadCSV_Click);
            // 
            // manualEntryButton
            // 
            this.manualEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manualEntryButton.Location = new System.Drawing.Point(562, 45);
            this.manualEntryButton.Name = "manualEntryButton";
            this.manualEntryButton.Size = new System.Drawing.Size(82, 23);
            this.manualEntryButton.TabIndex = 2;
            this.manualEntryButton.Text = "Select";
            this.manualEntryButton.UseVisualStyleBackColor = true;
            this.manualEntryButton.Click += new System.EventHandler(this.manualEntry_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "AcctCSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteAccountButton);
            this.panel1.Controls.Add(this.AddAccountButton);
            this.panel1.Controls.Add(this.DBExportButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uploadCsvButton);
            this.panel1.Controls.Add(this.manualEntryButton);
            this.panel1.Location = new System.Drawing.Point(153, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 81);
            this.panel1.TabIndex = 4;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(382, 17);
            this.DeleteAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(86, 22);
            this.DeleteAccountButton.TabIndex = 7;
            this.DeleteAccountButton.Text = "Delete Account\r\n";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(382, 45);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(87, 23);
            this.AddAccountButton.TabIndex = 6;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // DBExportButton
            // 
            this.DBExportButton.Location = new System.Drawing.Point(207, 17);
            this.DBExportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DBExportButton.Name = "DBExportButton";
            this.DBExportButton.Size = new System.Drawing.Size(83, 23);
            this.DBExportButton.TabIndex = 5;
            this.DBExportButton.Text = "Export to CSV";
            this.DBExportButton.UseVisualStyleBackColor = true;
            this.DBExportButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(36, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clearDBClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(560, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refreshDatabase_click);
            // 
            // AcctDisplayListBox
            // 
            this.AcctDisplayListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AcctDisplayListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctDisplayListBox.FormattingEnabled = true;
            this.AcctDisplayListBox.HorizontalScrollbar = true;
            this.AcctDisplayListBox.ItemHeight = 20;
            this.AcctDisplayListBox.Location = new System.Drawing.Point(153, 147);
            this.AcctDisplayListBox.Name = "AcctDisplayListBox";
            this.AcctDisplayListBox.Size = new System.Drawing.Size(701, 430);
            this.AcctDisplayListBox.TabIndex = 5;
            this.AcctDisplayListBox.Enter += new System.EventHandler(this.refreshDatabase_click);
            // 
            // AcctManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AcctDisplayListBox);
            this.Controls.Add(this.panel1);
            this.Name = "AcctManagePage";
            this.Size = new System.Drawing.Size(880, 640);
            this.Load += new System.EventHandler(this.refreshDatabase_click);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadCsvButton;
        private System.Windows.Forms.Button manualEntryButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox AcctDisplayListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DBExportButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button DeleteAccountButton;
    }
}
