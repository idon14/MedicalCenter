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
    public partial class FormRptDoctorsByCity : Form
    {
        private OleDbConnection dataConnection;
        private string id;
        private string firstName;
        private string lastName;
        private string license;
        private string profession;
        private string address;
        private string city;
        private string phone;
        private string mobile;
        private string email;
        private string saveColor = "";
        public FormRptDoctorsByCity(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();
        }

        private void FillCityCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDoctorDetails(int counter)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   doctorProfession, doctorLicense " +
                                          "FROM     tblDoctors   " +
                                          "WHERE    doctorID = " + id + " " +
                                          "ORDER BY doctorID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    profession = dataReader.GetString(0);
                    license = dataReader.GetInt32(1).ToString();
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[10];
                arr[0] = id;
                arr[1] = firstName;
                arr[2] = lastName;
                arr[3] = license;
                arr[4] = profession;
                arr[5] = address;
                if (counter == 1)
                    arr[6] = city;
                arr[7] = phone;
                arr[8] = mobile;
                arr[9] = email;
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

        private void ShowClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userID, userFirstName, userLastName, userAddress, userCity, userPhone, userMobile, userEmail " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userCity = \'" + cityCombo.Text + "\' " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0).ToString();
                    firstName = dataReader.GetString(1);
                    lastName = dataReader.GetString(2);
                    address = dataReader.GetString(3);
                    city = dataReader.GetString(4);
                    phone = dataReader.GetString(5);
                    mobile = dataReader.GetString(6);
                    email = dataReader.GetString(7);
                    counter++;
                    GetDoctorDetails(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
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
