using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareConfigurationManagementDBApp
{
    class LoginControl
    {
        public void submit(string aUsername, string aPassword)
        {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
                    using (conn)
                    {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_Select_User", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", aUsername);
                    cmd.Parameters.AddWithValue("@PassWoard", aPassword);
                    User aUser = new User();
                    DataSet ds = new DataSet();
                    //   DataTable dt = new DataTable();

                    using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                    {
                        getData.Fill(ds);
                    }

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataTable groups = new DataTable();
                        aUser.User_ID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                        aUser.AccessGroup = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                        if (ds.Tables.Count > 1)
                        {
                            groups = ds.Tables[1];
                        }

                        DashBoard dashBoard = new DashBoard();
                        LoginForm.
                        dashBoard.ShowDashBoard(aUser, groups);
                    }
                    else
                    {
                        MessageBox.Show("User does not exsist", "Error!", MessageBoxButtons.OK);
                    }
                }
                finally
                {
                    conn.Close();
                }
                    }

        }
    }
}
