﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    internal class Job
    {
        public int job_id;
        public string job_title;
        public decimal? min_salary;
        public decimal? max_salary;


        public Job(string job_title, decimal? min_salary, decimal? max_salary)
        {
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }
        
        public Job(int job_id, string job_title, decimal? min_salary, decimal? max_salary)
        {
            this.job_id = job_id;
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }

        public override string ToString()
        {
            return $"ID: {job_id} | Job Title: {job_title} | Min Salary: {(min_salary == null ? "NULL" : min_salary.ToString())} | Max Salary {(max_salary == null ? "NULL" : max_salary.ToString())}";
        }
    }
}