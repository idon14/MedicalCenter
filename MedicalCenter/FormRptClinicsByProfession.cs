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
    public partial class FormRptClinicsByProfession : Form
    {
        private OleDbConnection dataConnection;
        private string profession;
        private string name;
        private string address;
        private string city;
        private string phone;
        private string saveColor = "";
        private HashSet<string> clinicsSet;
        public FormRptClinicsByProfession(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillProfessionsCombo();
        }

        private void FillProfessionsCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT professionHeb " +
                                          "FROM tblProfessions " +
                                          "ORDER BY professionHeb";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    professionCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill professions combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfessionClick(object sender, EventArgs e)
        {
            profession = professionCombo.Text;
            clinicsSet = new HashSet<string>();
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   doctorID " +
                                          "FROM     tblDoctors   " +
                                          "WHERE    doctorProfession = \'" + profession + "\' " +
                                          "ORDER BY doctorNum";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    GetReceptionsDetails(dataReader.GetInt32(0).ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetReceptionsDetails(string doctorId)
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
                int counter = 0;
                while (dataReader.Read())
                {
                    if (!clinicsSet.Contains(dataReader.GetString(0)))
                    {
                        counter++;
                        clinicsSet.Add(dataReader.GetString(0));
                        GetClinicDetails(counter, dataReader.GetString(0));
                    }
                    if (!clinicsSet.Contains(dataReader.GetString(1)))
                    {
                        counter++;
                        clinicsSet.Add(dataReader.GetString(1));
                        GetClinicDetails(counter, dataReader.GetString(1));
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblReceptions failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetClinicDetails(int counter, string clinic)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   clinicName, clinicAddress, clinicCity, clinicPhone " +
                                          "FROM     tblClinics   " +
                                          "WHERE    clinicName = \'" + clinic + "\' " +
                                          "ORDER BY clinicName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    name = dataReader.GetString(0);
                    address = dataReader.GetString(1);
                    city = dataReader.GetString(2);
                    phone = dataReader.GetString(3);
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblClinics failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[5];
                if (counter == 1)
                    arr[0] = profession;
                arr[1] = name;
                arr[2] = address;
                arr[3] = city;
                arr[4] = phone;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            colorButton.BackColor = cd.Color;
            saveColor = colorButton.BackColor.ToArgb().ToString();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
