using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public partial class jobs
    {
        public override string ToString()
        {
            return $"{job_id}/{job_title}/{(min_salary == null ? "NULL" : min_salary.ToString())}/{(max_salary == null ? "NULL" : max_salary.ToString())}";
        }
    }
}
