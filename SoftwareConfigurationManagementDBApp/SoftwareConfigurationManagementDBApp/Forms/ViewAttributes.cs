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
     
    public partial class ViewAttributes : Form
    {
        private int _softwareID;
        private User aUser;

        public ViewAttributes(int softwareID, string softwareName, User user)
        {
            InitializeComponent();
         _softwareID = softwareID;
            aUser = user;
            lblSoftwareName.Text = softwareName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectView(object sender, EventArgs e)
        {
            //if (comboViewAttr.SelectedValue != null)
            //{
                int viewSelection = Convert.ToInt32(comboViewAttr.SelectedIndex);
                AttributeControl attributes = new AttributeControl();

                switch (viewSelection)
                {
                    case 0:
                        dgvViewAttr.DataSource = attributes.SoftwareItemOverview(_softwareID);
                        //Hide columns
                        dgvViewAttr.Columns[0].Visible = false;
                        dgvViewAttr.Columns[6].Visible = false;
                        dgvViewAttr.Columns[12].Visible = false;
                        //Alter column headers
                        dgvViewAttr.Columns["SoftwareDocName"].HeaderText = "Software Document Name";
                        dgvViewAttr.Columns["SoftwareDocRevision"].HeaderText = "Software Document Revision";
                        dgvViewAttr.Columns["SoftwareDocLocation"].HeaderText = "Software Document Location";
                        dgvViewAttr.Columns["SoftwareDocDate"].HeaderText = "Software Document Date";
                        dgvViewAttr.Columns["SoftwareDocDesc"].HeaderText = "Software Document Description";

                        dgvViewAttr.Columns["ConfigItemName"].HeaderText = "Configuration Item Name";
                        dgvViewAttr.Columns["ConfigItemRev"].HeaderText = "Configuration Item Revision";
                        dgvViewAttr.Columns["ConfigItemLocal"].HeaderText = "Configuration Item Location";
                        dgvViewAttr.Columns["ConfigItemDate"].HeaderText = "Configuration Item Date";
                        dgvViewAttr.Columns["ConfigItemDes"].HeaderText = "Configuration Item Description";

                        dgvViewAttr.Columns["ConfigItemDocName"].HeaderText = "Configuration Item Document Name";
                        dgvViewAttr.Columns["ConfigItemDocRev"].HeaderText = "Configuration Item Document Revision";
                        dgvViewAttr.Columns["ConfigItemDocLocal"].HeaderText = "Configuration Item Document Location";
                        dgvViewAttr.Columns["ConfigItemDocDate"].HeaderText = "Configuration Item Document Date";
                        dgvViewAttr.Columns["ConfigItemDocDesc"].HeaderText = "Configuration Item Document Description";

                        break;
                    case 1:
                        dgvViewAttr.DataSource = attributes.SoftwareViewOne(_softwareID);
                        break;

                    case 2:
                        dgvViewAttr.DataSource = attributes.SoftwareViewTwo(_softwareID);
                        break;
                    case 3:
                        dgvViewAttr.DataSource = attributes.SoftwareViewThree(_softwareID);
                        break;
                        

                    default:
                        break;

                }
            //}
            

        }

        private void ViewAttributes_Load(object sender, EventArgs e)
        {
            if (comboViewAttr.Items.Count < 0)
            {
                comboViewAttr.Items.Add("Software Item Overview");
                comboViewAttr.Items.Add("Software Item View 1");  //SOftware Documents
                comboViewAttr.Items.Add("Software Item View 2"); // ConfigItems
                comboViewAttr.Items.Add("Software Item View 3"); // ConfigItems Documents
            }

        }

        private void btnEditViewAttr_Click(object sender, EventArgs e)
        {
            //Need to do edits based on views
            if (dgvViewAttr.SelectedRows.Count != 0)
            {
                switch (comboViewAttr.SelectedIndex)
                {
                    case 0:
                        //don't know yet:
                        break;
                    case 1:
                        //Edit Software Documents
                    {
                        var attribute = new Attributes()
                        {
                            ID = Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString()),
                            Name = dgvViewAttr.SelectedRows[0].Cells[2].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[3].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[4].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[5].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[6].Value.ToString()
                        };
                       AttributeControl attributeControl = new AttributeControl();
                        attributeControl.openAttributForEdit(attribute, 1);
                       
                    }
                        break;

                    case 2:

                        //Edit ConfigItem
                    {
                        var attribute = new Attributes()
                        {
                            ID = Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString()),
                            Name = dgvViewAttr.SelectedRows[0].Cells[2].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[3].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[4].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[5].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[6].Value.ToString()
                        };
                        AttributeControl attributeControl = new AttributeControl();
                        attributeControl.openAttributForEdit(attribute, 2);
                    }
                        break;

                    case 3:
                        // Edit ConfigItemDoc
                    {
                        var attribute = new Attributes()
                        {
                            ID = Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString()),
                            Name = dgvViewAttr.SelectedRows[0].Cells[1].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[2].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[3].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[4].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[5].Value.ToString()
                        };
                        AttributeControl attributeControl = new AttributeControl();
                        attributeControl.openAttributForEdit(attribute, 3);
                    }
                        break;

                    default:
                        break;
                }
                


            }
            else
            {
                MessageBox.Show("You must select an attribute in order to edit", "ERROR!", MessageBoxButtons.OK);
            }

        }
    }
}
