using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class FormAddProfessions : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddProfessions(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            if (!isAdmin)
                addButton.Enabled = false;
        }

        private void FormAddProfessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProfessions.tblProfessions' table. You can move, or remove it, as needed.
            this.tblProfessionsTableAdapter.Fill(this.dataSetProfessions.tblProfessions);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblProfessions " +
                                     "(professionHeb, professionEng) " +
                                     " VALUES ( \"{0}\", \"{1}\")",
                                       professionHebField.Text, professionEngField.Text);
                dataCommand.CommandText = str;
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblProfessions ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblProfessions failed \n" + err.Message + "\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblProfessions " +
                                     "ORDER BY professionHeb";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
