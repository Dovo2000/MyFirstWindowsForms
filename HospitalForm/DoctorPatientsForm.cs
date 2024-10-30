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
    public partial class DoctorPatientsForm : Form
    {
        private Doctor doctor;
        public DoctorPatientsForm()
        {
            InitializeComponent();
        }
        
        public DoctorPatientsForm(Doctor doc) : this()
        {
            doctor = doc;

            if (doctor == null)
                return;

            DisplayDoctorInfo();
            DisplayPatientInfo();
        }

        private void DisplayDoctorInfo()
        {
            labelID.Text += doctor.Id.ToString();
            labelName.Text += doctor.Name;
            labelSpecialty.Text += doctor.Speciality;
            labelAge.Text += doctor.Age.ToString();
        }

        private void DisplayPatientInfo()
        {
            listViewPatients.Items.Clear();
            foreach(Patient pat in doctor.GetPatients())
            {
                ListViewItem item = new ListViewItem();
                item.Text = pat.Id.ToString();
                item.SubItems.Add(pat.Name);
                item.SubItems.Add(pat.PhoneNumber);
                item.SubItems.Add(pat.Illness);
                item.SubItems.Add(pat.Age.ToString());

                listViewPatients.Items.Add(item);
            }
        }
    }
}
