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
    public partial class FormAddClinics : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddClinics(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            fillCityCombo();
            if (!isAdmin)
                addButton.Enabled = false;
        }

        private void fillCityCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddClinics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinics.tblClinics' table. You can move, or remove it, as needed.
            this.tblClinicsTableAdapter.Fill(this.dataSetClinics.tblClinics);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblClinics " +
                                     "(clinicName, clinicAddress, clinicCity, clinicPhone, clinicPicture) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\")",
                                       nameField.Text, addressField.Text, cityCombo.Text, phoneField.Text, pictureField.Text);
                dataCommand.CommandText = str;
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblClinics ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblClinics failed \n" + err.Message + "\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblClinics " +
                                     "ORDER BY clinicName";
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

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureField.Text = pictureFileName;
        }
    }
}
