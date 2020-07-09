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
    public partial class FormChartPatientsByCity : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrCities;
        private int[] arrPatients;
        private string fromDate;
        private string toDate;
        public FormChartPatientsByCity(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountCities();
            arrCities = new string[counter];
            arrPatients = new int[counter];
            FillArrCities();
        }

        private void CountCities()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblCities  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblCities failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrCities()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cityName " +
                                          "FROM     tblCities  " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrCities[i] = dataReader.GetString(0);
                    i++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblCities failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowClick(object sender, EventArgs e)
        {
            chart1.Series["מטופלים"].Points.Clear();
            dataGridView1.Rows.Clear();
            arrPatients = new int[counter];

            fromDate = fromDatePicker.Value.ToString("dd/MM/yyyy");
            toDate = toDatePicker.Value.ToString("dd/MM/yyyy");

            for (int i = 0; i < arrCities.Length; i++)
                GetUserDetails(i);

            ShowChart();
            EditDataGridView();
        }

        private void GetUserDetails(int i)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userID " +
                                          "FROM     tblUsers  " +
                                          "WHERE    userCity = \"" + arrCities[i] + "\" " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (GetUserMeetings(dataReader.GetInt32(0).ToString()))
                        arrPatients[i]++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetUserMeetings(string id)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   meetingMemberID " +
                                          "FROM     tblMeetings  " +
                                          "WHERE    (meetingMemberID = " + id + ") " +
                                          "AND      (meetingDate BETWEEN #" + fromDate + "# AND #" + toDate + "#) " +
                                          "ORDER BY meetingMemberID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    return true;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblMeetings failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
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

                for (int i = 0; i < arrCities.Length; i++)
                    chart1.Series["מטופלים"].Points.AddXY(arrCities[i], arrPatients[i]);
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
                    row.Cells[0].Value = arrCities[i];
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
