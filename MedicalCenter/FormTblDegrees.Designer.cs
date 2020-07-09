namespace MedicalCenter
{
    partial class FormTblDegrees
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
            this.degreeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDegreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDegrees = new MedicalCenter.DataSetDegrees();
            this.tblDegreesTableAdapter = new MedicalCenter.DataSetDegreesTableAdapters.tblDegreesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDegreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDegrees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת תארים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDegreesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 520);
            this.dataGridView1.TabIndex = 1;
            // 
            // degreeNameDataGridViewTextBoxColumn
            // 
            this.degreeNameDataGridViewTextBoxColumn.DataPropertyName = "degreeName";
            this.degreeNameDataGridViewTextBoxColumn.HeaderText = "תואר";
            this.degreeNameDataGridViewTextBoxColumn.Name = "degreeNameDataGridViewTextBoxColumn";
            // 
            // tblDegreesBindingSource
            // 
            this.tblDegreesBindingSource.DataMember = "tblDegrees";
            this.tblDegreesBindingSource.DataSource = this.dataSetDegrees;
            // 
            // dataSetDegrees
            // 
            this.dataSetDegrees.DataSetName = "DataSetDegrees";
            this.dataSetDegrees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDegreesTableAdapter
            // 
            this.tblDegreesTableAdapter.ClearBeforeFill = true;
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
            // FormTblDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblDegrees";
            this.Text = "FormTblDegrees";
            this.Load += new System.EventHandler(this.FormTblDegrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDegreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDegrees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetDegrees dataSetDegrees;
        private System.Windows.Forms.BindingSource tblDegreesBindingSource;
        private DataSetDegreesTableAdapters.tblDegreesTableAdapter tblDegreesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
    }
}