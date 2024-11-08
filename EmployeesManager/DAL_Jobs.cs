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
        DataBaseConnection dataBaseManager;

        public DAL_Jobs()
        {
            dataBaseManager = new DataBaseConnection();
        }

        public void Insert(Job job)
        {
            try
            {
                dataBaseManager.Connect();

                string sqlQuery = @"INSERT INTO jobs(job_title, min_salary, max_salary)
                                    VALUES (@ptitle, @pminSalary, @pmaxSalary);
                                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, dataBaseManager.connection))
                {
                    SqlParameter ptitle = new SqlParameter("@ptitle", SqlDbType.VarChar, 35);
                    cmd.Parameters.Add(ptitle);
                    ptitle.Value = job.job_title;

                    SqlParameter pminSalary = new SqlParameter("@pminSalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(pminSalary);
                    pminSalary.Precision = 8;
                    pminSalary.Scale = 2;
                    pminSalary.Value = DataBaseConnection.NullToDBNull(job.min_salary);
                
                    SqlParameter pmaxSalary = new SqlParameter("@pmaxSalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(pmaxSalary);
                    pmaxSalary.Precision = 8;
                    pmaxSalary.Scale = 2;
                    pmaxSalary.Value = DataBaseConnection.NullToDBNull(job.max_salary);


                    job.job_id = Convert.ToInt32(cmd.ExecuteScalar());
                }

                dataBaseManager.Disconnect();
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
                
                List<jobs> jobsList = new List<jobs>();

                string sqlQuery = "SELECT * FROM jobs";

                dataBaseManager.Connect();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, dataBaseManager.connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string jobTitle = reader.GetString(1);
                        decimal? minSalary = reader.IsDBNull(2) ? (decimal?) null : reader.GetDecimal(2); 
                        decimal? maxSalary = reader.IsDBNull(3) ? (decimal?) null : reader.GetDecimal(3);

                        jobs job = new jobs(id, jobTitle, minSalary, maxSalary);

                        jobsList.Add(job);
                    }
                }

                dataBaseManager.Disconnect();
                return jobsList;
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
                string sqlQuery = @"UPDATE jobs 
                                SET job_title = @pjobTitle, min_salary = @pminSalary, max_salary = @pmaxSalary
                                WHERE job_id = @pjobId";

                dataBaseManager.Connect();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, dataBaseManager.connection))
                {
                    SqlParameter pjobTitle = new SqlParameter("@pjobTitle", SqlDbType.VarChar, 35);
                    cmd.Parameters.Add(pjobTitle);
                    pjobTitle.Value = job.job_title;

                    SqlParameter pminSalary = new SqlParameter("@pminSalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(pminSalary);
                    pminSalary.Precision = 8;
                    pminSalary.Scale = 2;
                    pminSalary.Value = DataBaseConnection.NullToDBNull(job.min_salary);

                    SqlParameter pmaxSalary = new SqlParameter("@pmaxSalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(pmaxSalary);
                    pmaxSalary.Precision = 8;
                    pmaxSalary.Scale = 2;
                    pmaxSalary.Value = DataBaseConnection.NullToDBNull(job.max_salary);

                    SqlParameter pJobId = new SqlParameter("@pjobId", SqlDbType.Int);
                    cmd.Parameters.Add(pJobId);
                    pJobId.Value = job.job_id;

                    cmd.ExecuteNonQuery();
                }

                dataBaseManager.Disconnect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
