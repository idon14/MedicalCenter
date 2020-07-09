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
    public partial class FormTblDegrees : Form
    {
        public FormTblDegrees()
        {
            InitializeComponent();
        }

        private void FormTblDegrees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDegrees.tblDegrees' table. You can move, or remove it, as needed.
            this.tblDegreesTableAdapter.Fill(this.dataSetDegrees.tblDegrees);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetDegrees changes = (DataSetDegrees)dataSetDegrees.GetChanges();
                if (changes == null)
                    return;
                // Check for errors
                DataTable dt = changes.tblDegrees.GetChanges();
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
                int numRows = tblDegreesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetDegrees.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
