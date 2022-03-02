﻿namespace WritingCenterForms
{
    partial class Settings
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
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SundayTab = new System.Windows.Forms.TabPage();
            this.MondayTab = new System.Windows.Forms.TabPage();
            this.TuedayTab = new System.Windows.Forms.TabPage();
            this.shiftControls3 = new WritingCenterForms.ShiftControls();
            this.WednesdayTab = new System.Windows.Forms.TabPage();
            this.shiftControls4 = new WritingCenterForms.ShiftControls();
            this.ThursdayTab = new System.Windows.Forms.TabPage();
            this.shiftControls5 = new WritingCenterForms.ShiftControls();
            this.FridayTab = new System.Windows.Forms.TabPage();
            this.shiftControls6 = new WritingCenterForms.ShiftControls();
            this.SaturdayTab = new System.Windows.Forms.TabPage();
            this.shiftControls7 = new WritingCenterForms.ShiftControls();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.shiftControls2 = new WritingCenterForms.ShiftControls();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MondayTab.SuspendLayout();
            this.TuedayTab.SuspendLayout();
            this.WednesdayTab.SuspendLayout();
            this.ThursdayTab.SuspendLayout();
            this.FridayTab.SuspendLayout();
            this.SaturdayTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(998, 33);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(120, 50);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(35, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 689);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SundayTab);
            this.tabControl1.Controls.Add(this.MondayTab);
            this.tabControl1.Controls.Add(this.TuedayTab);
            this.tabControl1.Controls.Add(this.WednesdayTab);
            this.tabControl1.Controls.Add(this.ThursdayTab);
            this.tabControl1.Controls.Add(this.FridayTab);
            this.tabControl1.Controls.Add(this.SaturdayTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 459);
            this.tabControl1.TabIndex = 17;
            // 
            // SundayTab
            // 
            this.SundayTab.Location = new System.Drawing.Point(4, 25);
            this.SundayTab.Name = "SundayTab";
            this.SundayTab.Size = new System.Drawing.Size(1072, 396);
            this.SundayTab.TabIndex = 0;
            this.SundayTab.Text = "Sunday";
            this.SundayTab.UseVisualStyleBackColor = true;
            // 
            // MondayTab
            // 
            this.MondayTab.Controls.Add(this.shiftControls2);
            this.MondayTab.Location = new System.Drawing.Point(4, 25);
            this.MondayTab.Name = "MondayTab";
            this.MondayTab.Size = new System.Drawing.Size(1072, 430);
            this.MondayTab.TabIndex = 1;
            this.MondayTab.Text = "Monday";
            this.MondayTab.UseVisualStyleBackColor = true;
            // 
            // TuedayTab
            // 
            this.TuedayTab.Controls.Add(this.shiftControls3);
            this.TuedayTab.Location = new System.Drawing.Point(4, 25);
            this.TuedayTab.Name = "TuedayTab";
            this.TuedayTab.Size = new System.Drawing.Size(1072, 425);
            this.TuedayTab.TabIndex = 2;
            this.TuedayTab.Text = "Tuesday";
            this.TuedayTab.UseVisualStyleBackColor = true;
            // 
            // shiftControls3
            // 
            this.shiftControls3.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls3.Location = new System.Drawing.Point(3, 3);
            this.shiftControls3.Name = "shiftControls3";
            this.shiftControls3.Size = new System.Drawing.Size(1066, 390);
            this.shiftControls3.TabIndex = 1;
            // 
            // WednesdayTab
            // 
            this.WednesdayTab.Controls.Add(this.shiftControls4);
            this.WednesdayTab.Location = new System.Drawing.Point(4, 25);
            this.WednesdayTab.Name = "WednesdayTab";
            this.WednesdayTab.Size = new System.Drawing.Size(1072, 425);
            this.WednesdayTab.TabIndex = 3;
            this.WednesdayTab.Text = "Wednesday";
            this.WednesdayTab.UseVisualStyleBackColor = true;
            // 
            // shiftControls4
            // 
            this.shiftControls4.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls4.Location = new System.Drawing.Point(3, 3);
            this.shiftControls4.Name = "shiftControls4";
            this.shiftControls4.Size = new System.Drawing.Size(1066, 390);
            this.shiftControls4.TabIndex = 1;
            // 
            // ThursdayTab
            // 
            this.ThursdayTab.Controls.Add(this.shiftControls5);
            this.ThursdayTab.Location = new System.Drawing.Point(4, 25);
            this.ThursdayTab.Name = "ThursdayTab";
            this.ThursdayTab.Size = new System.Drawing.Size(1072, 425);
            this.ThursdayTab.TabIndex = 4;
            this.ThursdayTab.Text = "Thursday";
            this.ThursdayTab.UseVisualStyleBackColor = true;
            // 
            // shiftControls5
            // 
            this.shiftControls5.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls5.Location = new System.Drawing.Point(3, 3);
            this.shiftControls5.Name = "shiftControls5";
            this.shiftControls5.Size = new System.Drawing.Size(1066, 390);
            this.shiftControls5.TabIndex = 1;
            // 
            // FridayTab
            // 
            this.FridayTab.Controls.Add(this.shiftControls6);
            this.FridayTab.Location = new System.Drawing.Point(4, 25);
            this.FridayTab.Name = "FridayTab";
            this.FridayTab.Size = new System.Drawing.Size(1072, 425);
            this.FridayTab.TabIndex = 5;
            this.FridayTab.Text = "Friday";
            this.FridayTab.UseVisualStyleBackColor = true;
            // 
            // shiftControls6
            // 
            this.shiftControls6.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls6.Location = new System.Drawing.Point(3, 3);
            this.shiftControls6.Name = "shiftControls6";
            this.shiftControls6.Size = new System.Drawing.Size(1066, 390);
            this.shiftControls6.TabIndex = 1;
            // 
            // SaturdayTab
            // 
            this.SaturdayTab.Controls.Add(this.shiftControls7);
            this.SaturdayTab.Location = new System.Drawing.Point(4, 25);
            this.SaturdayTab.Name = "SaturdayTab";
            this.SaturdayTab.Size = new System.Drawing.Size(1072, 425);
            this.SaturdayTab.TabIndex = 6;
            this.SaturdayTab.Text = "Saturday";
            this.SaturdayTab.UseVisualStyleBackColor = true;
            // 
            // shiftControls7
            // 
            this.shiftControls7.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls7.Location = new System.Drawing.Point(3, 3);
            this.shiftControls7.Name = "shiftControls7";
            this.shiftControls7.Size = new System.Drawing.Size(1066, 390);
            this.shiftControls7.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "Order by Preference";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 207);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 20);
            this.label22.TabIndex = 15;
            this.label22.Text = "Shift Controls";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(227, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 104);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Availability",
            "Experience",
            "Major & Minors",
            "Year"});
            this.listBox1.Location = new System.Drawing.Point(25, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 104);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // shiftControls2
            // 
            this.shiftControls2.BackColor = System.Drawing.Color.Wheat;
            this.shiftControls2.Location = new System.Drawing.Point(3, 3);
            this.shiftControls2.Name = "shiftControls2";
            this.shiftControls2.Size = new System.Drawing.Size(1066, 424);
            this.shiftControls2.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOut);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1160, 854);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MondayTab.ResumeLayout(false);
            this.TuedayTab.ResumeLayout(false);
            this.WednesdayTab.ResumeLayout(false);
            this.ThursdayTab.ResumeLayout(false);
            this.FridayTab.ResumeLayout(false);
            this.SaturdayTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SundayTab;
        private System.Windows.Forms.TabPage MondayTab;
        private System.Windows.Forms.TabPage TuedayTab;
        private System.Windows.Forms.TabPage WednesdayTab;
        private System.Windows.Forms.TabPage ThursdayTab;
        private System.Windows.Forms.TabPage FridayTab;
        private System.Windows.Forms.TabPage SaturdayTab;
        private ShiftControls shiftControls3;
        private ShiftControls shiftControls4;
        private ShiftControls shiftControls5;
        private ShiftControls shiftControls6;
        private ShiftControls shiftControls7;
        private ShiftControls shiftControls2;
    }
}
