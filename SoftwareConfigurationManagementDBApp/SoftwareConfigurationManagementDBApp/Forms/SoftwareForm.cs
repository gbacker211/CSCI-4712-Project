using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareConfigurationManagementDBApp
{
    public partial class SoftwareForm : Form
    {
        // Variables for adding or updating.
        Software mSoftware;
        User mUser;
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
            bool value = false;
            String connectionString = ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

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

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand AddSoftware = new SqlCommand("usp_Insert_NewSoftware", conn))
                            {
                                try
                                {
                                    conn.Open();
                                    AddSoftware.CommandType = CommandType.StoredProcedure;
                                    AddSoftware.Parameters.AddWithValue("@SoftwareName", obj.SoftwareName);
                                    AddSoftware.Parameters.AddWithValue("@Description", obj.Description);
                                    AddSoftware.Parameters.AddWithValue("@Classification", obj.Classification);
                                    AddSoftware.Parameters.AddWithValue("@SystemName", obj.SystemName);
                                    AddSoftware.Parameters.AddWithValue("@Engineer", obj.ResponsibleEngineer);
                                    AddSoftware.Parameters.AddWithValue("@Owner", obj.Owner);
                                    AddSoftware.Parameters.AddWithValue("@DesignAuthority", obj.DesignAuthority);
                                    AddSoftware.Parameters.AddWithValue("@GroupName", obj.Group);
                                    AddSoftware.Parameters.AddWithValue("@UserId", mUser.User_ID);

                                    int success = AddSoftware.ExecuteNonQuery();
                                    value = Convert.ToBoolean(success);
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
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
                        // ADD DB CODE //

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand UpdateSoftware = new SqlCommand("usp_Update_Software", conn))
                            {
                                try
                                {
                                    conn.Open();
                                    UpdateSoftware.CommandType = CommandType.StoredProcedure;
                                    UpdateSoftware.Parameters.AddWithValue("@SoftwareID", obj.Software_ID);
                                    UpdateSoftware.Parameters.AddWithValue("@Classification", obj.Classification);
                                    UpdateSoftware.Parameters.AddWithValue("@DesignAuthority", obj.DesignAuthority);
                                    UpdateSoftware.Parameters.AddWithValue("@SystemName", obj.SystemName);
                                    UpdateSoftware.Parameters.AddWithValue("@Engineer", obj.ResponsibleEngineer);
                                    UpdateSoftware.Parameters.AddWithValue("@Description", obj.Description);
                                    UpdateSoftware.Parameters.AddWithValue("@Owner", obj.Owner);
                                    UpdateSoftware.Parameters.AddWithValue("@MangingName", obj.Group);

                                    int success = UpdateSoftware.ExecuteNonQuery();
                                    value = Convert.ToBoolean(success);
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                        }

                        break;
                    }

                default:
                    break;
            }
        }

        private void SoftwareForm_Load(object sender, EventArgs e)
        {
            if ( AddUpdate == 2)
            {
                txtSoftwareName.Text = mSoftware.SoftwareName;
                txtSystemName.Text = mSoftware.SystemName;
                txtDesignAuthority.Text = mSoftware.DesignAuthority;
                txtGroup.Text = mSoftware.Group;
                txtResponsibleEngineer.Text = mSoftware.ResponsibleEngineer;
                txtSoftwareDescription.Text = mSoftware.Description;
                cmbClass.SelectedItem = mSoftware.Classification;
            }
        }
    }
}
