using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                conn.ConnectionString = "Data Source=CBRENTEVANSPC\\SQLEXPRESS;Initial Catalog=SCMDatabase;Integrated Security=True";

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

                        aUser.User_ID = Convert.ToInt32(dt.Rows[0][1].ToString());
                        aUser.AccessGroup = Convert.ToInt32(dt.Rows[0][0].ToString());


                        Forms.DashBoard aNewDashboard = new Forms.DashBoard(aUser);
                        aNewDashboard.Show();

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
