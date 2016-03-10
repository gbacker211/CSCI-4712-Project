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
            if (txtUsername.Text == "" && txtPassword.Text == "")
                MessageBox.Show("Please enter your username and password.");
            else
            {
                LoginControl newLogin = new LoginControl();
                newLogin.submit(txtUsername.Text,txtPassword.Text);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
