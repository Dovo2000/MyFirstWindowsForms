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
    internal class DAL_Employee
    {
        DataBaseConnection connection;

        public DAL_Employee()
        {
            this.connection = new DataBaseConnection();
        }

        public void Insert(Employee employee)
        {
            try
            {
                connection.Connect();

                string sqlQuery = @"INSERT INTO employees(first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id)
                                    VALUES (@pfirst_name, @plast_name, @pemail, @pphone_number);
                                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection.connection))
                {
                    SqlParameter pfirstName = new SqlParameter("@pfirst_name", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add(pfirstName);
                    pfirstName.Value = employee.first_name;

                    SqlParameter plastName = new SqlParameter("@pfirst_name", SqlDbType.VarChar, 25);
                    cmd.Parameters.Add(plastName);
                    plastName.Value = employee.last_name;

                    SqlParameter pemail = new SqlParameter("@pemail", SqlDbType.VarChar, 100);
                    cmd.Parameters.Add(pemail);
                    pemail.Value = employee.email;

                    SqlParameter pphoneNumber = new SqlParameter("@pphone_number", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add(pphoneNumber);
                    pphoneNumber.Value = DataBaseConnection.NullToDBNull(employee.phone_number);

                    SqlParameter phireDate = new SqlParameter("@phire_date", SqlDbType.Date);
                    cmd.Parameters.Add(phireDate);
                    phireDate.Value = employee.hire_date;

                    SqlParameter pmaxSalary = new SqlParameter("@pmaxSalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(pmaxSalary);
                    pmaxSalary.Precision = 8;
                    pmaxSalary.Scale = 2;
                    pmaxSalary.Value = DataBaseConnection.NullToDBNull(employee.max_salary);


                    employee.job_id = Convert.ToInt32(cmd.ExecuteScalar());
                }

                connection.Disconnect();
                MessageBox.Show("Tarea completada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
