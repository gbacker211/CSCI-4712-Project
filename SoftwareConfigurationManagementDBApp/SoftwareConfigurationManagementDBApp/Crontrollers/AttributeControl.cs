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
        private User aUser;

        public AttributeControl(User user = null)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
            aUser = user;
        }

        public void openAttributeForm(int softwareId, string softwareName)
        {
            mSoftware_ID = softwareId;
            Attribute_s_ AddAttributes = new Attribute_s_(mSoftware_ID, softwareName);
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
                using (SqlCommand command = new SqlCommand("usp_Insert_NewConfigItemDOC", connect))
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

        public void viewAttributes(int softwareID, string softwareName)
        {
            mSoftware_ID = softwareID;

            ViewAttributes viewSoftwareAttributes = new ViewAttributes(mSoftware_ID, softwareName, aUser);
            viewSoftwareAttributes.Show();

        }


        public DataTable SoftwareItemOverview(int softwareID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareItemOverview", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareId", softwareID);

                    using (SqlDataAdapter data = new SqlDataAdapter(command))
                    {
                        data.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable SoftwareViewOne(int softwareID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareItemView1", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareID", softwareID);

                    using (SqlDataAdapter data = new SqlDataAdapter(command))
                    {
                        data.Fill(dt);
                    }
                }
            }

            return dt;

        }

        public DataTable SoftwareViewTwo(int softwareID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareItemView2", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareId", softwareID);

                    using (SqlDataAdapter data = new SqlDataAdapter(command))
                    {
                        data.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public DataTable SoftwareViewThree(int softwareID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareItemView3", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareId", softwareID);

                    using (SqlDataAdapter data = new SqlDataAdapter(command))
                    {
                        data.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
