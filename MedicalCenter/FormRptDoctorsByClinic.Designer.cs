namespace MedicalCenter
{
    partial class FormRptDoctorsByClinic
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
            this.firstButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClinicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClinics = new MedicalCenter.DataSetClinics();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.tblClinicsTableAdapter = new MedicalCenter.DataSetClinicsTableAdapters.tblClinicsTableAdapter();
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClinicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinics)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "דוח רופאים לפי מרפאה";
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(12, 39);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(150, 41);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinicNameDataGridViewTextBoxColumn,
            this.clinicAddressDataGridViewTextBoxColumn,
            this.clinicCityDataGridViewTextBoxColumn,
            this.clinicPhoneDataGridViewTextBoxColumn,
            this.clinicPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblClinicsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(168, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // clinicNameDataGridViewTextBoxColumn
            // 
            this.clinicNameDataGridViewTextBoxColumn.DataPropertyName = "clinicName";
            this.clinicNameDataGridViewTextBoxColumn.HeaderText = "שם המרפאה";
            this.clinicNameDataGridViewTextBoxColumn.Name = "clinicNameDataGridViewTextBoxColumn";
            this.clinicNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // clinicAddressDataGridViewTextBoxColumn
            // 
            this.clinicAddressDataGridViewTextBoxColumn.DataPropertyName = "clinicAddress";
            this.clinicAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.clinicAddressDataGridViewTextBoxColumn.Name = "clinicAddressDataGridViewTextBoxColumn";
            this.clinicAddressDataGridViewTextBoxColumn.Width = 130;
            // 
            // clinicCityDataGridViewTextBoxColumn
            // 
            this.clinicCityDataGridViewTextBoxColumn.DataPropertyName = "clinicCity";
            this.clinicCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.clinicCityDataGridViewTextBoxColumn.Name = "clinicCityDataGridViewTextBoxColumn";
            this.clinicCityDataGridViewTextBoxColumn.Width = 130;
            // 
            // clinicPhoneDataGridViewTextBoxColumn
            // 
            this.clinicPhoneDataGridViewTextBoxColumn.DataPropertyName = "clinicPhone";
            this.clinicPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.clinicPhoneDataGridViewTextBoxColumn.Name = "clinicPhoneDataGridViewTextBoxColumn";
            this.clinicPhoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // clinicPictureDataGridViewTextBoxColumn
            // 
            this.clinicPictureDataGridViewTextBoxColumn.DataPropertyName = "clinicPicture";
            this.clinicPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.clinicPictureDataGridViewTextBoxColumn.Name = "clinicPictureDataGridViewTextBoxColumn";
            this.clinicPictureDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblClinicsBindingSource
            // 
            this.tblClinicsBindingSource.DataMember = "tblClinics";
            this.tblClinicsBindingSource.DataSource = this.dataSetClinics;
            // 
            // dataSetClinics
            // 
            this.dataSetClinics.DataSetName = "DataSetClinics";
            this.dataSetClinics.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(12, 86);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(150, 41);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(12, 133);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 41);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(13, 182);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(150, 41);
            this.lastButton.TabIndex = 4;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // tblClinicsTableAdapter
            // 
            this.tblClinicsTableAdapter.ClearBeforeFill = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(350, 462);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 45);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "בחר צבע";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(505, 462);
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
            this.columnHeader9});
            this.listView1.Location = new System.Drawing.Point(13, 230);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(903, 226);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "שם המרפאה";
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
            this.columnHeader5.Text = "כתובת";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "עיר";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "טלפון";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "נייד";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "מייל";
            this.columnHeader9.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(830, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "טבלת מרפאות";
            // 
            // FormRptDoctorsByClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(928, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.label1);
            this.Name = "FormRptDoctorsByClinic";
            this.Text = "FormRptDoctorsByClinic";
            this.Load += new System.EventHandler(this.FormRptDoctorsByClinic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClinicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private DataSetClinics dataSetClinics;
        private System.Windows.Forms.BindingSource tblClinicsBindingSource;
        private DataSetClinicsTableAdapters.tblClinicsTableAdapter tblClinicsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicPictureDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label label2;
    }
}