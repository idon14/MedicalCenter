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
    public partial class FormChartPatientsByClinic : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrClinics;
        private int[] arrPatients;
        private string lastId;
        private string id;
        public FormChartPatientsByClinic(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountClinics();
            arrClinics = new string[counter];
            arrPatients = new int[counter];
            FillArrClinics();
            FillArrPatients();
            ShowChart();
            EditDataGridView();
        }

        private void CountClinics()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblClinics  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblClinics failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrClinics()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   clinicName " +
                                          "FROM     tblClinics  " +
                                          "ORDER BY clinicName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrClinics[i] = dataReader.GetString(0);
                    i++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblClinics failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrPatients()
        {
            for (int i = 0; i < arrClinics.Length; i++)
                GetMeetingsDetails(i);
        }

        private void GetMeetingsDetails(int i)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   meetingMemberID, meetingDoctorID, meetingDate, meetingHour " +
                                          "FROM     tblMeetings   " +
                                          "ORDER BY meetingMemberID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    lastId = id;
                    id = dataReader.GetInt32(0).ToString();
                    if (!id.Equals(lastId))
                    {
                        int result = GetReceptionsDetails(dataReader.GetInt32(1).ToString(), ((int)(dataReader.GetDateTime(2).DayOfWeek + 1)).ToString(), dataReader.GetDateTime(3));
                        if (result > -1)
                            arrPatients[result]++;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblMeetings failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetReceptionsDetails(string doctorId, string dayInWeek, DateTime meetingHour)
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
                    if (dataReader.GetDateTime(0) <= meetingHour && dataReader.GetDateTime(1) >= meetingHour)
                        for (int i = 0; i < arrClinics.Length; i++)
                            if (arrClinics[i] == dataReader.GetString(2))
                                return i;
                    else if (dataReader.GetDateTime(3) <= meetingHour && dataReader.GetDateTime(4) >= meetingHour)
                        for (int j = 0; j < arrClinics.Length; j++)
                            if (arrClinics[j] == dataReader.GetString(5))
                                return j;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 8);
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < arrClinics.Length; i++)
                    chart1.Series["מטופלים"].Points.AddXY(arrClinics[i], arrPatients[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDataGridView()
        {
            try
            {
                for (int i = 0; i < arrPatients.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = arrClinics[i];
                    row.Cells[1].Value = arrPatients[i].ToString();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
