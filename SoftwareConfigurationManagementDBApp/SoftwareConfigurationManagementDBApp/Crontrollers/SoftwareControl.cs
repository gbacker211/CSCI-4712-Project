using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareConfigurationManagementDBApp
{
    class SoftwareControl
    {
        public bool DeleteSoftware(int SoftwareID)
        {
            bool value;

            String connectionString =
              ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Delete_Software", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareID", SoftwareID);


                    int success = command.ExecuteNonQuery();
                    value = Convert.ToBoolean(success);

                    return value;
                }
            }

        }

    }
}
