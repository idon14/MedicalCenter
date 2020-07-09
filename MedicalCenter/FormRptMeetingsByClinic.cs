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
    public partial class FormRptMeetingsByClinic : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private string lastId = "";
        private string name;
        private string fromDateStr;
        private string toDateStr;
        private string id;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string phone;
        private string mobile;
        private string email;
        private string saveColor = "";
        public FormRptMeetingsByClinic(OleDbConnection dataConnection)
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
            EnableButtons();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
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
            EnableButtons();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            fromDateStr = fromDate.Value.ToString("dd/MM/yyyy");
            toDateStr = toDate.Value.ToString("dd/MM/yyyy");
            EnableButtons();
            name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   meetingMemberID, meetingDoctorID, meetingDate, meetingHour " +
                                          "FROM     tblMeetings   " +
                                          "WHERE    (meetingDate BETWEEN #" + fromDateStr + "# AND #" + toDateStr + "#) " +
                                          "ORDER BY meetingMemberID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    lastId = id;
                    id = dataReader.GetInt32(0).ToString();
                    if (!id.Equals(lastId))
                        if (GetReceptionsDetails(dataReader.GetInt32(1).ToString(), ((int) (dataReader.GetDateTime(2).DayOfWeek + 1)).ToString(), dataReader.GetDateTime(3)))
                        {
                            counter++;
                            GetUserDetails(counter);
                        }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblMeetings failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetReceptionsDetails(string doctorId, string dayInWeek, DateTime meetingHour)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   recepFromHour1, recepToHour1, recepClinic1, recepFromHour2, recepToHour2, recepClinic2 " +
                                          "FROM     tblReceptions   " +
                                          "WHERE    (recepDoctorID = " + doctorId + ") " +
                                          "AND      (recepDayInWeek = " + dayInWeek + ") ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (name.Equals(dataReader.GetString(2)) && dataReader.GetDateTime(0) <= meetingHour && dataReader.GetDateTime(1) >= meetingHour)
                    {
                        return true;
                    }
                    else if (name.Equals(dataReader.GetString(5)) && dataReader.GetDateTime(3) <= meetingHour && dataReader.GetDateTime(4) >= meetingHour)
                    {
                        return true;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void GetUserDetails(int counter)
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
                string[] arr = new string[11];
                if (counter == 1)
                {
                    arr[0] = name;
                    arr[1] = fromDateStr;
                    arr[2] = toDateStr;
                }
                arr[3] = id;
                arr[4] = firstName;
                arr[5] = lastName;
                arr[6] = address;
                arr[7] = city;
                arr[8] = phone;
                arr[9] = mobile;
                arr[10] = email;
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

        private void FormRptMeetingsByClinic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinics.tblClinics' table. You can move, or remove it, as needed.
            this.tblClinicsTableAdapter.Fill(this.dataSetClinics.tblClinics);

        }

        private void ClearClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            colorButton.BackColor = cd.Color;
            saveColor = colorButton.BackColor.ToArgb().ToString();
        }
    }
}
