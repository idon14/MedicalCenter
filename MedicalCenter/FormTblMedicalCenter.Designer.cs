﻿namespace MedicalCenter
{
    partial class FormTblMedicalCenter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMedicalCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMedicalCenter = new MedicalCenter.DataSetMedicalCenter();
            this.tblMedicalCenterTableAdapter = new MedicalCenter.DataSetMedicalCenterTableAdapters.tblMedicalCenterTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMedicalCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת מרכז רפואי";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicalNameDataGridViewTextBoxColumn,
            this.medicalAddressDataGridViewTextBoxColumn,
            this.medicalCityDataGridViewTextBoxColumn,
            this.medicalPhoneDataGridViewTextBoxColumn,
            this.medicalPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMedicalCenterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // medicalNameDataGridViewTextBoxColumn
            // 
            this.medicalNameDataGridViewTextBoxColumn.DataPropertyName = "medicalName";
            this.medicalNameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.medicalNameDataGridViewTextBoxColumn.Name = "medicalNameDataGridViewTextBoxColumn";
            // 
            // medicalAddressDataGridViewTextBoxColumn
            // 
            this.medicalAddressDataGridViewTextBoxColumn.DataPropertyName = "medicalAddress";
            this.medicalAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.medicalAddressDataGridViewTextBoxColumn.Name = "medicalAddressDataGridViewTextBoxColumn";
            // 
            // medicalCityDataGridViewTextBoxColumn
            // 
            this.medicalCityDataGridViewTextBoxColumn.DataPropertyName = "medicalCity";
            this.medicalCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.medicalCityDataGridViewTextBoxColumn.Name = "medicalCityDataGridViewTextBoxColumn";
            // 
            // medicalPhoneDataGridViewTextBoxColumn
            // 
            this.medicalPhoneDataGridViewTextBoxColumn.DataPropertyName = "medicalPhone";
            this.medicalPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.medicalPhoneDataGridViewTextBoxColumn.Name = "medicalPhoneDataGridViewTextBoxColumn";
            // 
            // medicalPictureDataGridViewTextBoxColumn
            // 
            this.medicalPictureDataGridViewTextBoxColumn.DataPropertyName = "medicalPicture";
            this.medicalPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.medicalPictureDataGridViewTextBoxColumn.Name = "medicalPictureDataGridViewTextBoxColumn";
            // 
            // tblMedicalCenterBindingSource
            // 
            this.tblMedicalCenterBindingSource.DataMember = "tblMedicalCenter";
            this.tblMedicalCenterBindingSource.DataSource = this.dataSetMedicalCenter;
            // 
            // dataSetMedicalCenter
            // 
            this.dataSetMedicalCenter.DataSetName = "DataSetMedicalCenter";
            this.dataSetMedicalCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMedicalCenterTableAdapter
            // 
            this.tblMedicalCenterTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(563, 625);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // FormTblMedicalCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblMedicalCenter";
            this.Text = "FormTblMedicalCenter";
            this.Load += new System.EventHandler(this.FormTblMedicalCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMedicalCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetMedicalCenter dataSetMedicalCenter;
        private System.Windows.Forms.BindingSource tblMedicalCenterBindingSource;
        private DataSetMedicalCenterTableAdapters.tblMedicalCenterTableAdapter tblMedicalCenterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
    }
}