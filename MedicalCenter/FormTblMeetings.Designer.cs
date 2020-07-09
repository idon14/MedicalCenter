namespace MedicalCenter
{
    partial class FormTblMeetings
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
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת תורים";
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 520);
            this.dataGridView1.TabIndex = 1;
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
            // FormTblMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblMeetings";
            this.Text = "FormTblMeetings";
            this.Load += new System.EventHandler(this.FormTblMeetings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMeetingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button saveButton;
    }
}