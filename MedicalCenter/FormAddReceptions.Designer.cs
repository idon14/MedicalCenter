namespace MedicalCenter
{
    partial class FormAddReceptions
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
            this.recepIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepDoctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepDayInWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepFromHour1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepToHour1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepClinic1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepFromHour2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepToHour2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepClinic2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblReceptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReceptions = new MedicalCenter.DataSetReceptions();
            this.tblReceptionsTableAdapter = new MedicalCenter.DataSetReceptionsTableAdapters.tblReceptionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.minutesField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstFromField = new System.Windows.Forms.DateTimePicker();
            this.firstUntilField = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.firstClinicCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secondFromField = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.secondUntilField = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.secondClinicCombo = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.idCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceptions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recepIDDataGridViewTextBoxColumn,
            this.recepDoctorIDDataGridViewTextBoxColumn,
            this.recepDayInWeekDataGridViewTextBoxColumn,
            this.recepFromHour1DataGridViewTextBoxColumn,
            this.recepToHour1DataGridViewTextBoxColumn,
            this.recepClinic1DataGridViewTextBoxColumn,
            this.recepFromHour2DataGridViewTextBoxColumn,
            this.recepToHour2DataGridViewTextBoxColumn,
            this.recepClinic2DataGridViewTextBoxColumn,
            this.recepMinutesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblReceptionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 10;
            // 
            // recepIDDataGridViewTextBoxColumn
            // 
            this.recepIDDataGridViewTextBoxColumn.DataPropertyName = "recepID";
            this.recepIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.recepIDDataGridViewTextBoxColumn.Name = "recepIDDataGridViewTextBoxColumn";
            // 
            // recepDoctorIDDataGridViewTextBoxColumn
            // 
            this.recepDoctorIDDataGridViewTextBoxColumn.DataPropertyName = "recepDoctorID";
            this.recepDoctorIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז רופא";
            this.recepDoctorIDDataGridViewTextBoxColumn.Name = "recepDoctorIDDataGridViewTextBoxColumn";
            // 
            // recepDayInWeekDataGridViewTextBoxColumn
            // 
            this.recepDayInWeekDataGridViewTextBoxColumn.DataPropertyName = "recepDayInWeek";
            this.recepDayInWeekDataGridViewTextBoxColumn.HeaderText = "יום בשבוע";
            this.recepDayInWeekDataGridViewTextBoxColumn.Name = "recepDayInWeekDataGridViewTextBoxColumn";
            // 
            // recepFromHour1DataGridViewTextBoxColumn
            // 
            this.recepFromHour1DataGridViewTextBoxColumn.DataPropertyName = "recepFromHour1";
            this.recepFromHour1DataGridViewTextBoxColumn.HeaderText = "משעה 1";
            this.recepFromHour1DataGridViewTextBoxColumn.Name = "recepFromHour1DataGridViewTextBoxColumn";
            // 
            // recepToHour1DataGridViewTextBoxColumn
            // 
            this.recepToHour1DataGridViewTextBoxColumn.DataPropertyName = "recepToHour1";
            this.recepToHour1DataGridViewTextBoxColumn.HeaderText = "עד שעה 1";
            this.recepToHour1DataGridViewTextBoxColumn.Name = "recepToHour1DataGridViewTextBoxColumn";
            // 
            // recepClinic1DataGridViewTextBoxColumn
            // 
            this.recepClinic1DataGridViewTextBoxColumn.DataPropertyName = "recepClinic1";
            this.recepClinic1DataGridViewTextBoxColumn.HeaderText = "מרפאה 1";
            this.recepClinic1DataGridViewTextBoxColumn.Name = "recepClinic1DataGridViewTextBoxColumn";
            // 
            // recepFromHour2DataGridViewTextBoxColumn
            // 
            this.recepFromHour2DataGridViewTextBoxColumn.DataPropertyName = "recepFromHour2";
            this.recepFromHour2DataGridViewTextBoxColumn.HeaderText = "משעה 2";
            this.recepFromHour2DataGridViewTextBoxColumn.Name = "recepFromHour2DataGridViewTextBoxColumn";
            // 
            // recepToHour2DataGridViewTextBoxColumn
            // 
            this.recepToHour2DataGridViewTextBoxColumn.DataPropertyName = "recepToHour2";
            this.recepToHour2DataGridViewTextBoxColumn.HeaderText = "עד שעה 2";
            this.recepToHour2DataGridViewTextBoxColumn.Name = "recepToHour2DataGridViewTextBoxColumn";
            // 
            // recepClinic2DataGridViewTextBoxColumn
            // 
            this.recepClinic2DataGridViewTextBoxColumn.DataPropertyName = "recepClinic2";
            this.recepClinic2DataGridViewTextBoxColumn.HeaderText = "מרפאה 2";
            this.recepClinic2DataGridViewTextBoxColumn.Name = "recepClinic2DataGridViewTextBoxColumn";
            // 
            // recepMinutesDataGridViewTextBoxColumn
            // 
            this.recepMinutesDataGridViewTextBoxColumn.DataPropertyName = "recepMinutes";
            this.recepMinutesDataGridViewTextBoxColumn.HeaderText = "מספר דקות לתור";
            this.recepMinutesDataGridViewTextBoxColumn.Name = "recepMinutesDataGridViewTextBoxColumn";
            this.recepMinutesDataGridViewTextBoxColumn.Width = 120;
            // 
            // tblReceptionsBindingSource
            // 
            this.tblReceptionsBindingSource.DataMember = "tblReceptions";
            this.tblReceptionsBindingSource.DataSource = this.dataSetReceptions;
            // 
            // dataSetReceptions
            // 
            this.dataSetReceptions.DataSetName = "DataSetReceptions";
            this.dataSetReceptions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReceptionsTableAdapter
            // 
            this.tblReceptionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "הוספת שעות קבלה";
            // 
            // minutesField
            // 
            this.minutesField.Location = new System.Drawing.Point(18, 48);
            this.minutesField.Name = "minutesField";
            this.minutesField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minutesField.Size = new System.Drawing.Size(250, 20);
            this.minutesField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "מספר דקות לתור";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1119, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ת\"ז רופא";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "יום בשבוע";
            // 
            // dayCombo
            // 
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.Location = new System.Drawing.Point(441, 47);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dayCombo.Size = new System.Drawing.Size(250, 21);
            this.dayCombo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1119, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "משעה 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "עד שעה 1";
            // 
            // firstFromField
            // 
            this.firstFromField.CustomFormat = "HH:mm";
            this.firstFromField.Location = new System.Drawing.Point(863, 101);
            this.firstFromField.Name = "firstFromField";
            this.firstFromField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstFromField.RightToLeftLayout = true;
            this.firstFromField.Size = new System.Drawing.Size(250, 20);
            this.firstFromField.TabIndex = 3;
            // 
            // firstUntilField
            // 
            this.firstUntilField.CustomFormat = "HH:mm";
            this.firstUntilField.Location = new System.Drawing.Point(441, 101);
            this.firstUntilField.Name = "firstUntilField";
            this.firstUntilField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstUntilField.RightToLeftLayout = true;
            this.firstUntilField.Size = new System.Drawing.Size(250, 20);
            this.firstUntilField.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "מרפאה 1";
            // 
            // firstClinicCombo
            // 
            this.firstClinicCombo.FormattingEnabled = true;
            this.firstClinicCombo.Location = new System.Drawing.Point(18, 100);
            this.firstClinicCombo.Name = "firstClinicCombo";
            this.firstClinicCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstClinicCombo.Size = new System.Drawing.Size(251, 21);
            this.firstClinicCombo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1119, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "משעה 2";
            // 
            // secondFromField
            // 
            this.secondFromField.CustomFormat = "HH:mm";
            this.secondFromField.Location = new System.Drawing.Point(863, 154);
            this.secondFromField.Name = "secondFromField";
            this.secondFromField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secondFromField.RightToLeftLayout = true;
            this.secondFromField.Size = new System.Drawing.Size(250, 20);
            this.secondFromField.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "עד שעה 2";
            // 
            // secondUntilField
            // 
            this.secondUntilField.CustomFormat = "HH:mm";
            this.secondUntilField.Location = new System.Drawing.Point(441, 154);
            this.secondUntilField.Name = "secondUntilField";
            this.secondUntilField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secondUntilField.RightToLeftLayout = true;
            this.secondUntilField.Size = new System.Drawing.Size(250, 20);
            this.secondUntilField.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "מרפאה 2";
            // 
            // secondClinicCombo
            // 
            this.secondClinicCombo.FormattingEnabled = true;
            this.secondClinicCombo.Location = new System.Drawing.Point(18, 153);
            this.secondClinicCombo.Name = "secondClinicCombo";
            this.secondClinicCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.secondClinicCombo.Size = new System.Drawing.Size(250, 21);
            this.secondClinicCombo.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(611, 198);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 43);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "הוספה";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(863, 48);
            this.idCombo.Name = "idCombo";
            this.idCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idCombo.Size = new System.Drawing.Size(250, 21);
            this.idCombo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(1065, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "טבלת שעות קבלה";
            // 
            // FormAddReceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idCombo);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondClinicCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.secondUntilField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.secondFromField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstClinicCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firstUntilField);
            this.Controls.Add(this.firstFromField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutesField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddReceptions";
            this.Text = "FormAddReceptions";
            this.Load += new System.EventHandler(this.FormAddReceptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetReceptions dataSetReceptions;
        private System.Windows.Forms.BindingSource tblReceptionsBindingSource;
        private DataSetReceptionsTableAdapters.tblReceptionsTableAdapter tblReceptionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepDoctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepDayInWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepFromHour1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepToHour1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepClinic1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepFromHour2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepToHour2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepClinic2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minutesField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dayCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker firstFromField;
        private System.Windows.Forms.DateTimePicker firstUntilField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox firstClinicCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker secondFromField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker secondUntilField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox secondClinicCombo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox idCombo;
        private System.Windows.Forms.Label label11;
    }
}