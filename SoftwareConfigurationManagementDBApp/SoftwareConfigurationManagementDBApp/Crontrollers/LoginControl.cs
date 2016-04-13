using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace SoftwareConfigurationManagementDBApp
{
    class LoginControl
    {
        private LoginForm _loginForm;
        public LoginControl(LoginForm login)
        {
            _loginForm = login;
        }


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
                        aUser.User_ID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                        aUser.AccessGroup = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

                        DashBoard dashBoard = new DashBoard(aUser, _loginForm);
                        LoginForm.ActiveForm.Hide();
                        dashBoard.Show();
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


        public void DisplaySetUpApplication()
        {
            //Need a form for this

        }

        public void SetUpApplication(string server, string userName = "", string password = "")
        {
            StringBuilder connectionString = new StringBuilder();

            var settings = ConfigurationManager.ConnectionStrings[0];

            var fi = typeof (ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

            fi.SetValue(settings, false);

            connectionString.Append("Data Source=" + server +
                                        ";Initial Catalog=SCMDatabase;Integrated Security=True");
            if (userName != String.Empty && password != String.Empty)
            {
                connectionString.Append(";User Id=" + userName + ";Password=" + password + ";");
            }

            settings.ConnectionString = connectionString.ToString();

            ConfigurationManager.ConnectionStrings[0].Name = "SCMDatabaseConnectionString";
            ConfigurationManager.ConnectionStrings[0].ProviderName = "System.Data.SqlClient";
        }

        public void ReturnToLoginn()
        {
           _loginForm.Show();
           
        }
    }
}
