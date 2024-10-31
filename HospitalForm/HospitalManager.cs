using HospitalManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForm
{
    public partial class HospitalManager : Form
    {
        public Hospital hospital;

        private ListView doctorsList;
        private ListView administrativeList;
        private ListView patientsList;

        public HospitalManager()
        {
            InitializeComponent();

            hospital = new Hospital();
            doctorsList = new ListView();
            administrativeList = new ListView();
            patientsList = new ListView();

            doctorsList.Columns.Add("ID");
            doctorsList.Columns.Add("Name");
            doctorsList.Columns.Add("Specialty");
            doctorsList.Columns.Add("Age");

            administrativeList.Columns.Add("ID");
            administrativeList.Columns.Add("Name");
            administrativeList.Columns.Add("Age");

            patientsList.Columns.Add("ID");
            patientsList.Columns.Add("Name");
            patientsList.Columns.Add("Illness");
            patientsList.Columns.Add("Age");
            patientsList.Columns.Add("Doctor ID");


            liViewPeopleInfo.Visible = false;

            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;
            butAppointments.Enabled = false;
            butAppointments.Visible = false;

            butRemove.Enabled = false;



            
        }

        private void butDoctors_Click(object sender, EventArgs e)
        {
            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;

            liViewPeopleInfo.Items.Clear();
            liViewPeopleInfo.Columns.Clear();

            foreach (ListViewItem item in doctorsList.Items)
            {
                liViewPeopleInfo.Items.Add(item);
            }

            liViewPeopleInfo.Columns.Add("ID");
            liViewPeopleInfo.Columns.Add("Name");
            liViewPeopleInfo.Columns.Add("Specialty");
            liViewPeopleInfo.Columns.Add("Age");


            if (!liViewPeopleInfo.Visible)
            {
                butCheckPatients.Visible = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                liViewPeopleInfo.Visible = true;
            }
            else
            {
                butCheckPatients.Visible = false;
                butCheckPatients.Enabled = false;

                butAppointments.Enabled = false;
                butAppointments.Visible = false;

                butRemove.Enabled = false;

                liViewPeopleInfo.Visible = false;
            }

            liViewDoctors_Update();
        }

        private void butPatients_Click(object sender, EventArgs e)
        {
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;

            liViewPeopleInfo = patientsList;

            if (!liViewPeopleInfo.Visible)
            {
                butAsignDoctor.Visible = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                butRemove.Enabled = false;

                liViewPeopleInfo.Visible = true;
            }
            else
            {
                butAsignDoctor.Enabled = false;
                butAsignDoctor.Visible = false;

                butAppointments.Enabled = false;
                butAppointments.Visible = false;

                butRemove.Enabled = false;

                liViewPeopleInfo.Visible = false;
            }
        }

        private void butAdmins_Click(object sender, EventArgs e)
        {
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;

            butAppointments.Enabled = false;
            butAppointments.Visible = false;

            liViewPeopleInfo.Visible = false;

            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;

            liViewPeopleInfo = administrativeList;

            if (!liViewPeopleInfo.Visible)
                liViewPeopleInfo.Visible = true;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddNewPerson addPersonForm = new AddNewPerson(hospital);
            addPersonForm.Show(this);
        }

        private void liViewPersonInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liViewPeopleInfo.SelectedItems != null)
            {
                butAsignDoctor.Enabled = true;
                butCheckPatients.Enabled = true;
                butRemove.Enabled = true;
            }
        }

        private void liViewDoctors_Update()
        {
            doctorsList.Items.Clear();

            foreach (Doctor doc in hospital.GetDoctors())
            {
                doctorsList.Items.Add(doc.Id.ToString());

                doctorsList.Items[doctorsList.Items.Count - 1].SubItems.Add(doc.Name.ToString());
                doctorsList.Items[doctorsList.Items.Count - 1].SubItems.Add(doc.Speciality);
                doctorsList.Items[doctorsList.Items.Count - 1].SubItems.Add(doc.Age.ToString());
            }

            liViewPeopleInfo = doctorsList;
        }

        private void liViewPatients_Update()
        {
            patientsList.Items.Clear();

            foreach (Patient pat in hospital.GetPatients())
            {
                patientsList.Items.Add(pat.Id.ToString());

                patientsList.Items[patientsList.Items.Count - 1].SubItems.Add(pat.Name.ToString());
                patientsList.Items[patientsList.Items.Count - 1].SubItems.Add(pat.PhoneNumber);
                patientsList.Items[patientsList.Items.Count - 1].SubItems.Add(pat.Illness);
                patientsList.Items[patientsList.Items.Count - 1].SubItems.Add(pat.Age.ToString());

                if (pat.AssignedDoctor != null)
                    patientsList.Items[patientsList.Items.Count - 1].SubItems.Add(pat.AssignedDoctor.Id.ToString());
            }

            liViewPeopleInfo.Clear();
            liViewPeopleInfo = patientsList;
        }

        private void liViewAdministrative_Update()
        {
            administrativeList.Items.Clear();

            foreach (Administrative admin in hospital.GetAdministrative())
            {
                administrativeList.Items.Add(admin.Id.ToString());

                administrativeList.Items[administrativeList.Items.Count - 1].SubItems.Add(admin.Name.ToString());
                administrativeList.Items[administrativeList.Items.Count - 1].SubItems.Add(admin.Age.ToString());
            }

            liViewPeopleInfo.Clear();
            liViewPeopleInfo = administrativeList;
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (liViewPeopleInfo.Visible)
            {
                // If doctors
                liViewDoctors_Update();
                // If patients
                liViewPatients_Update();
                // If admins
                liViewAdministrative_Update();
            }
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            if (liViewPeopleInfo.SelectedItems.Count > 0)
            {
                if(int.TryParse(liViewPeopleInfo.SelectedItems[0].Text, out int index))
                {
                    // If doctor
                    hospital.RemoveDoctor(hospital.GetDoctorByID(index));
                    // If Patient
                    hospital.RemovePatient(index);
                    // If Admin
                    hospital.RemoveAdministrative(hospital.GetAdministrativeByID(index));
                    liViewPeopleInfo.SelectedItems[0].Remove();
                }
            }
        }

        private void butAsignDoctor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(liViewPeopleInfo.SelectedItems[0].Text, out int index))
            {
                AssignDoctor assignForm = new AssignDoctor(hospital, index);
                assignForm.Show();
            }
        }

        private void butCheckPatients_Click(object sender, EventArgs e)
        {
            if (int.TryParse(liViewPeopleInfo.SelectedItems[0].Text, out int index))
            {
                DoctorPatientsForm form = new DoctorPatientsForm(hospital.GetDoctorByID(index));
            
                form.Show();
            }
        }
    }
}
