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
        User mUser;
        private int mAddUpdate;

        public SoftwareForm(Software aSoftware, User aUser, int aAddUpdate)
        {
            InitializeComponent();

            mSoftware = aSoftware;
            mUser = aUser;
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
            // ** ADD CASE FOR EMPTY FIELDS ** //
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

                        // *** NOTE: ADD INDIVIDAUL CONNECTION STRING FOR DEBUGGING *** // =============================================================================== //
                        conn.ConnectionString = "Data Source=CBRENTEVANSPC\\SQLEXPRESS;Initial Catalog=SCMDatabase;Integrated Security=True"; // Brent's Connection String

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
                                    cmd.Parameters.AddWithValue("@UserId", mUser.User_ID);

                                    int success = cmd.ExecuteNonQuery();
                                    value = Convert.ToBoolean(success);

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
                            Software_ID = mSoftware.Software_ID,
                            SoftwareName = txtSoftwareName.Text,
                            SystemName = txtSystemName.Text,
                            Group = txtGroup.Text,
                            Owner = txtOwner.Text,
                            Classification = cmbClass.SelectedItem.ToString(),
                            ResponsibleEngineer = txtResponsibleEngineer.Text,
                            Description = txtSoftwareDescription.Text,
                            DesignAuthority = txtDesignAuthority.Text
                        };

                        bool value = false;
                        SqlConnection conn = new SqlConnection();

                        // *** NOTE: ADD INDIVIDAUL CONNECTION STRING FOR DEBUGGING *** // =============================================================================== //
                        conn.ConnectionString = "Data Source=CBRENTEVANSPC\\SQLEXPRESS;Initial Catalog=SCMDatabase;Integrated Security=True"; // Brent's Connection String

                        try
                        {
                            using (conn)
                            {
                                using (SqlCommand cmd = new SqlCommand("usp_Update_Software", conn))
                                {
                                    conn.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@SoftwareID", obj.Software_ID);                                 
                                    cmd.Parameters.AddWithValue("@Classfication", obj.Classification);
                                    cmd.Parameters.AddWithValue("@DesignAuthority", obj.DesignAuthority);
                                    cmd.Parameters.AddWithValue("@SystemName", obj.SystemName);
                                    cmd.Parameters.AddWithValue("@Engineer", obj.ResponsibleEngineer);
                                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                                    cmd.Parameters.AddWithValue("@Owner", obj.Owner);
                                    cmd.Parameters.AddWithValue("@ManagingGroup", obj.Group);

                                    int success = cmd.ExecuteNonQuery();
                                    value = Convert.ToBoolean(success);

                                }
                            }
                        }
                        finally
                        {
                            conn.Close();
                        }

                        break;

                    }

                default:
                    break;
            }
        }

        private void SoftwareForm_Load(object sender, EventArgs e)
        {
            // * For cmbClass * // ================== //
            cmbClass.Items.Add("Select Classifcation");
            cmbClass.Items.Add("A");
            cmbClass.Items.Add("B");
            cmbClass.Items.Add("C");
            cmbClass.Items.Add("D");
            cmbClass.Items.Add("SC");
            cmbClass.Items.Add("SS");
            cmbClass.Items.Add("PC");
            cmbClass.Items.Add("GS");

            txtSoftwareName.Text = mSoftware.SoftwareName;
            txtSystemName.Text = mSoftware.SystemName;
            txtOwner.Text = mSoftware.Owner;
            txtGroup.Text = mSoftware.Group;
            txtResponsibleEngineer.Text = mSoftware.ResponsibleEngineer;
            txtDesignAuthority.Text = mSoftware.DesignAuthority;
            txtSoftwareDescription.Text = mSoftware.Description;
            cmbClass.SelectedItem = mSoftware.Classification;
        }
    }
}
