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

        private List<ListViewItem> doctorsList;
        private List<ListViewItem> administrativeList;
        private List<ListViewItem> patientsList;

        private int peopleTabIndex;

        public HospitalManager()
        {
            InitializeComponent();

            hospital = new Hospital();
            doctorsList = new List<ListViewItem>();
            administrativeList = new List<ListViewItem>();
            patientsList = new List<ListViewItem>();

            peopleTabIndex = 0;

            liViewPeopleInfo.Visible = true;

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
            if (peopleTabIndex != 1)
            {
                peopleTabIndex = 1;

                butAsignDoctor.Enabled = false;
                butAsignDoctor.Visible = false;
                butCheckPatients.Visible = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                liViewPeopleInfo.Visible = true;
            }

            ListViewItemsPeople_Update();
        }

        private void butPatients_Click(object sender, EventArgs e)
        {

            if (peopleTabIndex != 2)
            {
                peopleTabIndex = 2;

                butCheckPatients.Visible = false;
                butCheckPatients.Enabled = false;
                butAsignDoctor.Visible = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                butRemove.Enabled = false;

                liViewPeopleInfo.Visible = true;
            }

            ListViewItemsPeople_Update();
        }

        private void butAdmins_Click(object sender, EventArgs e)
        {
            if(peopleTabIndex != 3)
            {
                peopleTabIndex = 3;

                butCheckPatients.Visible = false;
                butCheckPatients.Enabled = false;

                butAppointments.Enabled = false;
                butAppointments.Visible = false;

                butAsignDoctor.Enabled = false;
                butAsignDoctor.Visible = false;

                liViewPeopleInfo.Visible = true;
            }

            ListViewItemsPeople_Update();
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

        private void ListViewItemsPeople_Update()
        {

            switch(peopleTabIndex)
            {
                case 0:
                    // Mostrar la info de todo el mundo
                    //DisplayEveryoneInfo();
                    break;

                case 1:
                    // Mostrar la info de los doctores
                    DisplayDoctorsInfo();
                break;

                case 2:
                    // Mostrar la info de los pacientes
                    DisplayPatientsInfo();
                break;

                case 3:
                    // Mostrar la info de los administrativos
                    DisplayAdministrativesInfo();
                break;

                default:
                break;
            }
        }

        private void DisplayDoctorsInfo()
        {
            liViewPeopleInfo.Clear();

            liViewPeopleInfo.Columns.Add("ID");
            liViewPeopleInfo.Columns.Add("Name");
            liViewPeopleInfo.Columns.Add("Specialty");
            liViewPeopleInfo.Columns.Add("Age");

            foreach (Doctor doc in hospital.GetDoctors())
            {
                liViewPeopleInfo.Items.Add(new ListViewItem(doc.Id.ToString()));

                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(doc.Name.ToString());
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(doc.Speciality);
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(doc.Age.ToString());
            }
        }

        private void DisplayPatientsInfo()
        {
            liViewPeopleInfo.Clear();

            liViewPeopleInfo.Columns.Add("ID");
            liViewPeopleInfo.Columns.Add("Name");
            liViewPeopleInfo.Columns.Add("Phone");
            liViewPeopleInfo.Columns.Add("Illness");
            liViewPeopleInfo.Columns.Add("Age");
            liViewPeopleInfo.Columns.Add("Doctor ID");

            foreach (Patient pat in hospital.GetPatients())
            {
                liViewPeopleInfo.Items.Add(new ListViewItem(pat.Id.ToString()));

                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(pat.Name.ToString());
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(pat.PhoneNumber);
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(pat.Illness);
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(pat.Age.ToString());

                if (pat.AssignedDoctor != null)
                    liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(pat.AssignedDoctor.Id.ToString());
            }
        }

        private void DisplayAdministrativesInfo()
        {
            liViewPeopleInfo.Clear();

            liViewPeopleInfo.Columns.Add("ID");
            liViewPeopleInfo.Columns.Add("Name");
            liViewPeopleInfo.Columns.Add("Age");

            foreach (Administrative admin in hospital.GetAdministrative())
            {
                liViewPeopleInfo.Items.Add(new ListViewItem(admin.Id.ToString()));

                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(admin.Name.ToString());
                liViewPeopleInfo.Items[liViewPeopleInfo.Items.Count - 1].SubItems.Add(admin.Age.ToString());
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            ListViewItemsPeople_Update();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            if (liViewPeopleInfo.SelectedItems.Count > 0)
            {
                if(int.TryParse(liViewPeopleInfo.SelectedItems[0].Text, out int index))
                {
                    if(peopleTabIndex == 1)
                        hospital.RemoveDoctor(hospital.GetDoctorByID(index));
                    else if (peopleTabIndex == 2)
                        hospital.RemovePatient(index);
                    else if(peopleTabIndex == 3)
                        hospital.RemoveAdministrative(hospital.GetAdministrativeByID(index));

                    ListViewItemsPeople_Update();
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
