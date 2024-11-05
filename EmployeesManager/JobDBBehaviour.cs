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
    internal class JobDBBehaviour
    {
        DataBaseManagement dataBaseManager;

        public JobDBBehaviour()
        {
            dataBaseManager = new DataBaseManagement();
        }

        public void AddJob(Job job)
        {
            try
            {
                if (dataBaseManager.connection.State != ConnectionState.Open)
                    dataBaseManager.Connect();

                string sqlQuery = @"
                INSERT INTO jobs(job_title, min_salary, max_salary)
                VALUES ('" + job.job_title + "', " + (job.min_salary != null ? job.min_salary.ToString() : "NULL") + ", " + (job.max_salary != null ? job.max_salary.ToString() : "NULL") + ")";

                SqlCommand cmd = new SqlCommand(sqlQuery, dataBaseManager.connection);

                cmd.ExecuteNonQuery();

                dataBaseManager.Disconnect();
                MessageBox.Show("Tarea completada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public List<Job> GetJobs()
        {
            try
            {
                
                List<Job> jobs = new List<Job>();

                string query = "SELECT * FROM jobs";

                if (dataBaseManager.connection.State != ConnectionState.Open)
                    dataBaseManager.Connect();

                using (SqlCommand cmd = new SqlCommand(query, dataBaseManager.connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string jobTitle = reader.GetString(1);
                        decimal? minSalary = reader.IsDBNull(2) ? (decimal?) null : reader.GetDecimal(2); 
                        decimal? maxSalary = reader.IsDBNull(3) ? (decimal?)null : reader.GetDecimal(3);

                        Job job = new Job(id, jobTitle, minSalary, maxSalary);

                        jobs.Add(job);
                    }
                }

                dataBaseManager.Disconnect();
                return jobs;
            }
            catch (Exception e)
            {
                return new List<Job>();
            }

        }
    }
}
