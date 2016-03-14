namespace SoftwareConfigurationManagementDBApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttributes));
            this.dgvViewAttr = new System.Windows.Forms.DataGridView();
            this.comboViewAttr = new System.Windows.Forms.ComboBox();
            this.lblviews = new System.Windows.Forms.Label();
            this.btnViewAttr = new System.Windows.Forms.Button();
            this.btnEditViewAttr = new System.Windows.Forms.Button();
            this.btnDeleteAttr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAttr
            // 
            this.dgvViewAttr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAttr.Location = new System.Drawing.Point(38, 108);
            this.dgvViewAttr.Name = "dgvViewAttr";
            this.dgvViewAttr.Size = new System.Drawing.Size(565, 497);
            this.dgvViewAttr.TabIndex = 0;
            // 
            // comboViewAttr
            // 
            this.comboViewAttr.FormattingEnabled = true;
            this.comboViewAttr.Location = new System.Drawing.Point(109, 51);
            this.comboViewAttr.Name = "comboViewAttr";
            this.comboViewAttr.Size = new System.Drawing.Size(121, 21);
            this.comboViewAttr.TabIndex = 1;
            // 
            // lblviews
            // 
            this.lblviews.AutoSize = true;
            this.lblviews.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviews.Location = new System.Drawing.Point(28, 51);
            this.lblviews.Name = "lblviews";
            this.lblviews.Size = new System.Drawing.Size(68, 23);
            this.lblviews.TabIndex = 2;
            this.lblviews.Text = "Views:";
            this.lblviews.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnViewAttr
            // 
            this.btnViewAttr.Location = new System.Drawing.Point(38, 636);
            this.btnViewAttr.Name = "btnViewAttr";
            this.btnViewAttr.Size = new System.Drawing.Size(85, 38);
            this.btnViewAttr.TabIndex = 3;
            this.btnViewAttr.Text = "View Attribute";
            this.btnViewAttr.UseVisualStyleBackColor = true;
            // 
            // btnEditViewAttr
            // 
            this.btnEditViewAttr.Location = new System.Drawing.Point(243, 636);
            this.btnEditViewAttr.Name = "btnEditViewAttr";
            this.btnEditViewAttr.Size = new System.Drawing.Size(85, 38);
            this.btnEditViewAttr.TabIndex = 4;
            this.btnEditViewAttr.Text = "Edit Attribute";
            this.btnEditViewAttr.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAttr
            // 
            this.btnDeleteAttr.Location = new System.Drawing.Point(463, 636);
            this.btnDeleteAttr.Name = "btnDeleteAttr";
            this.btnDeleteAttr.Size = new System.Drawing.Size(85, 38);
            this.btnDeleteAttr.TabIndex = 5;
            this.btnDeleteAttr.Text = "Delete Attribute";
            this.btnDeleteAttr.UseVisualStyleBackColor = true;
            // 
            // ViewAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 706);
            this.Controls.Add(this.btnDeleteAttr);
            this.Controls.Add(this.btnEditViewAttr);
            this.Controls.Add(this.btnViewAttr);
            this.Controls.Add(this.lblviews);
            this.Controls.Add(this.comboViewAttr);
            this.Controls.Add(this.dgvViewAttr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAttributes";
            this.Text = "ViewAttributes";
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
    }
}