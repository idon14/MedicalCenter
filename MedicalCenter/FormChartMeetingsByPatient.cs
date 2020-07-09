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
    public partial class FormChartMeetingsByPatient : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrPatients;
        private string[] arrPatientsIds;
        private int[] arrMeetings;
        private string fromDate;
        private string toDate;
        public FormChartMeetingsByPatient(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountPatients();
            arrPatients = new string[counter];
            arrPatientsIds = new string[counter];
            arrMeetings = new int[counter];
            FillArrPatients();
        }

        private void CountPatients()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblUsers  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrPatients()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userID, userFirstName, userLastName " +
                                          "FROM     tblUsers  " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrPatientsIds[i] = dataReader.GetInt32(0).ToString();
                    arrPatients[i] = dataReader.GetString(1) + " " + dataReader.GetString(2);
                    i++;
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

            for (int i = 0; i < arrPatients.Length; i++)
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
                                          "AND      (meetingMemberID = " + arrPatientsIds[i] + ") " +
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

                for (int i = 0; i < arrPatients.Length; i++)
                    chart1.Series["תורים"].Points.AddXY(arrPatients[i], arrMeetings[i]);
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
                    row.Cells[0].Value = arrPatients[i];
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
