namespace MedicalCenter
{
    partial class FormRptPatientsByDoctor
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
            this.firstButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "דוח מטופלים לפי רופא";
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
            this.dataGridView1.Location = new System.Drawing.Point(169, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(848, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // doctorNumDataGridViewTextBoxColumn
            // 
            this.doctorNumDataGridViewTextBoxColumn.DataPropertyName = "doctorNum";
            this.doctorNumDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.doctorNumDataGridViewTextBoxColumn.Name = "doctorNumDataGridViewTextBoxColumn";
            this.doctorNumDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "doctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorDegreeDataGridViewTextBoxColumn
            // 
            this.doctorDegreeDataGridViewTextBoxColumn.DataPropertyName = "doctorDegree";
            this.doctorDegreeDataGridViewTextBoxColumn.HeaderText = "תואר";
            this.doctorDegreeDataGridViewTextBoxColumn.Name = "doctorDegreeDataGridViewTextBoxColumn";
            this.doctorDegreeDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorProfessionDataGridViewTextBoxColumn
            // 
            this.doctorProfessionDataGridViewTextBoxColumn.DataPropertyName = "doctorProfession";
            this.doctorProfessionDataGridViewTextBoxColumn.HeaderText = "התמחות";
            this.doctorProfessionDataGridViewTextBoxColumn.Name = "doctorProfessionDataGridViewTextBoxColumn";
            this.doctorProfessionDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorLicenseDataGridViewTextBoxColumn
            // 
            this.doctorLicenseDataGridViewTextBoxColumn.DataPropertyName = "doctorLicense";
            this.doctorLicenseDataGridViewTextBoxColumn.HeaderText = "רישיון";
            this.doctorLicenseDataGridViewTextBoxColumn.Name = "doctorLicenseDataGridViewTextBoxColumn";
            this.doctorLicenseDataGridViewTextBoxColumn.Width = 120;
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
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(13, 39);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(150, 41);
            this.firstButton.TabIndex = 2;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(13, 87);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(150, 41);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(13, 135);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 41);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(13, 183);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(150, 41);
            this.lastButton.TabIndex = 5;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(408, 462);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 45);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "בחר צבע";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(557, 462);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "נקה דוח";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
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
            this.listView1.Location = new System.Drawing.Point(13, 231);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1004, 225);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "רופא";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ת\"ז";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם פרטי";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שם משפחה";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "תאריך לידה";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "כתובת";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(935, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "טבלת רופאים";
            // 
            // FormRptPatientsByDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1029, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormRptPatientsByDoctor";
            this.Text = "FormRptPatientsByDoctor";
            this.Load += new System.EventHandler(this.FormRptPatientsByDoctor_Load);
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
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorProfessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.Label label2;
    }
}