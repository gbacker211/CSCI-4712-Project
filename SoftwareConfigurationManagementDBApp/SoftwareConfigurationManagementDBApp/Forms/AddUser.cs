using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareConfigurationManagementDBApp
{
    public partial class AddUser : Form
    {
        private UserControl mUserControl;
        private int mAddUpdate;
        private User mUser;
        public AddUser(UserControl aControl, User aUser, int aAddUpdate)
        {
            InitializeComponent();
            mUserControl = aControl;
            mUser = aUser;
            mAddUpdate = aAddUpdate;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
            cmbAccessGroup.Items.Add("Select Group");
            cmbAccessGroup.Items.Add("Admin");
            cmbAccessGroup.Items.Add("Editor");
            cmbAccessGroup.Items.Add("Read-Only");

            if (mAddUpdate == 2)
            {
                txtFname.Text = mUser.Fname;
                txtLname.Text = mUser.Lname;
                txtUsername.Text = mUser.Username;
                txtPassword.Text = mUser.Password;
                cmbAccessGroup.SelectedIndex = mUser.AccessGroup;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbAccessGroup.SelectedIndex == 0)
                MessageBox.Show("Please make sure that the fields are filled and a User Group is selected.");
            else
            {
                int AccessLvl = 3; // for assigning User access level.
                switch (cmbAccessGroup.SelectedIndex)
                {
                    case 1:
                        AccessLvl = 1;
                        break;
                    case 2:
                        AccessLvl = 2;
                        break;
                    case 3:
                        AccessLvl = 3;
                        break;
                    default:
                        break;
                }
                  

                var obj = new User()
                {
                    User_ID = 1,
                    Fname = txtFname.Text,
                    Lname = txtLname.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    AccessGroup = AccessLvl
                };

                if (mAddUpdate == 1)
                {
                    mUserControl.AddUser(obj);
                }
                if (mAddUpdate == 2)
                {
                    mUserControl.UpdateUser(obj);
                }

                this.Close();
            }
        }
    }
}
