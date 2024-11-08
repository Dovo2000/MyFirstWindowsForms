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
                                    VALUES (@pfirst_name, @plast_name, @pemail, @pphone_number, @phiredate, @pjob_id, @psalary, @pmanager_id, @pdepartment_id);
                                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection.connection))
                {
                    SqlParameter pfirstName = new SqlParameter("@pfirst_name", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add(pfirstName);
                    pfirstName.Value = employee.first_name;

                    SqlParameter plastName = new SqlParameter("@plast_name", SqlDbType.VarChar, 25);
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

                    SqlParameter pjobId = new SqlParameter("@pjob_id", SqlDbType.Int);
                    cmd.Parameters.Add(pjobId);
                    pjobId.Value = employee.job_id;

                    SqlParameter psalary = new SqlParameter("@psalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(psalary);
                    psalary.Precision = 8;
                    psalary.Scale = 2;
                    psalary.Value = employee.salary;

                    SqlParameter pmanagerId = new SqlParameter("@pmanager_id", SqlDbType.Int);
                    cmd.Parameters.Add(pmanagerId);
                    pmanagerId.Value = DataBaseConnection.NullToDBNull(employee.manager_id);

                    SqlParameter pdepartmentId = new SqlParameter("@pdepartment_id", SqlDbType.Int);
                    cmd.Parameters.Add(pdepartmentId);
                    pdepartmentId.Value = DataBaseConnection.NullToDBNull(employee.department_id);

                    employee.employee_id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public List<Employee> Select()
        {
            try
            {

                List<Employee> employees = new List<Employee>();

                string sqlQuery = "SELECT * FROM employees;";

                connection.Connect();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection.connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string firstName = (string) DataBaseConnection.DBNullToNull(reader.GetString(1));
                        string lastName = reader.GetString(2);
                        string email = reader.GetString(3);
                        string phoneNumber = (string) DataBaseConnection.DBNullToNull(reader.GetString(4));
                        DateTime hireDate = reader.GetDateTime(5);
                        int jobId = reader.GetInt32(6);
                        decimal salary = reader.GetDecimal(7);
                        int? managerId = (int?) DataBaseConnection.DBNullToNull(reader.GetInt32(8));
                        int? departmentId = (int?) DataBaseConnection.DBNullToNull(reader.GetInt32(9));


                        Employee employee = new Employee(id, firstName, lastName, email, phoneNumber, hireDate, jobId, salary, managerId, departmentId);

                        employees.Add(employee);
                    }
                }

                connection.Disconnect();
                return employees;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
                return new List<Employee>();
            }
        }

        public void Update(Employee employee)
        {
            try
            {
                string sqlQuery = @"UPDATE jobs 
                                SET first_name = @pfirst_name, last_name = @plast_name, email = @pemail, 
                                    phone_number = @pphone_number, hire_date = @phiredate, job_id = @pjob_id, 
                                    salary = @psalary, manager_id = @pmanager_id, department_id = @pdepartment_id
                                WHERE employee_id = @pemployee_id;";

                connection.Connect();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection.connection))
                {
                    SqlParameter pemployeeId = new SqlParameter("@pemployee_id", SqlDbType.Int);
                    cmd.Parameters.Add(pemployeeId);
                    pemployeeId.Value = employee.employee_id;

                    SqlParameter pfirstName = new SqlParameter("@pfirst_name", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add(pfirstName);
                    pfirstName.Value = employee.first_name;

                    SqlParameter plastName = new SqlParameter("@plast_name", SqlDbType.VarChar, 25);
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

                    SqlParameter pjobId = new SqlParameter("@pjob_id", SqlDbType.Int);
                    cmd.Parameters.Add(pjobId);
                    pjobId.Value = employee.job_id;

                    SqlParameter psalary = new SqlParameter("@psalary", SqlDbType.Decimal);
                    cmd.Parameters.Add(psalary);
                    psalary.Precision = 8;
                    psalary.Scale = 2;
                    psalary.Value = employee.salary;

                    SqlParameter pmanagerId = new SqlParameter("@pmanager_id", SqlDbType.Int);
                    cmd.Parameters.Add(pmanagerId);
                    pmanagerId.Value = DataBaseConnection.NullToDBNull(employee.manager_id);

                    SqlParameter pdepartmentId = new SqlParameter("@pdepartment_id", SqlDbType.Int);
                    cmd.Parameters.Add(pdepartmentId);
                    pdepartmentId.Value = DataBaseConnection.NullToDBNull(employee.department_id);

                    cmd.ExecuteNonQuery();
                }

                connection.Disconnect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
