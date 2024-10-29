﻿using Hospital;
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
        public Hospital.Hospital hospital;

        public HospitalManager()
        {
            hospital = new Hospital.Hospital();

            InitializeComponent();
            liViewDoctors.Visible = false;
            liViewPatients.Visible = false;
            liViewAdmin.Visible = false;

            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;
            butAppointments.Enabled = false;
            butAppointments.Visible = false;

            butRemove.Enabled = false;

            liViewDoctors.Items.Clear();
            liViewPatients.Items.Clear();
            liViewAdmin.Items.Clear();
        }

        private void butDoctors_Click(object sender, EventArgs e)
        {
            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;

            liViewAdmin.Visible = false;
            liViewPatients.Visible = false;

            if (!liViewDoctors.Visible)
            {
                butCheckPatients.Visible = true;
                butCheckPatients.Enabled = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                liViewDoctors.Visible = true;
            }
            else
            {
                butCheckPatients.Visible = false;
                butCheckPatients.Enabled = false;

                butAppointments.Enabled = false;
                butAppointments.Visible = false;

                butRemove.Enabled = false;

                liViewDoctors.Visible = false;
            }

            liViewDoctors_Update();
        }

        private void butPatients_Click(object sender, EventArgs e)
        {
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;

            liViewAdmin.Visible = false;
            liViewDoctors.Visible = false;

            if (!liViewPatients.Visible)
            {
                butAsignDoctor.Enabled = true;
                butAsignDoctor.Visible = true;

                butAppointments.Enabled = true;
                butAppointments.Visible = true;

                butRemove.Enabled = false;

                liViewPatients.Visible = true;
            }
            else
            {
                butAsignDoctor.Enabled = false;
                butAsignDoctor.Visible = false;

                butAppointments.Enabled = false;
                butAppointments.Visible = false;

                butRemove.Enabled = false;

                liViewPatients.Visible = false;
            }
        }

        private void butAdmins_Click(object sender, EventArgs e)
        {
            butCheckPatients.Visible = false;
            butCheckPatients.Enabled = false;

            butAppointments.Enabled = false;
            butAppointments.Visible = false;

            liViewDoctors.Visible = false;
            liViewPatients.Visible = false;

            butAsignDoctor.Enabled = false;
            butAsignDoctor.Visible = false;

            if (!liViewAdmin.Visible)
                liViewAdmin.Visible = true;
            else
            {
                butRemove.Enabled = false;
                liViewAdmin.Visible = false;
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddNewPerson addPersonForm = new AddNewPerson(hospital);
            addPersonForm.Show(this);
        }

        private void liViewPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liViewPatients.SelectedItems != null)
                butRemove.Enabled = true;
        }

        private void liViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liViewAdmin.SelectedItems != null)
                butRemove.Enabled = true;
        }

        private void liViewDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liViewDoctors.SelectedItems != null)
                butRemove.Enabled = true;
        }

        private void liViewDoctors_Update()
        {
            liViewDoctors.Items.Clear();
            foreach (Doctor doc in hospital.GetDoctors())
            {
                liViewDoctors.Items.Add(doc.Id.ToString());

                liViewDoctors.Items[doc.Id].SubItems.Add(doc.Name.ToString());
                liViewDoctors.Items[doc.Id].SubItems.Add(doc.Speciality);
                liViewDoctors.Items[doc.Id].SubItems.Add(doc.Age.ToString());
            }
        }
    }
}
