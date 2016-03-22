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
    public partial class SoftwareDocForm : Form
    {
        public SoftwareDocForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var obj = new SoftwareDoc
            {
                Name = txtSoftDocName.Text,
                Date = Convert.ToString(SoftwarDocDate.Value.Date),
                Revision = txtSoftDocRevision.Text,
                Location = txtSoftDocRevision.Text,
                Description = txtSoftDocDescription.Text,
            };
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.CornflowerBlue;

        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Empty;
        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.CornflowerBlue;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Empty;

        }
    }
}
