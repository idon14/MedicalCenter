namespace MedicalCenter
{
    partial class FormTblProfessions
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
            this.professionHebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProfessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProfessions = new MedicalCenter.DataSetProfessions();
            this.tblProfessionsTableAdapter = new MedicalCenter.DataSetProfessionsTableAdapters.tblProfessionsTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfessions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(635, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת התמחויות";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionHebDataGridViewTextBoxColumn,
            this.professionEngDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProfessionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1318, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // professionHebDataGridViewTextBoxColumn
            // 
            this.professionHebDataGridViewTextBoxColumn.DataPropertyName = "professionHeb";
            this.professionHebDataGridViewTextBoxColumn.HeaderText = "התמחות עברית";
            this.professionHebDataGridViewTextBoxColumn.Name = "professionHebDataGridViewTextBoxColumn";
            // 
            // professionEngDataGridViewTextBoxColumn
            // 
            this.professionEngDataGridViewTextBoxColumn.DataPropertyName = "professionEng";
            this.professionEngDataGridViewTextBoxColumn.HeaderText = "התמחות אנגלית";
            this.professionEngDataGridViewTextBoxColumn.Name = "professionEngDataGridViewTextBoxColumn";
            // 
            // tblProfessionsBindingSource
            // 
            this.tblProfessionsBindingSource.DataMember = "tblProfessions";
            this.tblProfessionsBindingSource.DataSource = this.dataSetProfessions;
            // 
            // dataSetProfessions
            // 
            this.dataSetProfessions.DataSetName = "DataSetProfessions";
            this.dataSetProfessions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProfessionsTableAdapter
            // 
            this.tblProfessionsTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(657, 625);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "שמירה";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // FormTblProfessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1370, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FormTblProfessions";
            this.Text = "FormTblProfessions";
            this.Load += new System.EventHandler(this.FormTblProfessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetProfessions dataSetProfessions;
        private System.Windows.Forms.BindingSource tblProfessionsBindingSource;
        private DataSetProfessionsTableAdapters.tblProfessionsTableAdapter tblProfessionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionHebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
    }
}