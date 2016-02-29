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
    public partial class SoftwareForm : Form
    {
        private Software mSoftware;
        private int mAddUpdate;

        public SoftwareForm(Software aSoftware, int aAddUpdate)
        {
            InitializeComponent();
            nSoftware = aSoftware;
            AddUpdate = aAddUpdate;
        }

        public Software nSoftware { set { value = mSoftware; } get { return mSoftware; } }

        public int AddUpdate
        {
            set
            {
                if (value > 0 && value < 3)
                    value = mAddUpdate;
            }
            get { return mAddUpdate; }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (AddUpdate)
            {
                case 1: // add
                    {
                        var obj = new Software()
                        {
                            Software_ID = 1,
                            SoftwareName = txtSoftwareName.Text,
                            SystemName = txtSystemName.Text,
                            Group = txtGroup.Text,
                            Owner = txtOwner.Text,
                            Classification = cmbClass.SelectedItem.ToString(),
                            ResponsibleEngineer = txtResponsibleEngineer.Text,
                            Description = txtSoftwareDescription.Text,
                            DesignAuthority = txtDesignAuthority.Text
                        };
                        // Add DB Code // 

                        break;
                    }
                case 2: // update 
                    {
                        var obj = new Software()
                        {
                            SoftwareName = txtSoftwareName.Text,
                            SystemName = txtSystemName.Text,
                            Group = txtGroup.Text,
                            Owner = txtOwner.Text,
                            Classification = cmbClass.SelectedItem.ToString(),
                            ResponsibleEngineer = txtResponsibleEngineer.Text,
                            Description = txtSoftwareDescription.Text,
                            DesignAuthority = txtDesignAuthority.Text
                        };
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
