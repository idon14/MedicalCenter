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
    public partial class FormRptReceptionsOfDoctor : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private string id;
        private string firstName;
        private string lastName;
        private string dayInWeek;
        private string from1;
        private string to1;
        private string clinic1;
        private string from2;
        private string to2;
        private string clinic2;
        private string minutes;
        private string saveColor = "";
        public FormRptReceptionsOfDoctor(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormRptReceptionsOfDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDoctors.tblDoctors' table. You can move, or remove it, as needed.
            this.tblDoctorsTableAdapter.Fill(this.dataSetDoctors.tblDoctors);

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

        private void FirstClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            GetDoctorDetails();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            GetDoctorDetails();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            GetDoctorDetails();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            GetDoctorDetails();
        }

        private void GetDoctorDetails()
        {
            EnableButtons();
            id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userPicture " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + id + " " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstName = dataReader.GetString(0);
                    lastName = dataReader.GetString(1);
                    doctorPicture.ImageLocation = dataReader.GetString(2);
                    GetReceptionsDetails();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetReceptionsDetails()
        {
            string[] days = new string[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת" };
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   recepDayInWeek, recepFromHour1, recepToHour1, recepClinic1, recepFromHour2, recepToHour2, recepClinic2, recepMinutes " +
                                          "FROM     tblReceptions   " +
                                          "WHERE    recepDoctorID = " + id + " " +
                                          "ORDER BY recepDayInWeek";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    dayInWeek = days[dataReader.GetInt32(0) - 1];
                    from1 = dataReader.GetDateTime(1).ToString("HH:mm");
                    to1 = dataReader.GetDateTime(2).ToString("HH:mm");
                    clinic1 = dataReader.GetString(3);
                    from2 = dataReader.GetDateTime(4).ToString("HH:mm");
                    to2 = dataReader.GetDateTime(5).ToString("HH:mm");
                    clinic2 = dataReader.GetString(6);
                    minutes = dataReader.GetInt32(7).ToString();
                    counter++;
                    FillListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillListView(int counter)
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                {
                    arr[0] = firstName;
                    arr[1] = lastName;
                }
                arr[2] = dayInWeek;
                arr[3] = from1;
                arr[4] = to1;
                arr[5] = clinic1;
                arr[6] = from2;
                arr[7] = to2;
                arr[8] = clinic2;
                arr[9] = minutes;
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
            GetDoctorDetails();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            colorButton.BackColor = cd.Color;
            saveColor = colorButton.BackColor.ToArgb().ToString();
        }
    }
}
