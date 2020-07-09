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
    public partial class FormChartMeetingsByDoctor : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrDoctors;
        private string[] arrDoctorsIds;
        private int[] arrMeetings;
        private string fromDate;
        private string toDate;
        public FormChartMeetingsByDoctor(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountDoctors();
            arrDoctors = new string[counter];
            arrDoctorsIds = new string[counter];
            arrMeetings = new int[counter];
            FillArrDoctors();
        }

        private void CountDoctors()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblDoctors  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrDoctors()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   doctorID " +
                                          "FROM     tblDoctors  " +
                                          "ORDER BY doctorNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrDoctorsIds[i] = dataReader.GetInt32(0).ToString();
                    GetUserDetails(i, arrDoctorsIds[i]);
                    i++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUserDetails(int i, string id)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName " +
                                          "FROM     tblUsers  " +
                                          "WHERE    userID = " + id + " " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrDoctors[i] = dataReader.GetString(0) + " " + dataReader.GetString(1);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowClick(object sender, EventArgs e)
        {
            chart1.Series["תורים"].Points.Clear();
            dataGridView1.Rows.Clear();
            arrMeetings = new int[counter];

            fromDate = fromDatePicker.Value.ToString("dd/MM/yyyy");
            toDate = toDatePicker.Value.ToString("dd/MM/yyyy");

            for (int i = 0; i < arrDoctors.Length; i++)
                GetUserMeetings(i);

            ShowChart();
            EditDataGridView();
        }

        private void GetUserMeetings(int i)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   meetingMemberID " +
                                          "FROM     tblMeetings  " +
                                          "WHERE    (meetingDate BETWEEN #" + fromDate + "# AND #" + toDate + "#) " +
                                          "AND      (meetingDoctorID = " + arrDoctorsIds[i] + ") " +
                                          "ORDER BY meetingID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrMeetings[i]++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblMeetings failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 22);
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < arrDoctors.Length; i++)
                    chart1.Series["תורים"].Points.AddXY(arrDoctors[i], arrMeetings[i]);
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
                for (int i = 0; i < arrDoctors.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = arrDoctors[i];
                    row.Cells[1].Value = arrMeetings[i].ToString();
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
