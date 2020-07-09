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
    public partial class FormUpdateMeetings : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateMeetings(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;

            hourField.Format = DateTimePickerFormat.Time;
            hourField.ShowUpDown = true;

            if (!isManager)
                updateButton.Enabled = false;

            fillMemberIdCombo();
            fillDoctorIdCombo();
            RefreshDataGridView();
        }

        private void fillMemberIdCombo()
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
                    memberIdCombo.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill member ids combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillDoctorIdCombo()
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
                    doctorIdCombo.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill doctor ids combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUpdateMeetings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMeetings.tblMeetings' table. You can move, or remove it, as needed.
            this.tblMeetingsTableAdapter.Fill(this.dataSetMeetings.tblMeetings);

        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblMeetings " +
                                     "ORDER BY meetingID";
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
            if (CheckHour() || !cancelledChkbox.Checked)
            {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "UPDATE tblMeetings  \n" +
                                              "SET    meetingMemberID   =  " + memberIdCombo.Text + " , \n" +
                                                      "meetingDoctorID  =  " + doctorIdCombo.Text + " , \n" +
                                                      "meetingDate      =  \"" + dateField.Value.ToString("dd/MM/yyyy") + "\" , \n" +
                                                      "meetingHour      =  \"" + hourField.Value.ToString("HH:mm") + "\" , \n" +
                                                      "meetingOrderDate =  \"" + orderDateField.Value.ToString("dd/MM/yyyy") + "\" , \n" +
                                                      "meetingCancelled =  " + cancelledChkbox.Checked + " , \n" +
                                                      "meetingOccurred  =  " + occurredChkbox.Checked + " \n" +
                                              "WHERE  meetingID = " + numField.Text;
                    datacommand.ExecuteNonQuery();
                    RefreshDataGridView();
                    dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                    MessageBox.Show("Update tblMeetings ended successfluly");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Update tblMeetings failed \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("הרופא לא פנוי בזמן המבוקש", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckHour()
        {
            int day = ((int)dateField.Value.DayOfWeek) + 1;

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;
                command.CommandText = string.Format
                                    ("SELECT recepFromHour1, recepToHour1, recepFromHour2, recepToHour2, recepMinutes " +
                                    "FROM tblReceptions " +
                                    "WHERE (recepDoctorID = " + doctorIdCombo.Text + ") " +
                                    "AND (recepDayInWeek = " + day.ToString() + ") " +
                                    "ORDER BY recepFromHour1");
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    TimeSpan start1 = new TimeSpan(dataReader.GetDateTime(0).Hour, dataReader.GetDateTime(0).Minute, 0);
                    TimeSpan end1 = new TimeSpan(dataReader.GetDateTime(1).Hour, dataReader.GetDateTime(1).Minute, 0);
                    TimeSpan start2 = new TimeSpan(dataReader.GetDateTime(2).Hour, dataReader.GetDateTime(2).Minute, 0);
                    TimeSpan end2 = new TimeSpan(dataReader.GetDateTime(3).Hour, dataReader.GetDateTime(3).Minute, 0);
                    TimeSpan req = hourField.Value.TimeOfDay;

                    if ((req >= start1) && (req.Add(new TimeSpan(0, dataReader.GetInt32(4), 0)) <= end1))
                    {
                        if (CheckMeetings(dataReader.GetInt32(4)))
                            return true;
                    }
                    else if ((req >= start2) && (req.Add(new TimeSpan(0, dataReader.GetInt32(4), 0)) <= end2))
                    {
                        if (CheckMeetings(dataReader.GetInt32(4)))
                            return true;
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Select from tblReceptions failed \n" + err.Message + "\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private bool CheckMeetings(int minutes)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;
                command.CommandText = string.Format
                                    ("SELECT meetingHour, meetingCancelled " +
                                    "FROM tblMeetings " +
                                    "WHERE (meetingDoctorID = " + doctorIdCombo.Text + ") " +
                                    "AND (meetingDate = #" + dateField.Value.ToString("dd/MM/yyyy") + "#) " +
                                    "ORDER BY meetingHour");
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    TimeSpan start = new TimeSpan(dataReader.GetDateTime(0).Hour, dataReader.GetDateTime(0).Minute, 0);
                    TimeSpan end = start.Add(new TimeSpan(0, minutes, 0));
                    TimeSpan req = hourField.Value.TimeOfDay;

                    if (!dataReader.GetBoolean(1))
                        if ((start <= req) && (req < end))
                            return false;
                }
                dataReader.Close();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Select from tblReceptions failed \n" + err.Message + "\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void FillSelectedRow()
        {
            try
            {
                numField.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                memberIdCombo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                doctorIdCombo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateField.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                hourField.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                orderDateField.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                cancelledChkbox.Checked = dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "True";
                occurredChkbox.Checked = dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "True";
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
