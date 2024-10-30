using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForm
{
    public partial class AssignDoctor : Form
    {
        Hospital.Hospital hospital;
        Patient patient;

        public AssignDoctor()
        {
            InitializeComponent();
        }
        
        public AssignDoctor(Hospital.Hospital hospital, int patientId) : this()
        {
            this.hospital = hospital;
            patient = hospital.GetPatientByID(patientId);
            ShowPatientInfo();
        }

        private void ShowPatientInfo()
        {
            if (patient == null)
                return;

            labelId.Text = labelId.Text + patient.Id.ToString();
            labelName.Text = labelName.Text + patient.Name;
            labelIllness.Text = labelIllness.Text + patient.Illness;
            labelPhone.Text = labelPhone.Text + patient.PhoneNumber;
            labelAge.Text = labelAge.Text + patient.Age.ToString();

            labelHasDoc.Text = labelHasDoc.Text + (patient.AssignedDoctor != null ? "Yes" : "No");

            if (patient.AssignedDoctor != null)
            {
                labelDocId.Visible = true;
                labelDocId.Text = labelDocId.Text + patient.AssignedDoctor.Id.ToString();
            }
            else
                labelDocId.Visible = false;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butAssign_Click(object sender, EventArgs e)
        {
            if(liViewDoctors.SelectedItems.Count > 0)
            {
                if (int.TryParse(liViewDoctors.SelectedItems[0].Text, out int index))
                    hospital.GetPatientByID(patient.Id).AssignedDoctor = hospital.GetDoctorByID(index);
            }

            Close();
        }

    }
}
