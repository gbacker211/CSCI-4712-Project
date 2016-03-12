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
    class AttributeControl
    {
        private int mSoftware_ID;
        private String _connectionString;

        public AttributeControl()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
        }

        public void openAttributeForm(int softwareId)
        {
            mSoftware_ID = softwareId;
            Attribute_s_ AddAttributes = new Attribute_s_(mSoftware_ID);
            AddAttributes.Show();
        }
        public bool submitSoftDoc(SoftwareDoc aDoc, int softwareID)
        {
            bool value;
            //Changed to bool to indicate whether insert was a success.
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Insert_NewSoftwareDOC", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareID", softwareID);
                    command.Parameters.AddWithValue("@Name", aDoc.Name);
                    command.Parameters.AddWithValue("@Revision", aDoc.Revision);
                    command.Parameters.AddWithValue("@Date", aDoc.Date);
                    command.Parameters.AddWithValue("@Description", aDoc.Description);
                    command.Parameters.AddWithValue("@Location", aDoc.Location);

                    int success = command.ExecuteNonQuery();
                    value = Convert.ToBoolean(success);

                }
            }


            return value;

        }

        public bool submitCI(CI aCI, int softwareID)
        {
            bool value;
            //Changed to bool to indicate whether insert was a success.
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Insert_NewConfigItem", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareID", softwareID);
                    command.Parameters.AddWithValue("@Name", aCI.Name);
                    command.Parameters.AddWithValue("@Revision", aCI.Revision);
                    command.Parameters.AddWithValue("@Date", aCI.Date);
                    command.Parameters.AddWithValue("@Description", aCI.Description);
                    command.Parameters.AddWithValue("@Location", aCI.Location);

                    int success = command.ExecuteNonQuery();
                    value = Convert.ToBoolean(success);

                }
            }


            return value;

        }

        public bool submitCIDoc(CIDocs aCIDoc, int CI_ID = 0)
        {

            bool value;
            //Changed to bool to indicate whether insert was a success.
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Insert_NewConfigItem", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CI", CI_ID);
                    command.Parameters.AddWithValue("@Name", aCIDoc.Name);
                    command.Parameters.AddWithValue("@Revision", aCIDoc.Revision);
                    command.Parameters.AddWithValue("@Date", aCIDoc.Date);
                    command.Parameters.AddWithValue("@Description", aCIDoc.Description);
                    command.Parameters.AddWithValue("@Location", aCIDoc.Location);

                    int success = command.ExecuteNonQuery();
                    value = Convert.ToBoolean(success);

                }
            }


            return value;
        }
    }
}
