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
    public partial class FormAddReceptions : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddReceptions(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            firstFromField.Format = DateTimePickerFormat.Time;
            firstFromField.ShowUpDown = true;
            firstUntilField.Format = DateTimePickerFormat.Time;
            firstUntilField.ShowUpDown = true;
            secondFromField.Format = DateTimePickerFormat.Time;
            secondFromField.ShowUpDown = true;
            secondUntilField.Format = DateTimePickerFormat.Time;
            secondUntilField.ShowUpDown = true;

            fillIdCombo();
            fillDayCombo();
            fillFirstClinicCombo();
            fillSecondClinicCombo();

            if (!isAdmin)
                addButton.Enabled = false;
        }

        private void fillIdCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT doctorID " +
                                          "FROM tblDoctors " +
                                          "ORDER BY doctorID";
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

        private void fillDayCombo()
        {
            dayCombo.Items.Add("ראשון");
            dayCombo.Items.Add("שני");
            dayCombo.Items.Add("שלישי");
            dayCombo.Items.Add("רביעי");
            dayCombo.Items.Add("חמישי");
            dayCombo.Items.Add("שישי");
            dayCombo.Items.Add("שבת");
        }

        private void fillFirstClinicCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT clinicName " +
                                          "FROM tblClinics " +
                                          "ORDER BY clinicName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstClinicCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill first clinics combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillSecondClinicCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT clinicName " +
                                          "FROM tblClinics " +
                                          "ORDER BY clinicName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    secondClinicCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill second clinics combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddReceptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReceptions.tblReceptions' table. You can move, or remove it, as needed.
            this.tblReceptionsTableAdapter.Fill(this.dataSetReceptions.tblReceptions);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblReceptions " +
                                     "(recepDoctorID, recepDayInWeek, recepFromHour1, recepToHour1, recepClinic1, recepFromHour2, recepToHour2, recepClinic2, recepMinutes) " +
                                     " VALUES ( {0}, {1}, \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", {8})",
                                       idCombo.Text, dayCombo.SelectedIndex + 1, firstFromField.Value.ToString("HH:mm"), firstUntilField.Value.ToString("HH:mm"), firstClinicCombo.Text, secondFromField.Value.ToString("HH:mm"), secondUntilField.Value.ToString("HH:mm"), secondClinicCombo.Text, minutesField.Text);
                dataCommand.CommandText = str;
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblReceptions ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblReceptions failed \n" + err.Message + "\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblReceptions " +
                                     "ORDER BY recepID";
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
