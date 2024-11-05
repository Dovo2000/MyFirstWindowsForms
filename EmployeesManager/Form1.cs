using System;
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
    public partial class Form1 : Form
    {
        JobDBBehaviour jobDBController;

        public Form1()
        {
            InitializeComponent();

            jobDBController = new JobDBBehaviour();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            decimal? minSalary = numericMinSalary.Value <= 0 ? null : (decimal?) numericMinSalary.Value;
            decimal? maxSalary = numericMaxSalary.Value <= 0 ? null : (decimal?) numericMaxSalary.Value;

            Job job = new Job(txtBoxJobTitle.Text, maxSalary, minSalary);

            jobDBController.AddJob(job);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            txtBoxJobTitle.Clear();
            numericMinSalary.Value = 0;
            numericMaxSalary.Value = 0;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            liBoxJobs.Items.Clear();
            List<Job> jobs = jobDBController.GetJobs();

            foreach (Job job in jobs)
            {
                liBoxJobs.Items.Add(job.ToString());
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
