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
    public partial class CIDoc : Form
    {
        public CIDoc()
        {
            InitializeComponent();
        }

        private void CIDoc_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmitCIDoc_Click(object sender, EventArgs e)
        {
            var obj = new CIDocs()
            {
                Name = txtCIDocName.Text,
                Date = Convert.ToString(CIDocDate.Value.Date),
                Revision = txtCIDocRevision.Text,
                Location = txtCIDocLocation.Text,
                Description = txtCIInfoCI.Text
            };
        }

        private void btnSubmitCIDoc_MouseHover(object sender, EventArgs e)
        {
            btnSubmitCIDoc.BackColor = Color.CornflowerBlue;
        }

        private void btnSubmitCIDoc_MouseLeave(object sender, EventArgs e)
        {
            btnSubmitCIDoc.BackColor = Color.Empty;
        }
    }
}
