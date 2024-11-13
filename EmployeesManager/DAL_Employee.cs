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
        DataClassTablesEmployeesDataContext dataClass;

        public DAL_Employee()
        {
            this.connection = new DataBaseConnection();
            dataClass = new DataClassTablesEmployeesDataContext();
        }

        public void Insert(employees employee)
        {
            try
            {
                dataClass.employees.InsertOnSubmit(employee);
                dataClass.SubmitChanges();
                MessageBox.Show("Tarea completada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public List<employees> Select()
        {
            try
            {
                return dataClass.employees.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: " + e.Message);
                return new List<employees>();
            }
        }

        public void Update(employees employee)
        {
            try
            {
                employees employeeToUpdate = dataClass.employees.Where(x => x.employee_id == employee.employee_id).SingleOrDefault();
                
                if (employeeToUpdate == null)
                    return;

                employeeToUpdate.first_name = employee.first_name;
                employeeToUpdate.last_name = employee.last_name;
                employeeToUpdate.email = employee.email;
                employeeToUpdate.phone_number = employee.phone_number;
                employeeToUpdate.hire_date = employee.hire_date;
                employeeToUpdate.job_id = employee.job_id;
                employeeToUpdate.salary = employee.salary;
                employeeToUpdate.manager_id = employee.manager_id;
                employeeToUpdate.departments = employee.departments;

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
