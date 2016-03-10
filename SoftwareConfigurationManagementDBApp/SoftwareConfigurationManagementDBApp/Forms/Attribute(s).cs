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
    public partial class Attribute_s_ : Form
    {
        public Attribute_s_()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAttrSubmit_Click(object sender, EventArgs e)
        {
            AttributeControl newAttributes = new AttributeControl();

            if (chkboxSoftDocAttr.Checked == false)
            {
                var objSoftware = new SoftwareDoc()
                {
                    Name = txtSoftDocNameAttr.Text,
                    Date = Convert.ToString(dateSoftDocAttr.Value.Date),
                    Revision = txtSoftDocRevisionAttr.Text,
                    Location = txtSoftDocLocAttr.Text,
                    Description = txtSoftDocDescAttr.Text,
                };

                newAttributes.submitSoftDoc(objSoftware);

            }

            if (chkboxCIAttr.Checked == false)
            {
                var objCI = new CI()
                {
                    Name = txtCINameAttr.Text,
                    Date = Convert.ToString(dateCIAttr.Value.Date),
                    Revision = txtCIRevisionAttr.Text,
                    Location = txtCILocAttr.Text,
                    Description = txtCIDesAttr.Text
                };

                newAttributes.submitCI(objCI);


            }

            if (chkboxCIDocAttr.Checked == false)
            {
                var objCIDoc = new CIDocs()
                {
                    Name = txtCIDocNameAttr.Text,
                    Date = Convert.ToString(dateCIDocAttr.Value.Date),
                    Revision = txtCIRevisionAttr.Text,
                    Location = txtCIDocLocAttr.Text,
                    Description = txtCIDocDesAttr.Text
                };

                newAttributes.submitCIDoc(objCIDoc);

   
            }
        }
    }
}
