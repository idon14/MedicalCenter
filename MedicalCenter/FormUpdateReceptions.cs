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
    public partial class FormUpdateReceptions : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        private int lastRow = 0;
        public FormUpdateReceptions(OleDbConnection dataConnection, Boolean isAdmin)
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

            if (!isAdmin)
                updateButton.Enabled = false;

            fillIdCombo();
            fillDayCombo();
            fillFirstClinicCombo();
            fillSecondClinicCombo();
            RefreshDataGridView();
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

        private void FormUpdateReceptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReceptions.tblReceptions' table. You can move, or remove it, as needed.
            this.tblReceptionsTableAdapter.Fill(this.dataSetReceptions.tblReceptions);

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

        private void UpdateClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblReceptions  \n" +
                                          "SET    recepDoctorID   =  " + idCombo.Text + " , \n" +
                                                  "recepDayInWeek  =  " + dayCombo.Text + " , \n" +
                                                  "recepFromHour1      =  \"" + firstFromField.Value.ToString("HH:mm") + "\" , \n" +
                                                  "recepToHour1      =  \"" + firstUntilField.Value.ToString("HH:mm") + "\" , \n" +
                                                  "recepClinic1 =  \"" + firstClinicCombo.Text + "\" , \n" +
                                                  "recepFromHour2 =  \"" + secondFromField.Value.ToString("HH:mm") + "\" , \n" +
                                                  "recepToHour2  =  \"" + secondUntilField.Value.ToString("HH:mm") + "\" , \n" +
                                                  "recepClinic2  =  \"" + secondClinicCombo.Text + "\" , \n" +
                                                  "recepMinutes  =  " + minutesField.Text + " \n" +
                                          "WHERE  recepID = " + numField.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblReceptions ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblReceptions failed \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSelectedRow()
        {
            try
            {
                numField.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                idCombo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dayCombo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                firstFromField.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                firstUntilField.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                firstClinicCombo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                secondFromField.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                secondUntilField.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                secondClinicCombo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                minutesField.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableButtons()
        {
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                previousButton.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            FillSelectedRow();
        }

        private void FirstClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void PreviousClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
    }
}
