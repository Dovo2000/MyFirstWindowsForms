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
    public partial class AddNewPerson : Form
    {
        Hospital hospital;

        public AddNewPerson()
        {
            InitializeComponent();
        }

        public AddNewPerson(Hospital hospital) : this()
        {
            this.hospital = hospital;
        }

        private void butCancelNewPerson_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butSubmitNewPerson_Click(object sender, EventArgs e)
        {
            switch (tabNewPerson.SelectedIndex)
            {
                case 0:
                    // Adding a Doctor
                    Doctor newDoc = new Doctor(txtBoxDoctor.Text, (int) numericAgeDoctor.Value, comboBoxSpecialty.SelectedItem.ToString());
                    hospital.AddDoctor(newDoc);
                    break;
                case 1:
                    // Adding a Patient
                    Patient newPat = new Patient(txtBoxNamePatient.Text, (int) numericAgePatient.Value, txtBoxIllness.Text, txtBoxPhone.Text);
                    hospital.AddPatient(newPat);
                    break;
                case 2:
                    // Adding an Administrative
                    Administrative newAdmin = new Administrative(txtBoxNameAdmin.Text, (int) numericAgeAdmin.Value);
                    hospital.AddAdministrative(newAdmin);
                    break;
                default:
                    break;
            }

            Close();
        }
    }
}
