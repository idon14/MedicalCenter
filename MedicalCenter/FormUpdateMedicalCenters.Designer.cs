namespace MedicalCenter
{
    partial class FormUpdateMedicalCenters
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
            this.medicalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMedicalCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMedicalCenter = new MedicalCenter.DataSetMedicalCenter();
            this.tblMedicalCenterTableAdapter = new MedicalCenter.DataSetMedicalCenterTableAdapters.tblMedicalCenterTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.imageField = new System.Windows.Forms.TextBox();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMedicalCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // medicalNameDataGridViewTextBoxColumn
            // 
            this.medicalNameDataGridViewTextBoxColumn.DataPropertyName = "medicalName";
            this.medicalNameDataGridViewTextBoxColumn.HeaderText = "שם המרכז הרפואי";
            this.medicalNameDataGridViewTextBoxColumn.Name = "medicalNameDataGridViewTextBoxColumn";
            this.medicalNameDataGridViewTextBoxColumn.Width = 150;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(929, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "עדכון פרטי מרכז רפואי";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "שם המרכז הרפואי";
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Location = new System.Drawing.Point(568, 45);
            this.nameField.Name = "nameField";
            this.nameField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameField.Size = new System.Drawing.Size(250, 20);
            this.nameField.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "כתובת";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(266, 45);
            this.addressField.Name = "addressField";
            this.addressField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addressField.Size = new System.Drawing.Size(250, 20);
            this.addressField.TabIndex = 1;
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(18, 45);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityCombo.Size = new System.Drawing.Size(211, 21);
            this.cityCombo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "עיר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "טלפון";
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(568, 86);
            this.phoneField.Name = "phoneField";
            this.phoneField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneField.Size = new System.Drawing.Size(250, 20);
            this.phoneField.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(18, 86);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 20);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "עיון";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "תמונה";
            // 
            // imageField
            // 
            this.imageField.Location = new System.Drawing.Point(99, 86);
            this.imageField.Name = "imageField";
            this.imageField.Size = new System.Drawing.Size(417, 20);
            this.imageField.TabIndex = 4;
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(597, 144);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(62, 33);
            this.firstButton.TabIndex = 6;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(514, 144);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(62, 33);
            this.previousButton.TabIndex = 7;
            this.previousButton.Text = "הקודם";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(393, 144);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(62, 33);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(310, 144);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(62, 33);
            this.lastButton.TabIndex = 9;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateButton.Location = new System.Drawing.Point(447, 193);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 43);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "עדכון";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(818, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "טבלת מרכז רפואי";
            // 
            // FormUpdateMedicalCenters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.imageField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUpdateMedicalCenters";
            this.Text = "FormUpdateMedicalCenters";
            this.Load += new System.EventHandler(this.FormUpdateMedicalCenters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMedicalCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetMedicalCenter dataSetMedicalCenter;
        private System.Windows.Forms.BindingSource tblMedicalCenterBindingSource;
        private DataSetMedicalCenterTableAdapters.tblMedicalCenterTableAdapter tblMedicalCenterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imageField;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label7;
    }
}