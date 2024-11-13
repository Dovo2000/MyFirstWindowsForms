using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public partial class employees
    {
        public employees(string first_name, string last_name, string email, string phone_number, DateTime hire_date,
            int job_id, decimal salary, int? manager_id, int? department_id) : this()
        {
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

        public employees(int employee_id, string first_name, string last_name, string email, string phone_number, DateTime hire_date,
            int job_id, decimal salary, int? manager_id, int? department_id) :
            this(first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id)
        {
            this.employee_id = employee_id;
        }

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
