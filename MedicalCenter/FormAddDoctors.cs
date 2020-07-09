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
    public partial class FormAddDoctors : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddDoctors(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            fillIdCombo();
            fillDegreeCombo();
            fillProfessionCombo();
            if (!isAdmin)
                addButton.Enabled = false;
        }

        private void fillIdCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT userID " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    idCombo.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill ids combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillDegreeCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT degreeName " +
                                          "FROM tblDegrees " +
                                          "ORDER BY degreeName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    degreeCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill degrees combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillProfessionCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT professionHeb " +
                                          "FROM tblProfessions " +
                                          "ORDER BY professionHeb";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    professionCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill professions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDoctors.tblDoctors' table. You can move, or remove it, as needed.
            this.tblDoctorsTableAdapter.Fill(this.dataSetDoctors.tblDoctors);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblDoctors " +
                                     "(doctorID, doctorDegree, doctorProfession, doctorLicense) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", {3})",
                                       idCombo.Text, degreeCombo.Text, professionCombo.Text, licenseField.Text);
                dataCommand.CommandText = str;
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblDoctors ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblDoctors failed \n" + err.Message + "\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblDoctors " +
                                     "ORDER BY doctorNum";
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
