﻿namespace MedicalCenter
{
    partial class FormRptDoctorsByCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "דוח רופאים לפי עיר";
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(416, 66);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityCombo.Size = new System.Drawing.Size(198, 21);
            this.cityCombo.TabIndex = 1;
            this.cityCombo.SelectedIndexChanged += new System.EventHandler(this.ShowClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(12, 121);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1004, 302);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "ת\"ז";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "שם פרטי";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "שם משפחה";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "רישיון";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 5;
            this.columnHeader5.Text = "התמחות";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 6;
            this.columnHeader6.Text = "כתובת";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 0;
            this.columnHeader7.Text = "עיר";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "טלפון";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "נייד";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "מייל";
            this.columnHeader10.Width = 100;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(416, 447);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(88, 41);
            this.colorButton.TabIndex = 4;
            this.colorButton.Text = "בחר צבע";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(532, 447);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 41);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "נקה דוח";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // FormRptDoctorsByCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1028, 512);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.label1);
            this.Name = "FormRptDoctorsByCity";
            this.Text = "FormRptDoctorsByCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button clearButton;
    }
}