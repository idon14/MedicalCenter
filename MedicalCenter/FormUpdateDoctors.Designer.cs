namespace MedicalCenter
{
    partial class FormUpdateDoctors
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorProfessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDoctors = new MedicalCenter.DataSetDoctors();
            this.tblDoctorsTableAdapter = new MedicalCenter.DataSetDoctorsTableAdapters.tblDoctorsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.degreeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.licenseField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.professionCombo = new System.Windows.Forms.ComboBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctors)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "עדכון פרטי רופא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(998, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "מספר מזהה";
            // 
            // numField
            // 
            this.numField.Enabled = false;
            this.numField.Location = new System.Drawing.Point(742, 52);
            this.numField.Name = "numField";
            this.numField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numField.Size = new System.Drawing.Size(250, 20);
            this.numField.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ת\"ז";
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(435, 52);
            this.idCombo.Name = "idCombo";
            this.idCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idCombo.Size = new System.Drawing.Size(250, 21);
            this.idCombo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "תואר";
            // 
            // degreeCombo
            // 
            this.degreeCombo.FormattingEnabled = true;
            this.degreeCombo.Location = new System.Drawing.Point(117, 51);
            this.degreeCombo.Name = "degreeCombo";
            this.degreeCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.degreeCombo.Size = new System.Drawing.Size(250, 21);
            this.degreeCombo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(998, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "התמחות";
            // 
            // licenseField
            // 
            this.licenseField.Location = new System.Drawing.Point(117, 101);
            this.licenseField.Name = "licenseField";
            this.licenseField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.licenseField.Size = new System.Drawing.Size(380, 20);
            this.licenseField.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "מספר רישיון";
            // 
            // professionCombo
            // 
            this.professionCombo.FormattingEnabled = true;
            this.professionCombo.Location = new System.Drawing.Point(612, 101);
            this.professionCombo.Name = "professionCombo";
            this.professionCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.professionCombo.Size = new System.Drawing.Size(380, 21);
            this.professionCombo.TabIndex = 3;
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(612, 147);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(62, 33);
            this.previousButton.TabIndex = 6;
            this.previousButton.Text = "הקודם";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousClick);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(694, 147);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(62, 33);
            this.firstButton.TabIndex = 5;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(499, 147);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(62, 33);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(417, 147);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(62, 33);
            this.lastButton.TabIndex = 8;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateButton.Location = new System.Drawing.Point(548, 199);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 43);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "עדכון";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(1090, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "טבלת רופאים";
            // 
            // FormUpdateDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.professionCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.licenseField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.degreeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUpdateDoctors";
            this.Text = "FormUpdateDoctors";
            this.Load += new System.EventHandler(this.FormUpdateDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetDoctors dataSetDoctors;
        private System.Windows.Forms.BindingSource tblDoctorsBindingSource;
        private DataSetDoctorsTableAdapters.tblDoctorsTableAdapter tblDoctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorProfessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox degreeCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox licenseField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox professionCombo;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label7;
    }
}