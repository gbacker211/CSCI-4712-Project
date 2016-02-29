using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareConfigurationManagementDBApp
{
    public partial class SoftwareForm : Form
    {
        // Variables for adding or updating.
        Software mSoftware;
        private int mAddUpdate;

        public SoftwareForm(Software aSoftware, int aAddUpdate)
        {
            InitializeComponent();
            mSoftware = aSoftware;
            AddUpdate = aAddUpdate;
        }

        /// <summary>
        ///     Property for AddUpdate
        /// </summary>
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
                        bool value = false;
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "Data Source=CBRENTEVANSPC\\SQLEXPRESS;Initial Catalog=SCMDatabase;Integrated Security=True";

                        try
                        {
                            using (conn)
                            {
                                using (SqlCommand cmd = new SqlCommand("usp_Insert_NewSoftware", conn))
                                {
                                    conn.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@SoftwareName", obj.SoftwareName);
                                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                                    cmd.Parameters.AddWithValue("@Classfication", obj.Classification);
                                    cmd.Parameters.AddWithValue("@SoftwareName", obj.SoftwareName);
                                    cmd.Parameters.AddWithValue("@SystemName", obj.SystemName);
                                    cmd.Parameters.AddWithValue("@Engineer", obj.ResponsibleEngineer);
                                    cmd.Parameters.AddWithValue("@Owner", obj.Owner);
                                    cmd.Parameters.AddWithValue("@DesignAuthority", obj.DesignAuthority);
                                    cmd.Parameters.AddWithValue("@GroupName", obj.Group);
                                }
                            }
                        }
                        finally
                        {
                            conn.Close();
                        }


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
                        // Add DB Code //
                    }

                default:
                    break;
            }
        }
    }
}
