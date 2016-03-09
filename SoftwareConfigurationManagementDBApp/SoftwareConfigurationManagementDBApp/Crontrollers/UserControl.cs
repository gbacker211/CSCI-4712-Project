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
    class UserControl
    {
        private String _connectionstring;

        public UserControl()
        {
          _connectionstring =  ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
        }

        public User UserLogin(string userName, string password)
        {


            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_Select_User", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@PassWoard", password);
                User aUser = new User();
                DataSet ds = new DataSet();
                //   DataTable dt = new DataTable();

                using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                {
                    getData.Fill(ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    aUser.User_ID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                    aUser.AccessGroup = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                }


                return aUser;

            }
        }

    }
}
