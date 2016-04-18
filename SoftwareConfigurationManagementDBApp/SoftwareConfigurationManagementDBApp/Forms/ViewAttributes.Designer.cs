﻿namespace SoftwareConfigurationManagementDBApp
{
    partial class ViewAttributes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttributes));
            this.dgvViewAttr = new System.Windows.Forms.DataGridView();
            this.comboViewAttr = new System.Windows.Forms.ComboBox();
            this.lblviews = new System.Windows.Forms.Label();
            this.btnViewAttr = new System.Windows.Forms.Button();
            this.btnEditViewAttr = new System.Windows.Forms.Button();
            this.btnDeleteAttr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAttr
            // 
            this.dgvViewAttr.AllowUserToAddRows = false;
            this.dgvViewAttr.AllowUserToDeleteRows = false;
            this.dgvViewAttr.AllowUserToResizeColumns = false;
            this.dgvViewAttr.AllowUserToResizeRows = false;
            this.dgvViewAttr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewAttr.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAttr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAttr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViewAttr.GridColor = System.Drawing.SystemColors.Control;
            this.dgvViewAttr.Location = new System.Drawing.Point(38, 108);
            this.dgvViewAttr.MultiSelect = false;
            this.dgvViewAttr.Name = "dgvViewAttr";
            this.dgvViewAttr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvViewAttr.Size = new System.Drawing.Size(566, 497);
            this.dgvViewAttr.TabIndex = 0;
            // 
            // comboViewAttr
            // 
            this.comboViewAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboViewAttr.FormattingEnabled = true;
            this.comboViewAttr.Items.AddRange(new object[] {
            "Software Item Overview",
            "Software Item View 1",
            "Software Item View 2",
            "Software Item View 3"});
            this.comboViewAttr.Location = new System.Drawing.Point(110, 50);
            this.comboViewAttr.Name = "comboViewAttr";
            this.comboViewAttr.Size = new System.Drawing.Size(121, 21);
            this.comboViewAttr.TabIndex = 1;
            this.comboViewAttr.SelectedIndexChanged += new System.EventHandler(this.selectView);
            // 
            // lblviews
            // 
            this.lblviews.AutoSize = true;
            this.lblviews.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviews.Location = new System.Drawing.Point(28, 50);
            this.lblviews.Name = "lblviews";
            this.lblviews.Size = new System.Drawing.Size(68, 23);
            this.lblviews.TabIndex = 2;
            this.lblviews.Text = "Views:";
            this.lblviews.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnViewAttr
            // 
            this.btnViewAttr.Location = new System.Drawing.Point(529, 46);
            this.btnViewAttr.Name = "btnViewAttr";
            this.btnViewAttr.Size = new System.Drawing.Size(86, 37);
            this.btnViewAttr.TabIndex = 3;
            this.btnViewAttr.Text = "Close";
            this.btnViewAttr.UseVisualStyleBackColor = true;
            this.btnViewAttr.Click += new System.EventHandler(this.btnClose_Click);
            this.btnViewAttr.MouseLeave += new System.EventHandler(this.btnViewAttr_MouseLeave);
            this.btnViewAttr.MouseHover += new System.EventHandler(this.btnViewAttr_MouseHover);
            // 
            // btnEditViewAttr
            // 
            this.btnEditViewAttr.Location = new System.Drawing.Point(247, 635);
            this.btnEditViewAttr.Name = "btnEditViewAttr";
            this.btnEditViewAttr.Size = new System.Drawing.Size(86, 37);
            this.btnEditViewAttr.TabIndex = 4;
            this.btnEditViewAttr.Text = "Edit Attribute";
            this.btnEditViewAttr.UseVisualStyleBackColor = true;
            this.btnEditViewAttr.Click += new System.EventHandler(this.btnEditViewAttr_Click);
            this.btnEditViewAttr.MouseLeave += new System.EventHandler(this.btnEditViewAttr_MouseLeave);
            this.btnEditViewAttr.MouseHover += new System.EventHandler(this.btnEditViewAttr_MouseHover);
            // 
            // btnDeleteAttr
            // 
            this.btnDeleteAttr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAttr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAttr.Location = new System.Drawing.Point(463, 635);
            this.btnDeleteAttr.Name = "btnDeleteAttr";
            this.btnDeleteAttr.Size = new System.Drawing.Size(86, 37);
            this.btnDeleteAttr.TabIndex = 5;
            this.btnDeleteAttr.Text = "Delete Attribute";
            this.btnDeleteAttr.UseVisualStyleBackColor = true;
            this.btnDeleteAttr.Click += new System.EventHandler(this.btnDeleteAttr_Click);
            this.btnDeleteAttr.MouseLeave += new System.EventHandler(this.btnDeleteAttr_MouseLeave);
            this.btnDeleteAttr.MouseHover += new System.EventHandler(this.btnDeleteAttr_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Attributes For:";
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareName.Location = new System.Drawing.Point(166, 8);
            this.lblSoftwareName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(0, 24);
            this.lblSoftwareName.TabIndex = 7;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(38, 635);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(86, 37);
            this.btnPrintReport.TabIndex = 8;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            this.btnPrintReport.MouseLeave += new System.EventHandler(this.btnPrintReport_MouseLeave);
            this.btnPrintReport.MouseHover += new System.EventHandler(this.btnPrintReport_MouseHover);
            // 
            // ViewAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 706);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.lblSoftwareName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAttr);
            this.Controls.Add(this.btnEditViewAttr);
            this.Controls.Add(this.btnViewAttr);
            this.Controls.Add(this.lblviews);
            this.Controls.Add(this.comboViewAttr);
            this.Controls.Add(this.dgvViewAttr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAttributes";
            this.Text = "ViewAttributes";
            this.Load += new System.EventHandler(this.ViewAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAttr;
        private System.Windows.Forms.ComboBox comboViewAttr;
        private System.Windows.Forms.Label lblviews;
        private System.Windows.Forms.Button btnViewAttr;
        private System.Windows.Forms.Button btnEditViewAttr;
        private System.Windows.Forms.Button btnDeleteAttr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.Button btnPrintReport;
    }
}