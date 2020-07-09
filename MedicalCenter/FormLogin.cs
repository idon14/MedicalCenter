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
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;

        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
            password.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void OpenDb()
        {
            dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2020\\Project_IdoNaveh\\Access\\dbMedicalCenter.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                CheckButtonClick(null, null);
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            String line, password;
            Boolean isAdmin;
            int id;
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT userID, userPassword, userIsAdmin FROM tblUsers WHERE userID = " + this.idNumber.Text;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                isAdmin = dataReader.GetBoolean(2);
                if (password == this.password.Text)
                {
                    this.Hide();
                    FormMenu frMenu = new FormMenu(dataConnection, isAdmin, id.ToString());
                    frMenu.Show();
                    frMenu.Disposed += new EventHandler(frMenu_Disposed);
                }
                else
                {
                    line = "Invalid password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "Invalid id: " + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
        }

        void frMenu_Disposed(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            this.Show();
            this.Activate();
        }
    }
}
