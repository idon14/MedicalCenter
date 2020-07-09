namespace MedicalCenter
{
    partial class FormAddProfessions
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
            this.professionHebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProfessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProfessions = new MedicalCenter.DataSetProfessions();
            this.tblProfessionsTableAdapter = new MedicalCenter.DataSetProfessionsTableAdapters.tblProfessionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.professionHebField = new System.Windows.Forms.TextBox();
            this.professionEngField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionHebDataGridViewTextBoxColumn,
            this.professionEngDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProfessionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // professionHebDataGridViewTextBoxColumn
            // 
            this.professionHebDataGridViewTextBoxColumn.DataPropertyName = "professionHeb";
            this.professionHebDataGridViewTextBoxColumn.HeaderText = "התמחות עברית";
            this.professionHebDataGridViewTextBoxColumn.Name = "professionHebDataGridViewTextBoxColumn";
            this.professionHebDataGridViewTextBoxColumn.Width = 200;
            // 
            // professionEngDataGridViewTextBoxColumn
            // 
            this.professionEngDataGridViewTextBoxColumn.DataPropertyName = "professionEng";
            this.professionEngDataGridViewTextBoxColumn.HeaderText = "התמחות אנגלית";
            this.professionEngDataGridViewTextBoxColumn.Name = "professionEngDataGridViewTextBoxColumn";
            this.professionEngDataGridViewTextBoxColumn.Width = 200;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "הוספת התמחות";
            // 
            // professionHebField
            // 
            this.professionHebField.Location = new System.Drawing.Point(458, 63);
            this.professionHebField.Name = "professionHebField";
            this.professionHebField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.professionHebField.Size = new System.Drawing.Size(250, 20);
            this.professionHebField.TabIndex = 0;
            // 
            // professionEngField
            // 
            this.professionEngField.Location = new System.Drawing.Point(458, 117);
            this.professionEngField.Name = "professionEngField";
            this.professionEngField.Size = new System.Drawing.Size(250, 20);
            this.professionEngField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "התמחות עברית";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "התמחות אנגלית";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(585, 174);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "הוספה";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1077, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "טבלת התמחויות";
            // 
            // FormAddProfessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.professionEngField);
            this.Controls.Add(this.professionHebField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddProfessions";
            this.Text = "FormAddProfession";
            this.Load += new System.EventHandler(this.FormAddProfessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProfessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetProfessions dataSetProfessions;
        private System.Windows.Forms.BindingSource tblProfessionsBindingSource;
        private DataSetProfessionsTableAdapters.tblProfessionsTableAdapter tblProfessionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionHebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox professionHebField;
        private System.Windows.Forms.TextBox professionEngField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
    }
}