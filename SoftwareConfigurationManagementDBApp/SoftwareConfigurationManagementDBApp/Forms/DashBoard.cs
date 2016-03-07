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
        }

        public void ShowDashBoard(User aUser, DataTable groups)
        {
            if (groups.Rows.Count > 0)
            {
                ddlGroups.DataSource = groups;
                ddlGroups.DisplayMember = "GroupName";
                ddlGroups.ValueMember = "ID";
                


            }
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
                    dataGridView1.DataSource = GetSoftwareOverview();
                    dataGridView1.Columns[8].Visible = false;
                    break;
                case 1:
                    dataGridView1.DataSource = GetSoftwareView();
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



        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (cmbDataViews.Items.Count < 0)
            {
                cmbDataViews.Items.Add("Software Overview");
                cmbDataViews.Items.Add("Software View");
            }

        }

        //TODO: Place the following into the ViewController Class

        private DataTable GetSoftwareOverview()
        {
            DataTable dt = new DataTable();


            String connectionString =
                ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareOverview", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupID", Convert.ToInt32(ddlGroups.SelectedValue.ToString()));

                    using (SqlDataAdapter getData = new SqlDataAdapter(command))
                    {
                        getData.Fill(dt);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no software for your group, please contact Administrator", "Error!",
                            MessageBoxButtons.OK);
                    }

                }
            }


            return dt;
        }

        private DataTable GetSoftwareView()
        {
            DataTable dt = new DataTable();


            String connectionString =
                ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Select_SoftwareView", connect))
                {
                    connect.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GroupID", Convert.ToInt32(ddlGroups.SelectedValue.ToString()));

                    using (SqlDataAdapter getData = new SqlDataAdapter(command))
                    {
                        getData.Fill(dt);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no software for your group, please contact Administrator", "Error!",
                            MessageBoxButtons.OK);
                    }

                }
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
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count < 2)
            {
                DeleteSoftware(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()));
                UpdateGrid(sender,e);
            }
            else
            {
                MessageBox.Show("Must select one row to delete software", "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteSoftware(int SoftwareID)
        {
            bool value;

            String connectionString =
              ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Delete_Software", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SoftwareID", SoftwareID);


                    int success = command.ExecuteNonQuery();
                    value = Convert.ToBoolean(success);
                }
            }

        }

        public void UpdateGrid(object sender, EventArgs e)
        {
            selectView(sender, e);
        }
    }
}
