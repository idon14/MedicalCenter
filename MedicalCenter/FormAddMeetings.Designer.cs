namespace MedicalCenter
{
    partial class FormAddMeetings
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
            this.meetingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingMemberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingDoctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingOrderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingCancelledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.meetingOccurredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblMeetingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMeetings = new MedicalCenter.DataSetMeetings();
            this.tblMeetingsTableAdapter = new MedicalCenter.DataSetMeetingsTableAdapters.tblMeetingsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.DateTimePicker();
            this.cancelledChkbox = new System.Windows.Forms.CheckBox();
            this.occurredChkbox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dateOrderField = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.memberIdCombo = new System.Windows.Forms.ComboBox();
            this.doctorIdCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meetingIDDataGridViewTextBoxColumn,
            this.meetingMemberIDDataGridViewTextBoxColumn,
            this.meetingDoctorIDDataGridViewTextBoxColumn,
            this.meetingDateDataGridViewTextBoxColumn,
            this.meetingHourDataGridViewTextBoxColumn,
            this.meetingOrderDateDataGridViewTextBoxColumn,
            this.meetingCancelledDataGridViewCheckBoxColumn,
            this.meetingOccurredDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblMeetingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 8;
            // 
            // meetingIDDataGridViewTextBoxColumn
            // 
            this.meetingIDDataGridViewTextBoxColumn.DataPropertyName = "meetingID";
            this.meetingIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.meetingIDDataGridViewTextBoxColumn.Name = "meetingIDDataGridViewTextBoxColumn";
            this.meetingIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // meetingMemberIDDataGridViewTextBoxColumn
            // 
            this.meetingMemberIDDataGridViewTextBoxColumn.DataPropertyName = "meetingMemberID";
            this.meetingMemberIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז חבר";
            this.meetingMemberIDDataGridViewTextBoxColumn.Name = "meetingMemberIDDataGridViewTextBoxColumn";
            this.meetingMemberIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // meetingDoctorIDDataGridViewTextBoxColumn
            // 
            this.meetingDoctorIDDataGridViewTextBoxColumn.DataPropertyName = "meetingDoctorID";
            this.meetingDoctorIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז רופא";
            this.meetingDoctorIDDataGridViewTextBoxColumn.Name = "meetingDoctorIDDataGridViewTextBoxColumn";
            this.meetingDoctorIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // meetingDateDataGridViewTextBoxColumn
            // 
            this.meetingDateDataGridViewTextBoxColumn.DataPropertyName = "meetingDate";
            this.meetingDateDataGridViewTextBoxColumn.HeaderText = "תאריך התור";
            this.meetingDateDataGridViewTextBoxColumn.Name = "meetingDateDataGridViewTextBoxColumn";
            this.meetingDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // meetingHourDataGridViewTextBoxColumn
            // 
            this.meetingHourDataGridViewTextBoxColumn.DataPropertyName = "meetingHour";
            this.meetingHourDataGridViewTextBoxColumn.HeaderText = "שעת התור";
            this.meetingHourDataGridViewTextBoxColumn.Name = "meetingHourDataGridViewTextBoxColumn";
            this.meetingHourDataGridViewTextBoxColumn.Width = 120;
            // 
            // meetingOrderDateDataGridViewTextBoxColumn
            // 
            this.meetingOrderDateDataGridViewTextBoxColumn.DataPropertyName = "meetingOrderDate";
            this.meetingOrderDateDataGridViewTextBoxColumn.HeaderText = "תאריך קביעת התור";
            this.meetingOrderDateDataGridViewTextBoxColumn.Name = "meetingOrderDateDataGridViewTextBoxColumn";
            this.meetingOrderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // meetingCancelledDataGridViewCheckBoxColumn
            // 
            this.meetingCancelledDataGridViewCheckBoxColumn.DataPropertyName = "meetingCancelled";
            this.meetingCancelledDataGridViewCheckBoxColumn.HeaderText = "התור בוטל";
            this.meetingCancelledDataGridViewCheckBoxColumn.Name = "meetingCancelledDataGridViewCheckBoxColumn";
            this.meetingCancelledDataGridViewCheckBoxColumn.Width = 120;
            // 
            // meetingOccurredDataGridViewCheckBoxColumn
            // 
            this.meetingOccurredDataGridViewCheckBoxColumn.DataPropertyName = "meetingOccurred";
            this.meetingOccurredDataGridViewCheckBoxColumn.HeaderText = "התור מומש";
            this.meetingOccurredDataGridViewCheckBoxColumn.Name = "meetingOccurredDataGridViewCheckBoxColumn";
            this.meetingOccurredDataGridViewCheckBoxColumn.Width = 120;
            // 
            // tblMeetingsBindingSource
            // 
            this.tblMeetingsBindingSource.DataMember = "tblMeetings";
            this.tblMeetingsBindingSource.DataSource = this.dataSetMeetings;
            // 
            // dataSetMeetings
            // 
            this.dataSetMeetings.DataSetName = "DataSetMeetings";
            this.dataSetMeetings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMeetingsTableAdapter
            // 
            this.tblMeetingsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "הוספת תור";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ת\"ז רופא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ת\"ז חבר";
            // 
            // dateField
            // 
            this.dateField.CustomFormat = "dd/MM/yyyy";
            this.dateField.Location = new System.Drawing.Point(640, 95);
            this.dateField.Name = "dateField";
            this.dateField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateField.RightToLeftLayout = true;
            this.dateField.Size = new System.Drawing.Size(250, 20);
            this.dateField.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(896, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "תאריך התור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "שעת התור";
            // 
            // timeField
            // 
            this.timeField.CustomFormat = "HH:mm";
            this.timeField.Location = new System.Drawing.Point(289, 95);
            this.timeField.Name = "timeField";
            this.timeField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeField.RightToLeftLayout = true;
            this.timeField.Size = new System.Drawing.Size(250, 20);
            this.timeField.TabIndex = 3;
            // 
            // cancelledChkbox
            // 
            this.cancelledChkbox.AutoSize = true;
            this.cancelledChkbox.Location = new System.Drawing.Point(518, 144);
            this.cancelledChkbox.Name = "cancelledChkbox";
            this.cancelledChkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelledChkbox.Size = new System.Drawing.Size(80, 17);
            this.cancelledChkbox.TabIndex = 5;
            this.cancelledChkbox.Text = "התור בוטל";
            this.cancelledChkbox.UseVisualStyleBackColor = true;
            // 
            // occurredChkbox
            // 
            this.occurredChkbox.AutoSize = true;
            this.occurredChkbox.Location = new System.Drawing.Point(430, 144);
            this.occurredChkbox.Name = "occurredChkbox";
            this.occurredChkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.occurredChkbox.Size = new System.Drawing.Size(82, 17);
            this.occurredChkbox.TabIndex = 6;
            this.occurredChkbox.Text = "התור מומש";
            this.occurredChkbox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(566, 193);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 34);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "הוספה";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // dateOrderField
            // 
            this.dateOrderField.CustomFormat = "dd/MM/yyyy";
            this.dateOrderField.Location = new System.Drawing.Point(640, 144);
            this.dateOrderField.Name = "dateOrderField";
            this.dateOrderField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateOrderField.RightToLeftLayout = true;
            this.dateOrderField.Size = new System.Drawing.Size(250, 20);
            this.dateOrderField.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(896, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "תאריך קביעת התור";
            // 
            // memberIdCombo
            // 
            this.memberIdCombo.FormattingEnabled = true;
            this.memberIdCombo.Location = new System.Drawing.Point(640, 46);
            this.memberIdCombo.Name = "memberIdCombo";
            this.memberIdCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.memberIdCombo.Size = new System.Drawing.Size(250, 21);
            this.memberIdCombo.TabIndex = 0;
            // 
            // doctorIdCombo
            // 
            this.doctorIdCombo.FormattingEnabled = true;
            this.doctorIdCombo.Location = new System.Drawing.Point(289, 46);
            this.doctorIdCombo.Name = "doctorIdCombo";
            this.doctorIdCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctorIdCombo.Size = new System.Drawing.Size(250, 21);
            this.doctorIdCombo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(1098, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "טבלת תורים";
            // 
            // FormAddMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doctorIdCombo);
            this.Controls.Add(this.memberIdCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateOrderField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.occurredChkbox);
            this.Controls.Add(this.cancelledChkbox);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddMeetings";
            this.Text = "FormAddMeetings";
            this.Load += new System.EventHandler(this.FormAddMeetings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetMeetings dataSetMeetings;
        private System.Windows.Forms.BindingSource tblMeetingsBindingSource;
        private DataSetMeetingsTableAdapters.tblMeetingsTableAdapter tblMeetingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingMemberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingDoctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingOrderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn meetingCancelledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn meetingOccurredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timeField;
        private System.Windows.Forms.CheckBox cancelledChkbox;
        private System.Windows.Forms.CheckBox occurredChkbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateOrderField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox memberIdCombo;
        private System.Windows.Forms.ComboBox doctorIdCombo;
        private System.Windows.Forms.Label label7;
    }
}