﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareConfigurationManagementDBApp
{
    class DisplayControl
    {

        public DataTable GetSoftwareOverview(int groupID)
        {
            DataTable dt = new DataTable();


            String connectionString =
                ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareOverview", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupID", groupID);

                    using (SqlDataAdapter getData = new SqlDataAdapter(command))
                    {
                        getData.Fill(dt);
                    }

                  

                }
            }


            return dt;
        }

        public DataTable GetSoftwareView(int groupID)
        {
            DataTable dt = new DataTable();


            String connectionString =
                ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareView", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupID", groupID);

                    using (SqlDataAdapter getData = new SqlDataAdapter(command))
                    {
                        getData.Fill(dt);
                    }

                 }
            }


            return dt;
        }
    }
}