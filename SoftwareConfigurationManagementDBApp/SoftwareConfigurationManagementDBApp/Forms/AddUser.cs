﻿using System;
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

            UserControl userGroups = new UserControl();


            DataTable dt = new DataTable();

            dt = userGroups.getGroups();

            cmdGroups.Items.Insert(0, " ");

            foreach (DataRow row in dt.Rows)
            {
                cmdGroups.Items.Add(row[1].ToString());
            }

          
            
           
            
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


                if (cmdGroups.SelectedItem != null && txtGroupName.Text == String.Empty)
                {
                    //use dropdown
                    var obj = new User()
                    {
                        User_ID = 1,
                        Fname = txtFname.Text.Trim(),
                        Lname = txtLname.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        AccessGroup = AccessLvl,
                        GroupName = cmdGroups.SelectedItem.ToString().Trim()
                    };

                    if (mAddUpdate == 1)
                    {
                        mUserControl.AddUser(obj);
                        MessageBox.Show("User has been added!", "Success!", MessageBoxButtons.OK);
                        this.Close();

                    }
                    if (mAddUpdate == 2)
                    {
                        mUserControl.UpdateUser(obj);
                        MessageBox.Show("User has been updated!", "Success!", MessageBoxButtons.OK);
                        ViewUsers.ActiveForm.Close();
                        this.Close();
                    }
                }
                else if(cmdGroups.SelectedText == null && txtGroupName.Text != String.Empty)
                {
                    //use text
                    var obj = new User()
                    {
                        User_ID = 1,
                        Fname = txtFname.Text.Trim(),
                        Lname = txtLname.Text.Trim(),
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        AccessGroup = AccessLvl,
                        GroupName = txtGroupName.Text.Trim()
                    };

                    if (mAddUpdate == 1)
                    {
                        mUserControl.AddUser(obj);
                        MessageBox.Show("User has been added!", "Success!", MessageBoxButtons.OK);
                        Close();
                    }
                    if (mAddUpdate == 2)
                    {
                        mUserControl.UpdateUser(obj);
                        MessageBox.Show("User has been updated!", "Success!", MessageBoxButtons.OK);
                        // ViewUsers.ActiveForm.Close();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Must enter group name, or select one from the drop down", "Error",
                        MessageBoxButtons.OK);
                }

                  

             

              

              
            }
        }
    }
}
