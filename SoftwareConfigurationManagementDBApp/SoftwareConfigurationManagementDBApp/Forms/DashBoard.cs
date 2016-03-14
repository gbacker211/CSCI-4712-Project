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
        private User userInfo { get; set; }

        public DashBoard()
        {
            InitializeComponent();

            if (userInfo.AccessGroup == 2)
            {
                grpAdmin.Hide();
                grpAttributes.Location = new Point(92, 258);
                grpDataViewing.Location = new Point(92, 378);
            }
            if (userInfo.AccessGroup == 3)
            {
                grpAdmin.Hide();
                grpAttributes.Hide();
                grpDataViewing.Location = new Point(92, 258);
            }
        }

        public void ShowDashBoard(User aUser)
        {
            
            userInfo = aUser;



            this.ShowDialog();
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
            Form aNewSoftware = new SoftwareForm(aSoftware, userInfo, 1, this);
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

                

                Form aNewSoftware = new SoftwareForm(aSoftware, userInfo, 2, this);
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
            copyGridData();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new MSExcel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (MSExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            MSExcel.Range CR = (MSExcel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void copyGridData()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;

            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            if(dataObject != null)
                Clipboard.SetDataObject(dataObject);
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

            dt = displayOperation.GetGroups(userInfo);


            if (dt.Rows.Count > 0)
            {
                ddlGroups.DataSource = dt;
                ddlGroups.DisplayMember = "GroupName";
                ddlGroups.ValueMember = "ID";
            }


            
        }

        private void btnAddAttr_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows.Count < 2)
            {
                AttributeControl attControl = new AttributeControl();

                attControl.openAttributeForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserControl newUser = new UserControl();
            newUser.OpenUserForm(userInfo, 1);
        }
    }
}
