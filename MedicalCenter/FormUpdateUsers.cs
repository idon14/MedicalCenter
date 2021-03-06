﻿using System;
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
    public partial class FormUpdateUsers : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateUsers(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;

            if (!isManager)
                updateButton.Enabled = false;

            fillCityCombo();
            RefreshDataGridView();
        }

        private void fillCityCombo()
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

        private void FormUpdateUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);
        }

        private void RefreshDataGridView()
        {
            try
            {
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblUsers  \n" +
                                          "SET    userFirstName    =  \"" + firstNameField.Text + "\" , \n" +
                                                  "userLastName    =  \"" + lastNameField.Text + "\" , \n" +
                                                  "userBirthday    =  \"" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "\", \n" +
                                                  "userAddress     =  \"" + addressField.Text + "\" , \n" +
                                                  "userCity        =  \"" + cityCombo.Text + "\" , \n" +
                                                  "userPhone       =  \"" + phoneField.Text + "\" , \n" +
                                                  "userMobile      =  \"" + mobileField.Text + "\" , \n" +
                                                  "userEmail       =  \"" + emailField.Text + "\", \n" +
                                                  "userPassword    =  \"" + passwordField.Text + "\", \n" +
                                                  "userIsAdmin     =    " + adminChkbox.Checked + "   , \n" +
                                                  "userPicture     =  \"" + imageField.Text + "\"  \n" +
                                          "WHERE  userID = " + idField.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblUsers failed \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSelectedRow()
        {
            try
            {
                idField.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firstNameField.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastNameField.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                addressField.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cityCombo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                phoneField.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mobileField.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                emailField.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                passwordField.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                adminChkbox.Checked = dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "True";
                imageField.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                pictureBox1.ImageLocation = imageField.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableButtons()
        {
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                previousButton.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            FillSelectedRow();
        }

        private void BrowseButton(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            imageField.Text = pictureFileName;
        }

        private void FirstClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void PreviousClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void NextClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void LastClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
    }
}
