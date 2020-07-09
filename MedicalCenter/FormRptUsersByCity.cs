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
    public partial class FormRptUsersByCity : Form
    {
        private OleDbConnection dataConnection;
        private string city;
        private string id;
        private string firstName;
        private string lastName;
        private string birthday;
        private string address;
        private string phone;
        private string mobile;
        private string email;
        private string saveColor = "";
        public FormRptUsersByCity(OleDbConnection dataConnection)
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

        private void CityClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userID, userFirstName, userLastName, userBirthday, userAddress, userCity, userPhone, userMobile, userEmail " +
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
                    birthday = dataReader.GetDateTime(3).ToString("dd/MM/yyyy");
                    address = dataReader.GetString(4);
                    city = dataReader.GetString(5);
                    phone = dataReader.GetString(6);
                    mobile = dataReader.GetString(7);
                    email = dataReader.GetString(8);
                    counter++;
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
                string[] arr = new string[9];
                if (counter == 1)
                    arr[0] = city;
                arr[1] = id;
                arr[2] = firstName;
                arr[3] = lastName;
                arr[4] = birthday;
                arr[5] = address;
                arr[6] = phone;
                arr[7] = mobile;
                arr[8] = email;
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
