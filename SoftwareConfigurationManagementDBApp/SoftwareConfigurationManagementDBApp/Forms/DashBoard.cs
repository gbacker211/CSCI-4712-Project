using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareConfigurationManagementDBApp.Forms
{
    public partial class DashBoard : Form
    {
        User mUser;
        public DashBoard(User aUser)
        {
            InitializeComponent();
            mUser = aUser;

            // ** Change Look of Dashboard Based on User ** //

            // * Admin * // =============================== //
            if (mUser.AccessGroup == 1)
            {
                btnAddAttr.Hide();
                btnDeleteAttr.Hide();
                btnEditAttr.Hide();
                btnViewAttr.Hide();
                btnPrintReport.Hide();

                btnAddUser.Location = new System.Drawing.Point(191,256);
                btnEditUser.Location = new System.Drawing.Point(191, 318);
            }
        }

        private void btnAddSoftw_Click(object sender, EventArgs e)
        {
            Software aSoftware = new Software();
            Form aNewSoftware = new SoftwareForm(aSoftware, mUser, 1);
            aNewSoftware.Show();
        }

        private void btnEditSoftw_Click(object sender, EventArgs e)
        {
            // *** NOTE: ADD CODE TO SET aSoftware AS SOFTWARE SELECTED IN DATA GRID *** // 
            Software aSoftware = new Software();
            Form aNewSoftware = new SoftwareForm(aSoftware, mUser, 2);
            aNewSoftware.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm.ActiveForm.Show();
            Close();
        }
    }
}
