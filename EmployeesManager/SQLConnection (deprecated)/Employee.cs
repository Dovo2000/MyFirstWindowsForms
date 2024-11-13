using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    internal class Employee
    {
        public int employee_id;
        public string first_name;
        public string last_name;
        public string email;
        public string phone_number;
        public DateTime hire_date;
        public int job_id;
        public decimal salary;
        public int? manager_id;
        public int? department_id;

        public Employee(string first_name, string last_name, string email, string phone_number, DateTime hire_date,
            int job_id, decimal salary, int? manager_id, int? department_id)
        {
            employee_id = 0;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
            this.manager_id = manager_id;
            this.department_id = department_id;
        }

        public Employee(int employee_id, string first_name, string last_name, string email, string phone_number, DateTime hire_date,
            int job_id, decimal salary, int? manager_id, int? department_id) : 
            this(first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id)
        {
            this.employee_id = employee_id;
        }
    }
}
