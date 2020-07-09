namespace MedicalCenter
{
    partial class FormAddClinics
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
            this.clinicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClinicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClinics = new MedicalCenter.DataSetClinics();
            this.tblClinicsTableAdapter = new MedicalCenter.DataSetClinicsTableAdapters.tblClinicsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureField = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClinicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 14;
            // 
            // clinicNameDataGridViewTextBoxColumn
            // 
            this.clinicNameDataGridViewTextBoxColumn.DataPropertyName = "clinicName";
            this.clinicNameDataGridViewTextBoxColumn.HeaderText = "שם המרפאה";
            this.clinicNameDataGridViewTextBoxColumn.Name = "clinicNameDataGridViewTextBoxColumn";
            // 
            // clinicAddressDataGridViewTextBoxColumn
            // 
            this.clinicAddressDataGridViewTextBoxColumn.DataPropertyName = "clinicAddress";
            this.clinicAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.clinicAddressDataGridViewTextBoxColumn.Name = "clinicAddressDataGridViewTextBoxColumn";
            // 
            // clinicCityDataGridViewTextBoxColumn
            // 
            this.clinicCityDataGridViewTextBoxColumn.DataPropertyName = "clinicCity";
            this.clinicCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.clinicCityDataGridViewTextBoxColumn.Name = "clinicCityDataGridViewTextBoxColumn";
            // 
            // clinicPhoneDataGridViewTextBoxColumn
            // 
            this.clinicPhoneDataGridViewTextBoxColumn.DataPropertyName = "clinicPhone";
            this.clinicPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.clinicPhoneDataGridViewTextBoxColumn.Name = "clinicPhoneDataGridViewTextBoxColumn";
            // 
            // clinicPictureDataGridViewTextBoxColumn
            // 
            this.clinicPictureDataGridViewTextBoxColumn.DataPropertyName = "clinicPicture";
            this.clinicPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.clinicPictureDataGridViewTextBoxColumn.Name = "clinicPictureDataGridViewTextBoxColumn";
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
            // tblClinicsTableAdapter
            // 
            this.tblClinicsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת מרפאה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(960, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(424, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 34);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "הוספה";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(498, 57);
            this.nameField.Name = "nameField";
            this.nameField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameField.Size = new System.Drawing.Size(250, 20);
            this.nameField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם המרפאה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "כתובת";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(153, 57);
            this.addressField.Name = "addressField";
            this.addressField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addressField.Size = new System.Drawing.Size(250, 20);
            this.addressField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "עיר";
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(498, 99);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityCombo.Size = new System.Drawing.Size(250, 21);
            this.cityCombo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "טלפון";
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(153, 99);
            this.phoneField.Name = "phoneField";
            this.phoneField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneField.Size = new System.Drawing.Size(250, 20);
            this.phoneField.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "תמונה";
            // 
            // pictureField
            // 
            this.pictureField.Location = new System.Drawing.Point(234, 143);
            this.pictureField.Name = "pictureField";
            this.pictureField.Size = new System.Drawing.Size(514, 20);
            this.pictureField.TabIndex = 10;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(153, 143);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 20);
            this.browseBtn.TabIndex = 11;
            this.browseBtn.Text = "עיון";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(1086, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "טבלת מרפאות";
            // 
            // FormAddClinics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddClinics";
            this.Text = "FormAddClinics";
            this.Load += new System.EventHandler(this.FormAddClinics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClinicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetClinics dataSetClinics;
        private System.Windows.Forms.BindingSource tblClinicsBindingSource;
        private DataSetClinicsTableAdapters.tblClinicsTableAdapter tblClinicsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pictureField;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
    }
}