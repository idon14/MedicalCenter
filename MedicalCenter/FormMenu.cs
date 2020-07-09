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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        private Boolean isAdmin;
        private string userId;
        public FormMenu(OleDbConnection dataConnection, Boolean isAdmin, string userId)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;
            this.userId = userId;

            if (!isAdmin)
            {
                menuStrip1.Items.RemoveAt(2);
                menuStrip1.Items.RemoveAt(1);
                menuStrip1.Items.RemoveAt(0);
            }

            GetUserDetails();
        }

        private void GetUserDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userFirstName, userLastName, userPicture " +
                                          "FROM     tblUsers  " +
                                          "WHERE    userID = " + userId;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    nameLabel.Text = "שלום " + dataReader.GetString(0) + " " + dataReader.GetString(1) + "!";
                    idLabel.Text = "תעודת זהות: " + userId;
                    if (!dataReader.IsDBNull(2))
                        userPicture.ImageLocation = dataReader.GetString(2);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblUsers frUsers = new FormTblUsers();
            frUsers.Show();
            frUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void DoctorsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblDoctors frDoctors = new FormTblDoctors();
            frDoctors.Show();
            frDoctors.Disposed += new EventHandler(Form_Disposed);
        }

        private void CitiesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities frCities = new FormTblCities();
            frCities.Show();
            frCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void DegreesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblDegrees frDegrees = new FormTblDegrees();
            frDegrees.Show();
            frDegrees.Disposed += new EventHandler(Form_Disposed);
        }

        private void ProfessionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblProfessions frProfessions = new FormTblProfessions();
            frProfessions.Show();
            frProfessions.Disposed += new EventHandler(Form_Disposed);
        }

        private void ClinicsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblClinics frClinics = new FormTblClinics();
            frClinics.Show();
            frClinics.Disposed += new EventHandler(Form_Disposed);
        }

        private void MeetingsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblMeetings frMeetings = new FormTblMeetings();
            frMeetings.Show();
            frMeetings.Disposed += new EventHandler(Form_Disposed);
        }

        private void MedicalCenterClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblMedicalCenter frMedicalCenter = new FormTblMedicalCenter();
            frMedicalCenter.Show();
            frMedicalCenter.Disposed += new EventHandler(Form_Disposed);
        }

        private void ReceptionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblReceptions frReceptions = new FormTblReceptions();
            frReceptions.Show();
            frReceptions.Disposed += new EventHandler(Form_Disposed);
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void AddUserClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUsers frAddUsers = new FormAddUsers(dataConnection, isAdmin);
            frAddUsers.Show();
            frAddUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddDoctors frAddDoctors = new FormAddDoctors(dataConnection, isAdmin);
            frAddDoctors.Show();
            frAddDoctors.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frAddCities = new FormAddCities(dataConnection, isAdmin);
            frAddCities.Show();
            frAddCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddDegreeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddDegrees frAddDegrees = new FormAddDegrees(dataConnection, isAdmin);
            frAddDegrees.Show();
            frAddDegrees.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddProfessionClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddProfessions frAddProfessions = new FormAddProfessions(dataConnection, isAdmin);
            frAddProfessions.Show();
            frAddProfessions.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddClinics frAddClinics = new FormAddClinics(dataConnection, isAdmin);
            frAddClinics.Show();
            frAddClinics.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddMeetingClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMeetings frAddMeetings = new FormAddMeetings(dataConnection, isAdmin);
            frAddMeetings.Show();
            frAddMeetings.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddMedicalCenterClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddMedicalCenters frAddMedicalCenters = new FormAddMedicalCenters(dataConnection, isAdmin);
            frAddMedicalCenters.Show();
            frAddMedicalCenters.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddReceptionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddReceptions frAddReceptions = new FormAddReceptions(dataConnection, isAdmin);
            frAddReceptions.Show();
            frAddReceptions.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateUsersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUsers frUpdateUsers = new FormUpdateUsers(dataConnection, isAdmin);
            frUpdateUsers.Show();
            frUpdateUsers.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateDoctorsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateDoctors frUpdateDoctors = new FormUpdateDoctors(dataConnection, isAdmin);
            frUpdateDoctors.Show();
            frUpdateDoctors.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateProfessionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateProfessions frUpdateProfessions = new FormUpdateProfessions(dataConnection, isAdmin);
            frUpdateProfessions.Show();
            frUpdateProfessions.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateClinicsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateClinics frUpdateClinics = new FormUpdateClinics(dataConnection, isAdmin);
            frUpdateClinics.Show();
            frUpdateClinics.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateMeetingsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateMeetings frUpdateMeetings = new FormUpdateMeetings(dataConnection, isAdmin);
            frUpdateMeetings.Show();
            frUpdateMeetings.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateMedicalCentersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateMedicalCenters frUpdateMedicalCenters = new FormUpdateMedicalCenters(dataConnection, isAdmin);
            frUpdateMedicalCenters.Show();
            frUpdateMedicalCenters.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateReceptionsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateReceptions frUpdateReceptions = new FormUpdateReceptions(dataConnection, isAdmin);
            frUpdateReceptions.Show();
            frUpdateReceptions.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptDoctorsByProfessionClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDoctorsByProfession frRptDoctorsByProfession = new FormRptDoctorsByProfession(dataConnection);
            frRptDoctorsByProfession.Show();
            frRptDoctorsByProfession.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptDoctorsByCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDoctorsByCity frRptDoctorsByCity = new FormRptDoctorsByCity(dataConnection);
            frRptDoctorsByCity.Show();
            frRptDoctorsByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptDoctorsByDegreeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDoctorsByDegree frRptDoctorsByDegree = new FormRptDoctorsByDegree(dataConnection);
            frRptDoctorsByDegree.Show();
            frRptDoctorsByDegree.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptReceptionsOfDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptReceptionsOfDoctor frRptReceptionsOfDoctor = new FormRptReceptionsOfDoctor(dataConnection);
            frRptReceptionsOfDoctor.Show();
            frRptReceptionsOfDoctor.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptMeetingsOfPatientClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptMeetingsOfPatient frRptMeetingsOfPatient = new FormRptMeetingsOfPatient(dataConnection);
            frRptMeetingsOfPatient.Show();
            frRptMeetingsOfPatient.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptMeetingsOfDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptMeetingsOfDoctor frRptMeetingsOfDoctor = new FormRptMeetingsOfDoctor(dataConnection);
            frRptMeetingsOfDoctor.Show();
            frRptMeetingsOfDoctor.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptDoctorsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDoctorsByClinic frRptDoctorsByClinic = new FormRptDoctorsByClinic(dataConnection);
            frRptDoctorsByClinic.Show();
            frRptDoctorsByClinic.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptMeetingsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptMeetingsByClinic frRptMeetingsByClinic = new FormRptMeetingsByClinic(dataConnection);
            frRptMeetingsByClinic.Show();
            frRptMeetingsByClinic.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptClinicsByCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptClinicsByCity frRptClinicsByCity = new FormRptClinicsByCity(dataConnection);
            frRptClinicsByCity.Show();
            frRptClinicsByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptUsersByCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptUsersByCity frRptUsersByCity = new FormRptUsersByCity(dataConnection);
            frRptUsersByCity.Show();
            frRptUsersByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptClinicsByProfessionClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptClinicsByProfession frRptClinicsByProfession = new FormRptClinicsByProfession(dataConnection);
            frRptClinicsByProfession.Show();
            frRptClinicsByProfession.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptPatientsByDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsByDoctor frRptPatientsByDoctor = new FormRptPatientsByDoctor(dataConnection);
            frRptPatientsByDoctor.Show();
            frRptPatientsByDoctor.Disposed += new EventHandler(Form_Disposed);
        }

        private void RptPatientsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsByClinic frRptPatientsByClinic = new FormRptPatientsByClinic(dataConnection);
            frRptPatientsByClinic.Show();
            frRptPatientsByClinic.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartDoctorsByProfessionClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartDoctorsByProfession frChartDoctorsByProfession = new FormChartDoctorsByProfession(dataConnection);
            frChartDoctorsByProfession.Show();
            frChartDoctorsByProfession.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartDoctorsByCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartDoctorsByCity frChartDoctorsByCity = new FormChartDoctorsByCity(dataConnection);
            frChartDoctorsByCity.Show();
            frChartDoctorsByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartDoctorsByDegreeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartDoctorsByDegree frChartDoctorsByDegree = new FormChartDoctorsByDegree(dataConnection);
            frChartDoctorsByDegree.Show();
            frChartDoctorsByDegree.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartMeetingsByPatientClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartMeetingsByPatient frChartMeetingsByPatient = new FormChartMeetingsByPatient(dataConnection);
            frChartMeetingsByPatient.Show();
            frChartMeetingsByPatient.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartMeetingsByDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartMeetingsByDoctor frChartMeetingsByDoctor = new FormChartMeetingsByDoctor(dataConnection);
            frChartMeetingsByDoctor.Show();
            frChartMeetingsByDoctor.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartClinicsByCity(object sender, EventArgs e)
        {
            this.Hide();
            FormChartClinicsByCity frChartClinicsByCity = new FormChartClinicsByCity(dataConnection);
            frChartClinicsByCity.Show();
            frChartClinicsByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartDoctorsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartDoctorsByClinic frChartDoctorsByClinic = new FormChartDoctorsByClinic(dataConnection);
            frChartDoctorsByClinic.Show();
            frChartDoctorsByClinic.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartMeetingsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartMeetingsByClinic frChartMeetingsByClinic = new FormChartMeetingsByClinic(dataConnection);
            frChartMeetingsByClinic.Show();
            frChartMeetingsByClinic.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartPatientsByCity(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientsByCity frChartPatientsByCity = new FormChartPatientsByCity(dataConnection);
            frChartPatientsByCity.Show();
            frChartPatientsByCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartClinicsByProfessionClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartClinicsByProfession frChartClinicsByProfession = new FormChartClinicsByProfession(dataConnection);
            frChartClinicsByProfession.Show();
            frChartClinicsByProfession.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartPatientsByDoctorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientsByDoctor frChartPatientsByDoctor = new FormChartPatientsByDoctor(dataConnection);
            frChartPatientsByDoctor.Show();
            frChartPatientsByDoctor.Disposed += new EventHandler(Form_Disposed);
        }

        private void ChartPatientsByClinicClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientsByClinic frChartPatientsByClinic = new FormChartPatientsByClinic(dataConnection);
            frChartPatientsByClinic.Show();
            frChartPatientsByClinic.Disposed += new EventHandler(Form_Disposed);
        }
    }
}
