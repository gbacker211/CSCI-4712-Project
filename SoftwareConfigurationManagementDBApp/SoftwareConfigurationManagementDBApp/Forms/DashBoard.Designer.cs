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
            this.btnViewUser = new System.Windows.Forms.Button();
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
            this.btnLogOut.Location = new System.Drawing.Point(104, 563);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 31);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // viewlb
            // 
            this.viewlb.AutoSize = true;
            this.viewlb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlb.Location = new System.Drawing.Point(99, 93);
            this.viewlb.Name = "viewlb";
            this.viewlb.Size = new System.Drawing.Size(63, 26);
            this.viewlb.TabIndex = 37;
            this.viewlb.Text = "View";
            // 
            // cmbDataViews
            // 
            this.cmbDataViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataViews.FormattingEnabled = true;
            this.cmbDataViews.Items.AddRange(new object[] {
            "Software Overview",
            "Software View",
            "All Software"});
            this.cmbDataViews.Location = new System.Drawing.Point(57, 147);
            this.cmbDataViews.Name = "cmbDataViews";
            this.cmbDataViews.Size = new System.Drawing.Size(155, 21);
            this.cmbDataViews.TabIndex = 36;
            this.cmbDataViews.SelectedIndexChanged += new System.EventHandler(this.selectView);
            // 
            // btnViewAttr
            // 
            this.btnViewAttr.Location = new System.Drawing.Point(20, 28);
            this.btnViewAttr.Name = "btnViewAttr";
            this.btnViewAttr.Size = new System.Drawing.Size(86, 31);
            this.btnViewAttr.TabIndex = 35;
            this.btnViewAttr.Text = "View Attributes";
            this.btnViewAttr.UseVisualStyleBackColor = true;
            this.btnViewAttr.Click += new System.EventHandler(this.btnViewAttr_Click);
            // 
            // btnAddAttr
            // 
            this.btnAddAttr.Location = new System.Drawing.Point(20, 18);
            this.btnAddAttr.Name = "btnAddAttr";
            this.btnAddAttr.Size = new System.Drawing.Size(86, 31);
            this.btnAddAttr.TabIndex = 32;
            this.btnAddAttr.Text = "Add Attribute";
            this.btnAddAttr.UseVisualStyleBackColor = true;
            this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(21, 177);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(86, 31);
            this.btnAddUser.TabIndex = 30;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteSoft
            // 
            this.btnDeleteSoft.Location = new System.Drawing.Point(21, 115);
            this.btnDeleteSoft.Name = "btnDeleteSoft";
            this.btnDeleteSoft.Size = new System.Drawing.Size(86, 46);
            this.btnDeleteSoft.TabIndex = 29;
            this.btnDeleteSoft.Text = "Delete Software";
            this.btnDeleteSoft.UseVisualStyleBackColor = true;
            this.btnDeleteSoft.Click += new System.EventHandler(this.btnDeleteSoft_Click);
            // 
            // btnEditSoftw
            // 
            this.btnEditSoftw.Location = new System.Drawing.Point(21, 64);
            this.btnEditSoftw.Name = "btnEditSoftw";
            this.btnEditSoftw.Size = new System.Drawing.Size(86, 31);
            this.btnEditSoftw.TabIndex = 28;
            this.btnEditSoftw.Text = "Edit Software";
            this.btnEditSoftw.UseVisualStyleBackColor = true;
            this.btnEditSoftw.Click += new System.EventHandler(this.btnEditSoftw_Click);
            // 
            // btnAddSoftw
            // 
            this.btnAddSoftw.Location = new System.Drawing.Point(21, 18);
            this.btnAddSoftw.Name = "btnAddSoftw";
            this.btnAddSoftw.Size = new System.Drawing.Size(86, 31);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 494);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "DashBoard";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(20, 72);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(86, 31);
            this.btnPrintReport.TabIndex = 41;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // ddlGroups
            // 
            this.ddlGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGroups.FormattingEnabled = true;
            this.ddlGroups.Location = new System.Drawing.Point(120, 122);
            this.ddlGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlGroups.Name = "ddlGroups";
            this.ddlGroups.Size = new System.Drawing.Size(82, 21);
            this.ddlGroups.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Group:";
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnViewUser);
            this.grpAdmin.Controls.Add(this.btnAddSoftw);
            this.grpAdmin.Controls.Add(this.btnEditSoftw);
            this.grpAdmin.Controls.Add(this.btnDeleteSoft);
            this.grpAdmin.Controls.Add(this.btnAddUser);
            this.grpAdmin.Location = new System.Drawing.Point(9, 208);
            this.grpAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmin.Size = new System.Drawing.Size(120, 279);
            this.grpAdmin.TabIndex = 44;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin Functions";
            // 
            // btnViewUser
            // 
            this.btnViewUser.Location = new System.Drawing.Point(21, 226);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(86, 29);
            this.btnViewUser.TabIndex = 31;
            this.btnViewUser.Text = "View Users";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // grpAttributes
            // 
            this.grpAttributes.Controls.Add(this.btnAddAttr);
            this.grpAttributes.Location = new System.Drawing.Point(142, 208);
            this.grpAttributes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttributes.Name = "grpAttributes";
            this.grpAttributes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttributes.Size = new System.Drawing.Size(132, 63);
            this.grpAttributes.TabIndex = 45;
            this.grpAttributes.TabStop = false;
            this.grpAttributes.Text = "Add Attributes";
            // 
            // grpDataViewing
            // 
            this.grpDataViewing.Controls.Add(this.btnViewAttr);
            this.grpDataViewing.Controls.Add(this.btnPrintReport);
            this.grpDataViewing.Location = new System.Drawing.Point(142, 350);
            this.grpDataViewing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataViewing.Name = "grpDataViewing";
            this.grpDataViewing.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataViewing.Size = new System.Drawing.Size(132, 113);
            this.grpDataViewing.TabIndex = 46;
            this.grpDataViewing.TabStop = false;
            this.grpDataViewing.Text = "View Attributes and Print";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 614);
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
        private System.Windows.Forms.Button btnViewUser;
    }
}