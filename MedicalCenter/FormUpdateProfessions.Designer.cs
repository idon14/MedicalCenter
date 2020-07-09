namespace MedicalCenter
{
    partial class FormUpdateProfessions
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
            this.hebField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.engField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 389);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
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
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "עדכון פרטי התמחות";
            // 
            // hebField
            // 
            this.hebField.Enabled = false;
            this.hebField.Location = new System.Drawing.Point(449, 63);
            this.hebField.Name = "hebField";
            this.hebField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hebField.Size = new System.Drawing.Size(300, 20);
            this.hebField.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "התמחות עברית";
            // 
            // engField
            // 
            this.engField.Location = new System.Drawing.Point(449, 103);
            this.engField.Name = "engField";
            this.engField.Size = new System.Drawing.Size(300, 20);
            this.engField.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "התמחות אנגלית";
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(661, 144);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(62, 33);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "הקודם";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousClick);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(744, 144);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(62, 33);
            this.firstButton.TabIndex = 2;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(548, 144);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(62, 33);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(466, 144);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(62, 33);
            this.lastButton.TabIndex = 5;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateButton.Location = new System.Drawing.Point(604, 198);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 43);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "עדכון";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton);
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
            // FormUpdateProfessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.engField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hebField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUpdateProfessions";
            this.Text = "FormUpdateProfessions";
            this.Load += new System.EventHandler(this.FormUpdateProfessions_Load);
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
        private System.Windows.Forms.TextBox hebField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox engField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label4;
    }
}