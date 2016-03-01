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
        }

        private void viewlb_Click(object sender, EventArgs e)
        {

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
    }
}
