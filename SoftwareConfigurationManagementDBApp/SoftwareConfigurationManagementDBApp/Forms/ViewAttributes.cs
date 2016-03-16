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
                comboViewAttr.Items.Add("Software Item View 1");
                comboViewAttr.Items.Add("Software Item View 2");
                comboViewAttr.Items.Add("Software Item View 3");
            }

        }
    }
}
