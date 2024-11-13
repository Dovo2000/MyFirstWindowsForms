using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
    internal class DAL_Jobs
    {
        DataClassTablesEmployeesDataContext dataClass;

        public DAL_Jobs()
        {
            dataClass = new DataClassTablesEmployeesDataContext();
        }

        public void Insert(jobs job)
        {
            try
            {
                dataClass.jobs.InsertOnSubmit(job);
                dataClass.SubmitChanges();
                MessageBox.Show("Tarea completada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public List<jobs> Select()
        {
            try
            {
                return dataClass.jobs.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
                return new List<jobs>();
            }
        }

        public void Update(jobs job)
        {
            try
            {
                jobs jobToUpdate = dataClass.jobs.Where(x => x.job_id == job.job_id).SingleOrDefault();
                
                if (jobToUpdate == null)
                    return;

                jobToUpdate.job_title = job.job_title;
                jobToUpdate.min_salary = job.min_salary;
                jobToUpdate.max_salary = job.max_salary;

                dataClass.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
