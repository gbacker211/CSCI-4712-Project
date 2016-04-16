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
using System.Xml;
using System.IO;

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
            Pathway pathwayOperation = new Pathway(_loginForm);

            pathwayOperation.ShowDialog();

        }

        public bool SetUpApplication(string server, string userName = "", string password = "")
        {
         

            string ApplicationPath = Application.StartupPath;
            string YourPath = Path.GetDirectoryName(ApplicationPath);
            bool isNew = false;

            string path = Path.GetDirectoryName(YourPath) + "\\App.config";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList list = doc.DocumentElement.SelectNodes(string.Format("connectionStrings/add[@name='{0}']", server));
            XmlNode node;
            isNew = list.Count == 0;
            if (isNew)
            {
                node = doc.CreateNode(XmlNodeType.Element, "add", null);
                XmlAttribute attribute = doc.CreateAttribute("name");
                attribute.Value = "SCMDatabaseConnectionString";
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("connectionString");
                attribute.Value = "";
                node.Attributes.Append(attribute);

                attribute = doc.CreateAttribute("providerName");
                attribute.Value = "System.Data.SqlClient";
                node.Attributes.Append(attribute);
            }
            else
            {
                node = list[0];
            }
            string conString = node.Attributes["connectionString"].Value;
            SqlConnectionStringBuilder conStringBuilder = new SqlConnectionStringBuilder(conString);
            conStringBuilder.InitialCatalog = "SCMDatabase";
            conStringBuilder.DataSource = server;
            conStringBuilder.IntegratedSecurity = true;
            if (userName != String.Empty && password != String.Empty)
            {
                conStringBuilder.UserID = userName;
                conStringBuilder.Password = password;
            }
          
         


            try
            {
                using (SqlConnection conn = new SqlConnection(conStringBuilder.ConnectionString))
                {
                    conn.Open();
                }

                node.Attributes["connectionString"].Value = conStringBuilder.ConnectionString;
                if (isNew)
                {
                    doc.DocumentElement.SelectNodes("connectionStrings")[0].AppendChild(node);
                }
                doc.Save(path);

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    "There was error in creating the connection to the database please ensure that the information is valid",
                    "Error", MessageBoxButtons.OK);

                return false;

            }


         
            
        }

        public void ReturnToLoginn()
        {
           _loginForm.Show();
           
        }
    }
}
