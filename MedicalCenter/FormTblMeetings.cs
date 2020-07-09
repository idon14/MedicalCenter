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
    public partial class FormTblMeetings : Form
    {
        public FormTblMeetings()
        {
            InitializeComponent();
        }

        private void FormTblMeetings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMeetings.tblMeetings' table. You can move, or remove it, as needed.
            this.tblMeetingsTableAdapter.Fill(this.dataSetMeetings.tblMeetings);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetMeetings changes = (DataSetMeetings)dataSetMeetings.GetChanges();
                if (changes == null)
                    return;
                // Check for errors
                DataTable dt = changes.tblMeetings.GetChanges();
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
                int numRows = tblMeetingsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetMeetings.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
