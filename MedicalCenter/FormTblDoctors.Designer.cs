namespace MedicalCenter
{
    partial class FormTblDoctors
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
            this.doctorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorProfessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDoctors = new MedicalCenter.DataSetDoctors();
            this.tblDoctorsTableAdapter = new MedicalCenter.DataSetDoctorsTableAdapters.tblDoctorsTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת רופאים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorNumDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.doctorDegreeDataGridViewTextBoxColumn,
            this.doctorProfessionDataGridViewTextBoxColumn,
            this.doctorLicenseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoctorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // doctorNumDataGridViewTextBoxColumn
            // 
            this.doctorNumDataGridViewTextBoxColumn.DataPropertyName = "doctorNum";
            this.doctorNumDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.doctorNumDataGridViewTextBoxColumn.Name = "doctorNumDataGridViewTextBoxColumn";
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "doctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            // 
            // doctorDegreeDataGridViewTextBoxColumn
            // 
            this.doctorDegreeDataGridViewTextBoxColumn.DataPropertyName = "doctorDegree";
            this.doctorDegreeDataGridViewTextBoxColumn.HeaderText = "תואר";
            this.doctorDegreeDataGridViewTextBoxColumn.Name = "doctorDegreeDataGridViewTextBoxColumn";
            // 
            // doctorProfessionDataGridViewTextBoxColumn
            // 
            this.doctorProfessionDataGridViewTextBoxColumn.DataPropertyName = "doctorProfession";
            this.doctorProfessionDataGridViewTextBoxColumn.HeaderText = "התמחות";
            this.doctorProfessionDataGridViewTextBoxColumn.Name = "doctorProfessionDataGridViewTextBoxColumn";
            // 
            // doctorLicenseDataGridViewTextBoxColumn
            // 
            this.doctorLicenseDataGridViewTextBoxColumn.DataPropertyName = "doctorLicense";
            this.doctorLicenseDataGridViewTextBoxColumn.HeaderText = "מספר רישיון";
            this.doctorLicenseDataGridViewTextBoxColumn.Name = "doctorLicenseDataGridViewTextBoxColumn";
            // 
            // tblDoctorsBindingSource
            // 
            this.tblDoctorsBindingSource.DataMember = "tblDoctors";
            this.tblDoctorsBindingSource.DataSource = this.dataSetDoctors;
            // 
            // dataSetDoctors
            // 
            this.dataSetDoctors.DataSetName = "DataSetDoctors";
            this.dataSetDoctors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoctorsTableAdapter
            // 
            this.tblDoctorsTableAdapter.ClearBeforeFill = true;
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
            // FormTblDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblDoctors";
            this.Text = "FormTblDoctors";
            this.Load += new System.EventHandler(this.FormTblDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetDoctors dataSetDoctors;
        private System.Windows.Forms.BindingSource tblDoctorsBindingSource;
        private DataSetDoctorsTableAdapters.tblDoctorsTableAdapter tblDoctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorProfessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
    }
}