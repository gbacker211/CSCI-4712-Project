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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cmbAccessGroup.Items.Add("Select Group");
            cmbAccessGroup.Items.Add("Admin");
            cmbAccessGroup.Items.Add("Editor");
            cmbAccessGroup.Items.Add("Read-Only");
        }
    }
}
