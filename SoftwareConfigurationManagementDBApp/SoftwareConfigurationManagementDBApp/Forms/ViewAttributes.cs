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
        private DashBoard _dashBoard;
        private string _software;
       

        public ViewAttributes(int softwareID, string softwareName, User user)
        {
            InitializeComponent();
            _softwareID = softwareID;
            aUser = user;
            lblSoftwareName.Text = softwareName;
            _software = softwareName;
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
                    dgvViewAttr.Columns["SoftwareDocName"].HeaderText = "Software Document: Name";
                    dgvViewAttr.Columns["SoftwareDocRevision"].HeaderText = "Software Document: Revision";
                    dgvViewAttr.Columns["SoftwareDocLocation"].HeaderText = "Software Document: Location";
                    dgvViewAttr.Columns["SoftwareDocDate"].HeaderText = "Software Document: Date";
                    dgvViewAttr.Columns["SoftwareDocDesc"].HeaderText = "Software Document: Description";

                    dgvViewAttr.Columns["ConfigItemName"].HeaderText = "Configuration Item: Name";
                    dgvViewAttr.Columns["ConfigItemRev"].HeaderText = "Configuration Item: Revision";
                    dgvViewAttr.Columns["ConfigItemLocal"].HeaderText = "Configuration Item: Location";
                    dgvViewAttr.Columns["ConfigItemDate"].HeaderText = "Configuration Item: Date";
                    dgvViewAttr.Columns["ConfigItemDes"].HeaderText = "Configuration Item: Description";

                    dgvViewAttr.Columns["ConfigItemDocName"].HeaderText = "Configuration Item Document: Name";
                    dgvViewAttr.Columns["ConfigItemDocRev"].HeaderText = "Configuration Item Document: Revision";
                    dgvViewAttr.Columns["ConfigItemDocLocal"].HeaderText = "Configuration Item Document: Location";
                    dgvViewAttr.Columns["ConfigItemDocDate"].HeaderText = "Configuration Item Document: Date";
                    dgvViewAttr.Columns["ConfigItemDocDesc"].HeaderText = "Configuration Item Document: Description";

                    break;
                case 1:
                    dgvViewAttr.DataSource = attributes.SoftwareViewOne(_softwareID);
                    dgvViewAttr.Columns["SoftwareDocID"].Visible = false;
                    dgvViewAttr.Columns["Software_Id"].Visible = false;
                    dgvViewAttr.Columns["Name"].HeaderText = "Software Document: Name";
                    dgvViewAttr.Columns["Revision"].HeaderText = "Software Document: Revision";
                    dgvViewAttr.Columns["Date"].HeaderText = "Software Document: Date";
                    dgvViewAttr.Columns["Description"].HeaderText = "Software Document: Description";
                    dgvViewAttr.Columns["Location"].HeaderText = "Software Document: Location";
                    break;

                case 2:
                    dgvViewAttr.DataSource = attributes.SoftwareViewTwo(_softwareID);
                    dgvViewAttr.Columns["CI_ID"].Visible = false;
                    dgvViewAttr.Columns["SoftwareID"].Visible = false;
                    dgvViewAttr.Columns["Name"].HeaderText = "Configuration Item:"  + Environment.NewLine +  "Name";
                    dgvViewAttr.Columns["Revision"].HeaderText = "Configuration Item:  Revision";
                    dgvViewAttr.Columns["Date"].HeaderText = "Configuration Item:" + Environment.NewLine + "Date";
                    dgvViewAttr.Columns["Description"].HeaderText = "Configuration Item:  Description";
                    dgvViewAttr.Columns["Location"].HeaderText = "Configuration Item:  Location";
                    break;
                case 3:
                    dgvViewAttr.DataSource = attributes.SoftwareViewThree(_softwareID);
                    dgvViewAttr.Columns["CID_ID"].Visible = false;
                    dgvViewAttr.Columns["Name"].HeaderText = "Configuration Item Document: Name";
                    dgvViewAttr.Columns["Revision"].HeaderText = "Configuration Item Document: Revision";
                    dgvViewAttr.Columns["Date"].HeaderText = "Configuration Item Document: Date";
                    dgvViewAttr.Columns["Description"].HeaderText = "Configuration Item Document: Description";
                    dgvViewAttr.Columns["Location"].HeaderText = "Configuration Item Document: Location";
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
                    {
                        List<Attributes> attributes = new List<Attributes>();
                        //don't know yet:
                        var softwareDOC = new Attributes()
                        {
                            ID = dgvViewAttr.SelectedRows[0].Cells[0].Value != null ? Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString()) : 0,
                            Name = dgvViewAttr.SelectedRows[0].Cells[1].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[2].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[3].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[4].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[5].Value.ToString()
                            
                        };
                        attributes.Add(softwareDOC);

                        var configItem = new Attributes()
                        {
                            ID =  dgvViewAttr.SelectedRows[0].Cells[6].Value != null ? Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[6].Value.ToString()): 0,
                            Name = dgvViewAttr.SelectedRows[0].Cells[7].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[8].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[9].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[10].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[11].Value.ToString()
                            
                        };

                        attributes.Add(configItem);

                        var configItemDOC = new Attributes()
                        {
                            ID =  dgvViewAttr.SelectedRows[0].Cells[12].Value != null ? Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[12].Value.ToString()): 0,
                            Name = dgvViewAttr.SelectedRows[0].Cells[13].Value.ToString(),
                            Revision = dgvViewAttr.SelectedRows[0].Cells[14].Value.ToString(),
                            Location = dgvViewAttr.SelectedRows[0].Cells[15].Value.ToString(),
                            Date = dgvViewAttr.SelectedRows[0].Cells[16].Value.ToString(),
                            Description = dgvViewAttr.SelectedRows[0].Cells[17].Value.ToString()
                          
                        };

                        attributes.Add(configItemDOC);


                        AttributeControl massEdit = new AttributeControl();
                        massEdit.openAttributForEditAll(attributes, 0, this);

                        break;
                    }
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
                            attributeControl.openAttributForEdit(attribute, 1, this);

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
                            attributeControl.openAttributForEdit(attribute, 2, this);
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
                            attributeControl.openAttributForEdit(attribute, 3, this);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
           // _dashBoard.UpdateGrid(sender, e);
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintControl dataControl = new PrintControl(dgvViewAttr);
            dataControl.ExportGridData();
        }

        private void btnDeleteAttr_Click(object sender, EventArgs e)
        {
            StringBuilder attributeDeleteResult = new StringBuilder();
            AttributeControl deleteAttributeControl = new AttributeControl();
            if (dgvViewAttr.SelectedRows.Count != 0)
            {
                //Will need a switch for which view is being used
                switch (comboViewAttr.SelectedIndex)
                {
                    case 1:
                    {
                        if (deleteAttributeControl.deleteSoftDoc(
                            Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString())))
                        {
                            MessageBox.Show("Software Document has been removed", "Success", MessageBoxButtons.OK);
                        }

                        break;
                    }
                    case 2:
                    {
                        if (deleteAttributeControl.deleteConfigItem(
                           Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString())))
                        {
                            MessageBox.Show("Config Item has been removed", "Success", MessageBoxButtons.OK);
                        }
                        break;
                    }
                case 3:
                    {
                        if (deleteAttributeControl.deleteConfigItemDOC(
                           Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString())))
                        {
                            MessageBox.Show("Config Item has been removed", "Success", MessageBoxButtons.OK);
                        }
                        break;
                    }

                    default:// mass delete 0
                    {
                        if (deleteAttributeControl.deleteSoftDoc(
                          Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString())))
                        {
                            attributeDeleteResult.Append("Software Document has been deleted" + Environment.NewLine);
                        }
                        if (deleteAttributeControl.deleteConfigItem(
                           Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[6].Value.ToString())))
                        {
                            attributeDeleteResult.Append("ConfigItem has been deleted" + Environment.NewLine);
                        }
                        if (deleteAttributeControl.deleteConfigItemDOC(
                          Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[12].Value.ToString())))
                        {
                            attributeDeleteResult.Append("ConfigItem Document has been deleted" + Environment.NewLine);
                        }

                        MessageBox.Show(attributeDeleteResult.ToString(), "Result", MessageBoxButtons.OK);

                        break;
                    }
                      
                }
            }
        }

        public void RefreshGrid(object sender, EventArgs e)
        {
            selectView(sender, e);
        }

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            AttributeControl operAttributeControl = new AttributeControl();

            switch (comboViewAttr.SelectedIndex)
            {
                case 1:
                    operAttributeControl.openAttributeForm(_softwareID, _software, _dashBoard, comboViewAttr.SelectedIndex);
                    break;
                case 2:
                    if (dgvViewAttr.SelectedRows.Count < 0) //Assume we are adding a configItem
                    {
                        operAttributeControl.openAttributeForm(_softwareID, _software, _dashBoard,
                            comboViewAttr.SelectedIndex);
                    }
                    else
                    {
                        operAttributeControl.openAttributeForm(_softwareID, _software, _dashBoard,
                          comboViewAttr.SelectedIndex, Convert.ToInt32(dgvViewAttr.SelectedRows[0].Cells[0].Value.ToString()));
                    }
                    break;
              default:
                    operAttributeControl.openAttributeForm(_softwareID, _software, _dashBoard);
                    break;
            }

           
        }
      
    }
}
