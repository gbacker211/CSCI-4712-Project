namespace SoftwareConfigurationManagementDBApp
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.viewlb = new System.Windows.Forms.Label();
            this.cmbDataViews = new System.Windows.Forms.ComboBox();
            this.btnViewAttr = new System.Windows.Forms.Button();
            this.btnAddAttr = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteSoft = new System.Windows.Forms.Button();
            this.btnEditSoftw = new System.Windows.Forms.Button();
            this.btnAddSoftw = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.ddlGroups = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.grpAttributes = new System.Windows.Forms.GroupBox();
            this.grpDataViewing = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAdmin.SuspendLayout();
            this.grpAttributes.SuspendLayout();
            this.grpDataViewing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(139, 693);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(115, 38);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // viewlb
            // 
            this.viewlb.AutoSize = true;
            this.viewlb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlb.Location = new System.Drawing.Point(132, 115);
            this.viewlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewlb.Name = "viewlb";
            this.viewlb.Size = new System.Drawing.Size(77, 35);
            this.viewlb.TabIndex = 37;
            this.viewlb.Text = "View";
            // 
            // cmbDataViews
            // 
            this.cmbDataViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataViews.FormattingEnabled = true;
            this.cmbDataViews.Items.AddRange(new object[] {
            "Software Overview",
            "Software View"});
            this.cmbDataViews.Location = new System.Drawing.Point(76, 181);
            this.cmbDataViews.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataViews.Name = "cmbDataViews";
            this.cmbDataViews.Size = new System.Drawing.Size(205, 24);
            this.cmbDataViews.TabIndex = 36;
            this.cmbDataViews.SelectedIndexChanged += new System.EventHandler(this.selectView);
            // 
            // btnViewAttr
            // 
            this.btnViewAttr.Location = new System.Drawing.Point(27, 34);
            this.btnViewAttr.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAttr.Name = "btnViewAttr";
            this.btnViewAttr.Size = new System.Drawing.Size(115, 38);
            this.btnViewAttr.TabIndex = 35;
            this.btnViewAttr.Text = "View Attributes";
            this.btnViewAttr.UseVisualStyleBackColor = true;
            // 
            // btnAddAttr
            // 
            this.btnAddAttr.Location = new System.Drawing.Point(27, 22);
            this.btnAddAttr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAttr.Name = "btnAddAttr";
            this.btnAddAttr.Size = new System.Drawing.Size(115, 38);
            this.btnAddAttr.TabIndex = 32;
            this.btnAddAttr.Text = "Add Attribute";
            this.btnAddAttr.UseVisualStyleBackColor = true;
            this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(28, 278);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(115, 38);
            this.btnEditUser.TabIndex = 31;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(28, 218);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(115, 38);
            this.btnAddUser.TabIndex = 30;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteSoft
            // 
            this.btnDeleteSoft.Location = new System.Drawing.Point(28, 142);
            this.btnDeleteSoft.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSoft.Name = "btnDeleteSoft";
            this.btnDeleteSoft.Size = new System.Drawing.Size(115, 57);
            this.btnDeleteSoft.TabIndex = 29;
            this.btnDeleteSoft.Text = "Delete Software";
            this.btnDeleteSoft.UseVisualStyleBackColor = true;
            this.btnDeleteSoft.Click += new System.EventHandler(this.btnDeleteSoft_Click);
            // 
            // btnEditSoftw
            // 
            this.btnEditSoftw.Location = new System.Drawing.Point(28, 79);
            this.btnEditSoftw.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSoftw.Name = "btnEditSoftw";
            this.btnEditSoftw.Size = new System.Drawing.Size(115, 38);
            this.btnEditSoftw.TabIndex = 28;
            this.btnEditSoftw.Text = "Edit Software";
            this.btnEditSoftw.UseVisualStyleBackColor = true;
            this.btnEditSoftw.Click += new System.EventHandler(this.btnEditSoftw_Click);
            // 
            // btnAddSoftw
            // 
            this.btnAddSoftw.Location = new System.Drawing.Point(28, 22);
            this.btnAddSoftw.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSoftw.Name = "btnAddSoftw";
            this.btnAddSoftw.Size = new System.Drawing.Size(115, 38);
            this.btnAddSoftw.TabIndex = 27;
            this.btnAddSoftw.Text = "Add Software";
            this.btnAddSoftw.UseVisualStyleBackColor = true;
            this.btnAddSoftw.Click += new System.EventHandler(this.btnAddSoftw_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1021, 608);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 40;
            this.label1.Text = "DashBoard";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(27, 89);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(115, 38);
            this.btnPrintReport.TabIndex = 41;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // ddlGroups
            // 
            this.ddlGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGroups.FormattingEnabled = true;
            this.ddlGroups.Location = new System.Drawing.Point(160, 150);
            this.ddlGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlGroups.Name = "ddlGroups";
            this.ddlGroups.Size = new System.Drawing.Size(108, 24);
            this.ddlGroups.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Group:";
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnAddSoftw);
            this.grpAdmin.Controls.Add(this.btnEditSoftw);
            this.grpAdmin.Controls.Add(this.btnDeleteSoft);
            this.grpAdmin.Controls.Add(this.btnAddUser);
            this.grpAdmin.Controls.Add(this.btnEditUser);
            this.grpAdmin.Location = new System.Drawing.Point(12, 256);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(160, 338);
            this.grpAdmin.TabIndex = 44;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin Functions";
            // 
            // grpAttributes
            // 
            this.grpAttributes.Controls.Add(this.btnAddAttr);
            this.grpAttributes.Location = new System.Drawing.Point(190, 256);
            this.grpAttributes.Name = "grpAttributes";
            this.grpAttributes.Size = new System.Drawing.Size(176, 78);
            this.grpAttributes.TabIndex = 45;
            this.grpAttributes.TabStop = false;
            this.grpAttributes.Text = "Add Attributes";
            // 
            // grpDataViewing
            // 
            this.grpDataViewing.Controls.Add(this.btnViewAttr);
            this.grpDataViewing.Controls.Add(this.btnPrintReport);
            this.grpDataViewing.Location = new System.Drawing.Point(190, 373);
            this.grpDataViewing.Name = "grpDataViewing";
            this.grpDataViewing.Size = new System.Drawing.Size(176, 139);
            this.grpDataViewing.TabIndex = 46;
            this.grpDataViewing.TabStop = false;
            this.grpDataViewing.Text = "View Attributes and Print";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 756);
            this.Controls.Add(this.grpDataViewing);
            this.Controls.Add(this.grpAttributes);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.viewlb);
            this.Controls.Add(this.cmbDataViews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAdmin.ResumeLayout(false);
            this.grpAttributes.ResumeLayout(false);
            this.grpDataViewing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label viewlb;
        private System.Windows.Forms.ComboBox cmbDataViews;
        private System.Windows.Forms.Button btnViewAttr;
        private System.Windows.Forms.Button btnAddAttr;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteSoft;
        private System.Windows.Forms.Button btnEditSoftw;
        private System.Windows.Forms.Button btnAddSoftw;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.ComboBox ddlGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.GroupBox grpAttributes;
        private System.Windows.Forms.GroupBox grpDataViewing;
    }
}