namespace MedicalCenter
{
    partial class FormUpdateMeetings
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
            this.numField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.memberIdCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorIdCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.hourField = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDateField = new System.Windows.Forms.DateTimePicker();
            this.cancelledChkbox = new System.Windows.Forms.CheckBox();
            this.occurredChkbox = new System.Windows.Forms.CheckBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // meetingIDDataGridViewTextBoxColumn
            // 
            this.meetingIDDataGridViewTextBoxColumn.DataPropertyName = "meetingID";
            this.meetingIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.meetingIDDataGridViewTextBoxColumn.Name = "meetingIDDataGridViewTextBoxColumn";
            // 
            // meetingMemberIDDataGridViewTextBoxColumn
            // 
            this.meetingMemberIDDataGridViewTextBoxColumn.DataPropertyName = "meetingMemberID";
            this.meetingMemberIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז חבר";
            this.meetingMemberIDDataGridViewTextBoxColumn.Name = "meetingMemberIDDataGridViewTextBoxColumn";
            // 
            // meetingDoctorIDDataGridViewTextBoxColumn
            // 
            this.meetingDoctorIDDataGridViewTextBoxColumn.DataPropertyName = "meetingDoctorID";
            this.meetingDoctorIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז רופא";
            this.meetingDoctorIDDataGridViewTextBoxColumn.Name = "meetingDoctorIDDataGridViewTextBoxColumn";
            // 
            // meetingDateDataGridViewTextBoxColumn
            // 
            this.meetingDateDataGridViewTextBoxColumn.DataPropertyName = "meetingDate";
            this.meetingDateDataGridViewTextBoxColumn.HeaderText = "תאריך התור";
            this.meetingDateDataGridViewTextBoxColumn.Name = "meetingDateDataGridViewTextBoxColumn";
            // 
            // meetingHourDataGridViewTextBoxColumn
            // 
            this.meetingHourDataGridViewTextBoxColumn.DataPropertyName = "meetingHour";
            this.meetingHourDataGridViewTextBoxColumn.HeaderText = "שעת התור";
            this.meetingHourDataGridViewTextBoxColumn.Name = "meetingHourDataGridViewTextBoxColumn";
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
            // 
            // meetingOccurredDataGridViewCheckBoxColumn
            // 
            this.meetingOccurredDataGridViewCheckBoxColumn.DataPropertyName = "meetingOccurred";
            this.meetingOccurredDataGridViewCheckBoxColumn.HeaderText = "התור מומש";
            this.meetingOccurredDataGridViewCheckBoxColumn.Name = "meetingOccurredDataGridViewCheckBoxColumn";
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "עדכון פרטי תור";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1104, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "מספר מזהה";
            // 
            // numField
            // 
            this.numField.Enabled = false;
            this.numField.Location = new System.Drawing.Point(848, 44);
            this.numField.Name = "numField";
            this.numField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numField.Size = new System.Drawing.Size(250, 20);
            this.numField.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ת\"ז חבר";
            // 
            // memberIdCombo
            // 
            this.memberIdCombo.FormattingEnabled = true;
            this.memberIdCombo.Location = new System.Drawing.Point(493, 44);
            this.memberIdCombo.Name = "memberIdCombo";
            this.memberIdCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.memberIdCombo.Size = new System.Drawing.Size(250, 21);
            this.memberIdCombo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ת\"ז רופא";
            // 
            // doctorIdCombo
            // 
            this.doctorIdCombo.FormattingEnabled = true;
            this.doctorIdCombo.Location = new System.Drawing.Point(112, 44);
            this.doctorIdCombo.Name = "doctorIdCombo";
            this.doctorIdCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctorIdCombo.Size = new System.Drawing.Size(250, 21);
            this.doctorIdCombo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1104, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "תאריך התור";
            // 
            // dateField
            // 
            this.dateField.CustomFormat = "dd/MM/yyyy";
            this.dateField.Location = new System.Drawing.Point(848, 90);
            this.dateField.Name = "dateField";
            this.dateField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateField.RightToLeftLayout = true;
            this.dateField.Size = new System.Drawing.Size(250, 20);
            this.dateField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "שעת התור";
            // 
            // hourField
            // 
            this.hourField.CustomFormat = "HH:mm";
            this.hourField.Location = new System.Drawing.Point(493, 89);
            this.hourField.Name = "hourField";
            this.hourField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hourField.RightToLeftLayout = true;
            this.hourField.Size = new System.Drawing.Size(250, 20);
            this.hourField.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "תאריך קביעת התור";
            // 
            // orderDateField
            // 
            this.orderDateField.CustomFormat = "dd/MM/yyyy";
            this.orderDateField.Location = new System.Drawing.Point(112, 89);
            this.orderDateField.Name = "orderDateField";
            this.orderDateField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderDateField.RightToLeftLayout = true;
            this.orderDateField.Size = new System.Drawing.Size(250, 20);
            this.orderDateField.TabIndex = 5;
            // 
            // cancelledChkbox
            // 
            this.cancelledChkbox.AutoSize = true;
            this.cancelledChkbox.Location = new System.Drawing.Point(663, 126);
            this.cancelledChkbox.Name = "cancelledChkbox";
            this.cancelledChkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelledChkbox.Size = new System.Drawing.Size(80, 17);
            this.cancelledChkbox.TabIndex = 6;
            this.cancelledChkbox.Text = "התור בוטל";
            this.cancelledChkbox.UseVisualStyleBackColor = true;
            // 
            // occurredChkbox
            // 
            this.occurredChkbox.AutoSize = true;
            this.occurredChkbox.Location = new System.Drawing.Point(493, 126);
            this.occurredChkbox.Name = "occurredChkbox";
            this.occurredChkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.occurredChkbox.Size = new System.Drawing.Size(82, 17);
            this.occurredChkbox.TabIndex = 7;
            this.occurredChkbox.Text = "התור מומש";
            this.occurredChkbox.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(633, 158);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(62, 33);
            this.previousButton.TabIndex = 9;
            this.previousButton.Text = "הקודם";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(456, 158);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(62, 33);
            this.lastButton.TabIndex = 11;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(533, 158);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(62, 33);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(708, 158);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(62, 33);
            this.firstButton.TabIndex = 8;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateButton.Location = new System.Drawing.Point(578, 203);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 43);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "עדכון";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(1098, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "טבלת תורים";
            // 
            // FormUpdateMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.occurredChkbox);
            this.Controls.Add(this.cancelledChkbox);
            this.Controls.Add(this.orderDateField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hourField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doctorIdCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberIdCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUpdateMeetings";
            this.Text = "FormUpdateMeetings";
            this.Load += new System.EventHandler(this.FormUpdateMeetings_Load);
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
        private System.Windows.Forms.TextBox numField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox memberIdCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doctorIdCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker hourField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker orderDateField;
        private System.Windows.Forms.CheckBox cancelledChkbox;
        private System.Windows.Forms.CheckBox occurredChkbox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label8;
    }
}