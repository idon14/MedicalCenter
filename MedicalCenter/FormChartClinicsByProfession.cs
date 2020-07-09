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
    public partial class FormChartClinicsByProfession : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrProfessions;
        private int[] arrClinics;
        private string[] arrClinicsNames;
        public FormChartClinicsByProfession(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountProfessions();
            arrProfessions = new string[counter];
            arrClinics = new int[counter];
            arrClinicsNames = new string[counter];
            FillArrProfessions();
            FillArrClinicsNames();
            FillArrClinics();
            ShowChart();
            EditDataGridView();
        }

        private void CountProfessions()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblProfessions  ";
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

        private void FillArrProfessions()
        {
            try
            {
                int i = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   professionHeb " +
                                          "FROM     tblProfessions  " +
                                          "ORDER BY professionHeb";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrProfessions[i] = dataReader.GetString(0);
                    i++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblProfessions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrClinicsNames()
        {
            for (int i = 0; i < arrClinicsNames.Length; i++)
                arrClinicsNames[i] = "";
        }

        private void FillArrClinics()
        {
            for (int i = 0; i < arrProfessions.Length; i++)
                GetDoctorDetails(i);
        }

        private void GetDoctorDetails(int i)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   doctorID " +
                                          "FROM     tblDoctors   " +
                                          "WHERE    doctorProfession = \'" + arrProfessions[i] + "\' " +
                                          "ORDER BY doctorNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    GetReceptionsDetails(i, dataReader.GetInt32(0).ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetReceptionsDetails(int i, string doctorId)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   recepClinic1, recepClinic2 " +
                                          "FROM     tblReceptions   " +
                                          "WHERE    recepDoctorID = " + doctorId + " " +
                                          "ORDER BY recepID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (!arrClinicsNames[i].Contains(dataReader.GetString(0)))
                    {
                        arrClinicsNames[i] += dataReader.GetString(0) + ", ";
                        arrClinics[i]++;
                    }
                    if (!arrClinicsNames[i].Contains(dataReader.GetString(1)))
                    {
                        arrClinicsNames[i] += dataReader.GetString(1) + ", ";
                        arrClinics[i]++;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                for (int i = 0; i < arrProfessions.Length; i++)
                    chart1.Series["מרפאות"].Points.AddXY(arrProfessions[i], arrClinics[i]);
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
                for (int i = 0; i < arrProfessions.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = arrProfessions[i];
                    row.Cells[1].Value = arrClinics[i].ToString();
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
