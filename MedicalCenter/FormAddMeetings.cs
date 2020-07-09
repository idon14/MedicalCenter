using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class FormAddMeetings : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        public FormAddMeetings(OleDbConnection dataConnection, Boolean isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;

            timeField.Format = DateTimePickerFormat.Time;
            timeField.ShowUpDown = true;

            fillMemberIdCombo();
            fillDoctorIdCombo();

            if (!isAdmin)
                addButton.Enabled = false;
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

        private void FormAddMeetings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMeetings.tblMeetings' table. You can move, or remove it, as needed.
            this.tblMeetingsTableAdapter.Fill(this.dataSetMeetings.tblMeetings);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (CheckHour())
            {
                try
                {
                    OleDbCommand dataCommand = new OleDbCommand();
                    dataCommand.Connection = dataConnection;
                    string str = string.Format
                                        ("INSERT INTO tblMeetings " +
                                         "(meetingMemberID, meetingDoctorID, meetingDate, meetingHour, meetingOrderDate, meetingCancelled, meetingOccurred) " +
                                         " VALUES ( {0}, {1}, \"{2}\", \"{3}\", \"{4}\", {5}, {6})",
                                           memberIdCombo.Text, doctorIdCombo.Text, dateField.Value.ToString("dd/MM/yyyy"), timeField.Value.ToString("HH:mm"), dateOrderField.Value.ToString("dd/MM/yyyy"), cancelledChkbox.Checked, occurredChkbox.Checked);
                    dataCommand.CommandText = str;
                    dataCommand.ExecuteNonQuery();
                    MessageBox.Show("Insert into tblMeetings ended successfully");
                    RefreshDataGridView();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Insert into tblMeetings failed \n" + err.Message + "\n", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("הרופא לא פנוי בזמן המבוקש", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckHour()
        {
            int day = ((int) dateField.Value.DayOfWeek) + 1;

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
                    TimeSpan req = timeField.Value.TimeOfDay;

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
                    TimeSpan req = timeField.Value.TimeOfDay;

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
    }
}
