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
    public partial class FormTblMedicalCenter : Form
    {
        public FormTblMedicalCenter()
        {
            InitializeComponent();
        }

        private void FormTblMedicalCenter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMedicalCenter.tblMedicalCenter' table. You can move, or remove it, as needed.
            this.tblMedicalCenterTableAdapter.Fill(this.dataSetMedicalCenter.tblMedicalCenter);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetMedicalCenter changes = (DataSetMedicalCenter)dataSetMedicalCenter.GetChanges();
                if (changes == null)
                    return;
                // Check for errors
                DataTable dt = changes.tblMedicalCenter.GetChanges();
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
                int numRows = tblMedicalCenterTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetMedicalCenter.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
