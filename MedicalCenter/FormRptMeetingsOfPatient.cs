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
    public partial class FormRptMeetingsOfPatient : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private string id;
        private string firstName;
        private string lastName;
        private string doctorId;
        private string doctorName;
        private string date;
        private string time;
        private string orderDate;
        private string cancelled;
        private string occurred;
        private string saveColor = "";
        public FormRptMeetingsOfPatient(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormRptMeetingsOfPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
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
            GetUserDetails();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            GetUserDetails();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            GetUserDetails();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            GetUserDetails();
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
            GetUserDetails();
        }

        private void GetUserDetails()
        {
            EnableButtons();
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userPicture " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + id + " ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstName = dataReader.GetString(0);
                    lastName = dataReader.GetString(1);
                    if (!dataReader.IsDBNull(2))
                        userPicture.ImageLocation = dataReader.GetString(2);
                    GetMeetingsDetails();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMeetingsDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   meetingDoctorID, meetingDate, meetingHour, meetingOrderDate, meetingCancelled, meetingOccurred " +
                                          "FROM     tblMeetings   " +
                                          "WHERE    meetingMemberID = " + id + " " +
                                          "ORDER BY meetingDate";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    doctorId = dataReader.GetInt32(0).ToString();
                    date = dataReader.GetDateTime(1).ToString("dd/MM/yyyy");
                    time = dataReader.GetDateTime(2).ToString("HH:mm");
                    orderDate = dataReader.GetDateTime(3).ToString("dd/MM/yyyy");
                    cancelled = dataReader.GetBoolean(4) ? "כן" : "לא";
                    occurred = dataReader.GetBoolean(5) ? "כן" : "לא";
                    counter++;
                    GetDoctorDetails(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblMeetings failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDoctorDetails(int counter)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + doctorId + " " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    doctorName = dataReader.GetString(0) + " " + dataReader.GetString(1);
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
                string[] arr = new string[8];
                if (counter == 1)
                {
                    arr[0] = firstName;
                    arr[1] = lastName;
                }
                arr[2] = doctorName;
                arr[3] = date;
                arr[4] = time;
                arr[5] = orderDate;
                arr[6] = cancelled;
                arr[7] = occurred;
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
