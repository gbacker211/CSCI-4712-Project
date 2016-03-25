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
        private Attributes _softwareDocument;
        public SoftwareDocForm()
        {
            InitializeComponent();
        }

        public SoftwareDocForm(Attributes attributes)
        {
            InitializeComponent();
            _softwareDocument = attributes;
            SetUpdateFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var obj = new SoftwareDoc
            {
                Name = txtSoftDocName.Text,
                Date = Convert.ToString(SoftwarDocDate.Value.Date.ToShortDateString()),
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

        private void SetUpdateFields()
        {

            txtSoftDocName.Text = _softwareDocument.Name;
            txtSoftDocDescription.Text = _softwareDocument.Description;
            txtSoftDocLocation.Text = _softwareDocument.Location;
            txtSoftDocRevision.Text = _softwareDocument.Revision;
            SoftwarDocDate.Value =  _softwareDocument.Date != "N/A" ? Convert.ToDateTime(_softwareDocument.Date) : DateTime.Today;

        }
    }
}
