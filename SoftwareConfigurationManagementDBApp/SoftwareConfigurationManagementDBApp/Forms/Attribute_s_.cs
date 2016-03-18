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
        private Attributes _attributesInfo;
        private bool _update = false;

        //TODO: Need to decide if there is a mistake, should we allow them to make corrections or start over.

        public Attribute_s_(int softwareID, string softwareName)
        {
            _softwareID = softwareID;

            InitializeComponent();
            lblSoftwareName.Text = softwareName;
            _update = false;
        }

        public Attribute_s_(Attributes info, int attributeType)
        {
            _attributesInfo = info;

            InitializeComponent();
            SetText(attributeType);
            _update = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }


        private void SetText(int attributeType)
        {
            lblSoftwareName.Visible = false;
            lblTitle.Visible = false;
            switch (attributeType)
            {
                case 0://Fill all fields
                    {
                        break;
                    }

                case 1: //Fill fields for Software Document
                    {
                        lblSoftwareDoc.Select();
                        
                        chkboxCIAttr.Checked = true;
                        chkboxCIDocAttr.Checked = true;
                        txtSoftDocNameAttr.Text = _attributesInfo.Name;
                        txtSoftDocDescAttr.Text = _attributesInfo.Description;
                        txtSoftDocLocAttr.Text = _attributesInfo.Location;
                        txtSoftDocRevisionAttr.Text = _attributesInfo.Revision;
                        dateSoftDocAttr.Value = Convert.ToDateTime(_attributesInfo.Date);
                        break;
                    }


                case 2:
                    {
                       txtCINameAttr.Focus();
                        chkboxCIDocAttr.Checked = true;
                        chkboxSoftDocAttr.Checked = true;
                        txtCINameAttr.Text = _attributesInfo.Name;
                        txtCILocAttr.Text = _attributesInfo.Location;
                        txtCIDesAttr.Text = _attributesInfo.Description;
                        txtCIRevisionAttr.Text = _attributesInfo.Revision;
                        dateCIAttr.Value = Convert.ToDateTime(_attributesInfo.Date);
                        break;
                    }
                case 3:
                {
                    chkboxCIAttr.Checked = true;
                    chkboxSoftDocAttr.Checked = true;
                        txtCIDocNameAttr.Focus();
                        txtCIDocNameAttr.Text = _attributesInfo.Name;
                        txtCIDocDesAttr.Text = _attributesInfo.Description;
                        txtCIDocLocAttr.Text = _attributesInfo.Location;
                        txtCIDocRevisAttr.Text = _attributesInfo.Revision;
                        dateCIDocAttr.Value = Convert.ToDateTime(_attributesInfo.Date);
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnAttrSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            AttributeControl newAttributes = new AttributeControl();

            if (!_update)
            {
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
            else
            {
                MessageBox.Show("Update", "Message", MessageBoxButtons.OK);
                //Based on attribute type we call different sprocs
            }

         
        }
    }
}
