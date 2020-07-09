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
    public partial class FormRptDoctorsByDegree : Form
    {
        private OleDbConnection dataConnection;
        private string id;
        private string firstName;
        private string lastName;
        private string degree;
        private string license;
        private string profession;
        private string address;
        private string city;
        private string phone;
        private string mobile;
        private string email;
        private string saveColor = "";
        public FormRptDoctorsByDegree(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillDegreeCombo();
        }

        private void FillDegreeCombo()
        {
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT degreeName " +
                                          "FROM tblDegrees " +
                                          "ORDER BY degreeName";
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    degreeCombo.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill degrees combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUserDetails(int counter)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userAddress, userCity, userPhone, userMobile, userEmail " +
                                          "FROM     tblUsers   " +
                                          "WHERE    userID = " + id + " " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstName = dataReader.GetString(0);
                    lastName = dataReader.GetString(1);
                    address = dataReader.GetString(2);
                    city = dataReader.GetString(3);
                    phone = dataReader.GetString(4);
                    mobile = dataReader.GetString(5);
                    email = dataReader.GetString(6);
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[11];
                arr[1] = id;
                arr[2] = firstName;
                arr[3] = lastName;
                if (counter == 1)
                    arr[0] = degree;
                arr[4] = license;
                arr[5] = profession;
                arr[6] = address;
                arr[7] = city;
                arr[8] = phone;
                arr[9] = mobile;
                arr[10] = email;
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
                datacommand.CommandText = "SELECT   doctorID, doctorProfession, doctorDegree, doctorLicense " +
                                          "FROM     tblDoctors   " +
                                          "WHERE    doctorDegree = \'" + degreeCombo.Text + "\' " +
                                          "ORDER BY doctorID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int counter = 0;
                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0).ToString();
                    profession = dataReader.GetString(1);
                    degree = dataReader.GetString(2);
                    license = dataReader.GetInt32(3).ToString();
                    counter++;
                    GetUserDetails(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblDoctors failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
