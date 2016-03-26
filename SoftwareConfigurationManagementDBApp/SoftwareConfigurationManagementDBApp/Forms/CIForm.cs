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
    public partial class CIForm : Form
    {
        private Attributes _CI;

        public CIForm()
        {
            InitializeComponent();
        }

        public CIForm(Attributes info)
        {
            InitializeComponent();
            _CI = info;
            SetFields();
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

        private void btnSubmitCI_MouseHover(object sender, EventArgs e)
        {
            btnSubmitCI.BackColor = Color.CornflowerBlue;
        }

        private void btnSubmitCI_MouseLeave(object sender, EventArgs e)
        {
            btnSubmitCI.BackColor = Color.Empty;
        }

        private void SetFields()
        {
            txtCIInfoCI.Text = _CI.Description;
            txtCIRevision.Text = _CI.Revision;
            txtCILocation.Text = _CI.Location;
            txtCIName.Text = _CI.Name;
            CIDate.Value = _CI.Date != "N/A" ? Convert.ToDateTime(_CI.Date) : DateTime.Today;
        }
    }
}
