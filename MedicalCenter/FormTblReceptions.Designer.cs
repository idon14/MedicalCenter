namespace MedicalCenter
{
    partial class FormTblReceptions
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
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת שעות קבלה";
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 520);
            this.dataGridView1.TabIndex = 1;
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
            // FormTblReceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblReceptions";
            this.Text = "FormTblReceptions";
            this.Load += new System.EventHandler(this.FormTblReceptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReceptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button saveButton;
    }
}