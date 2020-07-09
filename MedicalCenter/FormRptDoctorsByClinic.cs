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
    public partial class FormRptDoctorsByClinic : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private string lastId = "";
        private string name;
        private string id;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string phone;
        private string mobile;
        private string email;
        private string saveColor = "";
        public FormRptDoctorsByClinic(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
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

        private void FirstClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            GetReceptionsDetails();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            GetReceptionsDetails();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            GetReceptionsDetails();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            GetReceptionsDetails();
        }

        private void EnableButtons()
        {
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                prevButton.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            GetReceptionsDetails();
        }

        private void FormRptDoctorsByClinic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinics.tblClinics' table. You can move, or remove it, as needed.
            this.tblClinicsTableAdapter.Fill(this.dataSetClinics.tblClinics);

        }

        private void GetReceptionsDetails()
        {
            EnableButtons();
            name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   recepDoctorID " +
                                          "FROM     tblReceptions   " +
                                          "WHERE    (recepClinic1 = \'" + name + "\' OR recepClinic2 = \'" + name + "\') " +
                                          "ORDER BY recepDoctorID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    lastId = id;
                    id = dataReader.GetInt32(0).ToString();
                    if (!id.Equals(lastId))
                    {
                        counter++;
                        GetDoctorDetails(counter);
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDoctorDetails(int counter)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userAddress, userCity, userPhone, userMobile, userEmail " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + id + " " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstName = dataReader.GetString(0);
                    lastName = dataReader.GetString(1);
                    address = dataReader.GetString(2);
                    city = dataReader.GetString(3);
                    phone = dataReader.GetString(4);
                    mobile = dataReader.GetString(5);
                    email = dataReader.GetString(6);
                    FillListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillListView(int counter)
        {
            try
            {
                string[] arr = new string[9];
                if (counter == 1)
                {
                    arr[0] = name;
                }
                arr[1] = id;
                arr[2] = firstName;
                arr[3] = lastName;
                arr[4] = address;
                arr[5] = city;
                arr[6] = phone;
                arr[7] = mobile;
                arr[8] = email;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            colorButton.BackColor = cd.Color;
            saveColor = colorButton.BackColor.ToArgb().ToString();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
