using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class FormTblProfessions : Form
    {
        public FormTblProfessions()
        {
            InitializeComponent();
        }

        private void FormTblProfessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProfessions.tblProfessions' table. You can move, or remove it, as needed.
            this.tblProfessionsTableAdapter.Fill(this.dataSetProfessions.tblProfessions);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetProfessions changes = (DataSetProfessions)dataSetProfessions.GetChanges();
                if (changes == null)
                    return;
                // Check for errors
                DataTable dt = changes.tblProfessions.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                // Find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // No error found, update the database
                int numRows = tblProfessionsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetProfessions.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
