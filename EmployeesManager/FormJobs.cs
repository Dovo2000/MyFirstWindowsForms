﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
    public partial class FormJobs : Form
    {
        DAL_Jobs jobDBController;

        public FormJobs()
        {
            InitializeComponent();

            jobDBController = new DAL_Jobs();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            decimal? minSalary = numericMinSalary.Value <= 0 ? null : (decimal?) numericMinSalary.Value;
            decimal? maxSalary = numericMaxSalary.Value <= 0 ? null : (decimal?) numericMaxSalary.Value;

            jobs job = new jobs(txtBoxJobTitle.Text, minSalary, maxSalary);

            jobDBController.Insert(job);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            txtBoxJobTitle.Clear();
            numericMinSalary.Value = 0;
            numericMaxSalary.Value = 0;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            RefreshJobListBox();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (liBoxJobs.SelectedItem == null)
                return;

            int jobId = 0;
            string[] splittedJob = liBoxJobs.SelectedItem.ToString().Split('/');

            if (int.TryParse(splittedJob[0], out int id))
                jobId = id;
            else
                return;


            decimal? minSalary = numericMinSalary.Value <= 0 ? null : (decimal?)numericMinSalary.Value;
            decimal? maxSalary = numericMaxSalary.Value <= 0 ? null : (decimal?)numericMaxSalary.Value;

            jobs job = new jobs();
            job.job_id = jobId;
            job.job_title = txtBoxJobTitle.Text;
            job.min_salary = minSalary;
            job.max_salary = maxSalary;

            jobDBController.Update(job);

            RefreshJobListBox();
        }

        private void liBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] splittedJob = liBoxJobs.SelectedItem.ToString().Split('/');

                txtBoxJobTitle.Text = splittedJob[1]; // splittedJob[0] is the job_id

                if (splittedJob[2].Contains("NULL"))
                    numericMinSalary.Value = 0;
                else if (float.TryParse(splittedJob[2], out float minSalary))
                    numericMinSalary.Value = (decimal) minSalary;
                else
                    numericMinSalary.Value = 0;

                if (splittedJob[3].Contains("NULL"))
                    numericMaxSalary.Value = 0;
                else if (float.TryParse(splittedJob[3], out float maxSalary))
                    numericMaxSalary.Value = (decimal) maxSalary;
                else
                    numericMaxSalary.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void RefreshJobListBox()
        {
            liBoxJobs.Items.Clear();
            List<jobs> jobsList = jobDBController.Select();

            foreach (jobs job in jobsList)
            {
                liBoxJobs.Items.Add(job.ToString());
            }
        }
    }
}
