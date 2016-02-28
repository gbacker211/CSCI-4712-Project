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
    public partial class CIForm : Form
    {
        public CIForm()
        {
            InitializeComponent();
        }

        private void CIForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitCI_Click(object sender, EventArgs e)
        {
            var Obj = new CI()
            {
                Name = txtCIName.Text,
                Date = Convert.ToString(CIDate.Value.Date),
                Revision = txtCIRevision.Text,
                Location = txtCILocation.Text,
                Description = txtCIInfoCI.Text,
            };
        }
    }
}
