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
    public partial class FormChartDoctorsByDegree : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrDegrees;
        private int[] arrDoctors;
        public FormChartDoctorsByDegree(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountDegrees();
            arrDegrees = new string[counter];
            arrDoctors = new int[counter];
            FillArrDegrees();
            FillArrDoctors();
            ShowChart();
            EditDataGridView();
        }

        private void CountDegrees()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblDegrees  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblProfessions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrDegrees()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   degreeName " +
                                          "FROM     tblDegrees  " +
                                          "ORDER BY degreeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrDegrees[i] = dataReader.GetString(0);
                    i++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDegrees failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrDoctors()
        {
            for (int i = 0; i < arrDegrees.Length; i++)
                CountDoctors(i);
        }

        private void CountDoctors(int i)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  doctorID " +
                                          "FROM    tblDoctors  " +
                                          "WHERE   doctorDegree = \'" + arrDegrees[i] + "\' ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrDoctors[i]++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(1, 3);
                chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                for (int i = 0; i < arrDegrees.Length; i++)
                    chart1.Series["רופאים"].Points.AddXY(arrDegrees[i], arrDoctors[i]);
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
                for (int i = 0; i < arrDegrees.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = arrDegrees[i];
                    row.Cells[1].Value = arrDoctors[i].ToString();
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
