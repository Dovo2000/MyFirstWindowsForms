﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManager
{
    internal class DataBaseManagement
    {
        public SqlConnection connection;

        string connectionString;

        public DataBaseManagement()
        {
            connectionString = "Data Source=85.208.21.117,54321;" +
                "Initial Catalog=DavidMartinEmployees;" +
                "User ID=sa;" +
                "Password=Sql#123456789;" +
                "TrustServerCertificate=True;";

            connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    return;
                
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Disconnect()
        {
            if (connection.State == ConnectionState.Closed)
                return;

            connection.Close();
        }        
    }
}
