using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareConfigurationManagementDBApp
{
    public partial class CIDoc : Form
    {
        private Attributes _cidocInfo;
        public CIDoc()
        {
            InitializeComponent();
        }

        public CIDoc(Attributes info)
        {
            InitializeComponent();
            _cidocInfo = info;
            SetFields();
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

        private void SetFields()
        {
            txtCIDocName.Text = _cidocInfo.Name;
            txtCIDocLocation.Text = _cidocInfo.Location;
            txtCIDocRevision.Text = _cidocInfo.Revision;
            txtCIInfoCI.Text = _cidocInfo.Description;
            CIDocDate.Value = _cidocInfo.Date != "N/A" ? Convert.ToDateTime(_cidocInfo.Date) : DateTime.Today;
            //Should set a hidden field for ID?
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.CornflowerBlue;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Empty;
        }
    }
}
