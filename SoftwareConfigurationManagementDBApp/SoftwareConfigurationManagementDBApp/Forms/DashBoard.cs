using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MSExcel =  Microsoft.Office.Interop.Excel;


namespace SoftwareConfigurationManagementDBApp
{
    public partial class DashBoard : Form
    {
        private User _userInfo;

        public DashBoard(User aUser)
        {
            InitializeComponent();
            _userInfo = aUser;
            if (_userInfo.AccessGroup == 2)
            {
                grpAdmin.Hide();
                grpAttributes.Location = new Point(92, 258);
                grpDataViewing.Location = new Point(92, 378);
            }
            if (_userInfo.AccessGroup == 3)
            {
                grpAdmin.Hide();
                grpAttributes.Hide();
                grpDataViewing.Location = new Point(92, 258);
            }
        }

       

        private void viewlb_Click(object sender, EventArgs e)
        {

        }

        private void selectView(object sender, EventArgs e)
        {
            if(ddlGroups.SelectedValue != null)
            { 
            int viewSelection = Convert.ToInt32(cmbDataViews.SelectedIndex);
            switch (viewSelection)
            {
                case 0:
                    dataGridView1.DataSource = ViewSoftwareOverview();
                    dataGridView1.Columns[8].Visible = false;
                    setColumnHeadersForSoftwareOverview();
                    break;
                case 1:
                    dataGridView1.DataSource = ViewSoftwareView();
                    dataGridView1.Columns["SoftwareID"].Visible = false;
                    setColumnHeadersForSoftwareView();
                    break;
                default:
                    break;

            }
            }
            else
            {
                MessageBox.Show("Must Select a Group First", "ERROR!", MessageBoxButtons.OK);
            }
           
        }

        private void btnAddSoftw_Click(object sender, EventArgs e)
        {
            Software aSoftware = new Software();
            Form aNewSoftware = new SoftwareForm(aSoftware, _userInfo, 1, this);
            aNewSoftware.Show();
        }

        private void btnEditSoftw_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && cmbDataViews.SelectedIndex == 0)
            {


                var aSoftware = new Software()
                {
                    SoftwareName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                    Classification = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    DesignAuthority = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                    Description = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    ResponsibleEngineer = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                    SystemName = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                    Owner = dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                    Group = dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                    Software_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString())
                };

                

                Form aNewSoftware = new SoftwareForm(aSoftware, _userInfo, 2, this);
                aNewSoftware.Show();
            }
            else
            {
                MessageBox.Show("No Software Selected or Software Overview is not selected", "Error", MessageBoxButtons.OK);
            }

          
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
           // LoginForm.ActiveForm.Show();
            //temp
           

        }

        private void setColumnHeadersForSoftwareOverview()
        {
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Design Authority";
            dataGridView1.Columns[5].HeaderText = "System Name";
            dataGridView1.Columns[7].HeaderText = "Group Name";
        }

        private void setColumnHeadersForSoftwareView()
        {
            dataGridView1.Columns[1].HeaderText = "Software Doc Count";
            dataGridView1.Columns[2].HeaderText = "CI Count";
            dataGridView1.Columns[3].HeaderText = "CID Count";
        }

        private void setColumnHeadersForUser()
        {
            dataGridView1.Columns[0].HeaderText = "First Name";
            dataGridView1.Columns[1].HeaderText = "Last Name";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].HeaderText = "Access Group";
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (cmbDataViews.Items.Count < 0)
            {
                cmbDataViews.Items.Add("Software Overview");
                cmbDataViews.Items.Add("Software View");
            }

            UpdateGroups(sender, e);

        }

        private DataTable ViewSoftwareOverview()
        {
            DataTable dt = new DataTable();

            DisplayControl displayData = new DisplayControl();
            dt = displayData.GetSoftwareOverview(Convert.ToInt32(ddlGroups.SelectedValue.ToString()));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no software for your group, please contact Administrator", "Error!",
                    MessageBoxButtons.OK);
            }


            return dt;

        }

        private DataTable ViewSoftwareView()
        {
            DataTable dt = new DataTable();
            DisplayControl displayData = new DisplayControl();

            dt = displayData.GetSoftwareView(Convert.ToInt32(ddlGroups.SelectedValue.ToString()));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no software for your group, please contact Administrator", "Error!",
                   MessageBoxButtons.OK);
            }

            return dt;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
           PrintControl daPrintControl = new PrintControl(dataGridView1);
            daPrintControl.ExportGridData();
        }

       
        private void btnDeleteSoft_Click(object sender, EventArgs e)
        {
            SoftwareControl software = new SoftwareControl();

            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count < 2)
            {
                if (software.DeleteSoftware(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString())))
                {
                    MessageBox.Show("Software has been successfully deleted", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failure has occured", "Error!", MessageBoxButtons.OK);
                }
                UpdateGrid(sender,e);
            }
            else
            {
                MessageBox.Show("Must select one row to delete software", "Error", MessageBoxButtons.OK);
            }
        }

       

        public void UpdateGrid(object sender, EventArgs e)
        {
            selectView(sender, e);
            UpdateGroups(sender, e);
        }

        private void UpdateGroups(object sender, EventArgs e)
        {
            //TODO: Move to DisplayController
            DataTable dt = new DataTable();

            DisplayControl displayOperation = new DisplayControl();

            dt = displayOperation.GetGroups(_userInfo);


            if (dt.Rows.Count > 0)
            {
                ddlGroups.DataSource = dt;
                ddlGroups.DisplayMember = "GroupName";
                ddlGroups.ValueMember = "ID";
            }


            
        }

        private void btnAddAttr_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                if(cmbDataViews.SelectedIndex == 0)
                { 
                    AttributeControl attControl = new AttributeControl();

                    attControl.openAttributeForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),
                        dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                }
                else
                {
                    AttributeControl attControl = new AttributeControl();

                    attControl.openAttributeForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                        dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserControl newUser = new UserControl();
            newUser.OpenUserForm(_userInfo, 1);
        }

        private void btnViewAttr_Click(object sender, EventArgs e)
        {
            //Pass the software id into the form
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (cmbDataViews.SelectedIndex == 0)
                {
                    AttributeControl attControl = new AttributeControl(_userInfo);

                    attControl.viewAttributes(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),
                        dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                }
                else
                {
                    AttributeControl attControl = new AttributeControl(_userInfo);

                    attControl.viewAttributes(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                        dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());

                }
            }
        }

        //
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            UserControl allUsers = new UserControl();
            DataTable dt = allUsers.getUsers();
           // setColumnHeadersForUser();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var obj = new User()
                {
                    Fname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                    Lname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    Username = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    Password = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                    AccessGroup = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value) // unsure about
                };

                UserControl editUser = new UserControl();
                editUser.OpenUserForm(obj, 2);
            }
            else
            {
                MessageBox.Show("Please select a User!", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
