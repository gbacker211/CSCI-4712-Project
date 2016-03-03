using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareConfigurationManagementDBApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please filled in your Username and Password");
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

                try
                {
                    using (conn)
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("usp_Select_User", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@PassWoard", txtPassword.Text);
                        User aUser = new User();
                        DataTable dt = new DataTable();

                        using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                        {
                            getData.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            aUser.User_ID = Convert.ToInt32(dt.Rows[0][1].ToString());
                            aUser.AccessGroup = Convert.ToInt32(dt.Rows[0][0].ToString());
                            if (dt.Columns.Count > 2)
                            {
                                aUser.GroupName = dt.Rows[0][2].ToString();
                                aUser.GroupID = Convert.ToInt32(dt.Rows[0][3].ToString());
                            }

                            this.Hide();
                            DashBoard dashBoard = new DashBoard();
                           dashBoard.ShowDashBoard(aUser);
                        }
                        else
                        {
                            MessageBox.Show("User does not exsist", "Error!", MessageBoxButtons.OK);
                        }
                        // *** NOTE: ADD CODE TO CHANGE DASHBOARD BASED ON USER *** //
                        // *** SHOULD BE DONE HERE AND IN DASHBOARD *** // ======== //
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
