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
    public partial class FormAddCities : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddCities(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            if (!isAdmin)
                addButton.Enabled = false;
        }

        private void FormAddCities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblCities " +
                                     "(cityName) " +
                                     " VALUES ( \"{0}\")",
                                       cityField.Text);
                dataCommand.CommandText = str;
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblCities ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblCities failed \n" + err.Message + "\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblCities " +
                                     "ORDER BY cityName";
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
