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
        private int _softwareID;

        //TODO: Need to decide if there is a mistake, should we allow them to make corrections or start over.

        public Attribute_s_(int softwareID, string softwareName)
        {
            _softwareID = softwareID;
         
            InitializeComponent();
            lblSoftwareName.Text = softwareName;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAttrSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

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

                if (newAttributes.submitSoftDoc(objSoftware, _softwareID))
                {
                    result.Append("Software Document has been added" + Environment.NewLine);
                }
                

                

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

                if (newAttributes.submitCI(objCI, _softwareID))
                {
                    result.Append("ConfigItem added" + Environment.NewLine);
                }


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

                if (newAttributes.submitCIDoc(objCIDoc))
                {
                    result.Append("ConfigItem Doc Added" + Environment.NewLine);
                }

   
            }


            MessageBox.Show(result.ToString(), "Adding Attribute(s) Result", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
