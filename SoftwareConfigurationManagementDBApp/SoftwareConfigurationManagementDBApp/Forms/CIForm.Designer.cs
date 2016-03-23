namespace SoftwareConfigurationManagementDBApp.Forms
{
    partial class CIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCIName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCIName = new System.Windows.Forms.TextBox();
            this.txtCIRevision = new System.Windows.Forms.TextBox();
            this.txtCILocation = new System.Windows.Forms.TextBox();
            this.txtCIInfoCI = new System.Windows.Forms.TextBox();
            this.btnSubmitCI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CIDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI";
            // 
            // lblCIName
            // 
            this.lblCIName.AutoSize = true;
            this.lblCIName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIName.Location = new System.Drawing.Point(52, 93);
            this.lblCIName.Name = "lblCIName";
            this.lblCIName.Size = new System.Drawing.Size(49, 19);
            this.lblCIName.TabIndex = 1;
            this.lblCIName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Revision";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(51, 188);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 19);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // txtCIName
            // 
            this.txtCIName.Location = new System.Drawing.Point(124, 94);
            this.txtCIName.Name = "txtCIName";
            this.txtCIName.Size = new System.Drawing.Size(170, 20);
            this.txtCIName.TabIndex = 6;
            // 
            // txtCIRevision
            // 
            this.txtCIRevision.Location = new System.Drawing.Point(120, 156);
            this.txtCIRevision.Name = "txtCIRevision";
            this.txtCIRevision.Size = new System.Drawing.Size(174, 20);
            this.txtCIRevision.TabIndex = 7;
            // 
            // txtCILocation
            // 
            this.txtCILocation.Location = new System.Drawing.Point(120, 188);
            this.txtCILocation.Name = "txtCILocation";
            this.txtCILocation.Size = new System.Drawing.Size(174, 20);
            this.txtCILocation.TabIndex = 8;
            // 
            // txtCIInfoCI
            // 
            this.txtCIInfoCI.Location = new System.Drawing.Point(120, 229);
            this.txtCIInfoCI.Multiline = true;
            this.txtCIInfoCI.Name = "txtCIInfoCI";
            this.txtCIInfoCI.Size = new System.Drawing.Size(397, 99);
            this.txtCIInfoCI.TabIndex = 10;
            // 
            // btnSubmitCI
            // 
            this.btnSubmitCI.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCI.Location = new System.Drawing.Point(244, 354);
            this.btnSubmitCI.Name = "btnSubmitCI";
            this.btnSubmitCI.Size = new System.Drawing.Size(96, 37);
            this.btnSubmitCI.TabIndex = 12;
            this.btnSubmitCI.Text = "Submit";
            this.btnSubmitCI.UseVisualStyleBackColor = true;
            this.btnSubmitCI.Click += new System.EventHandler(this.btnSubmitCI_Click);
            this.btnSubmitCI.MouseLeave += new System.EventHandler(this.btnSubmitCI_MouseLeave);
            this.btnSubmitCI.MouseHover += new System.EventHandler(this.btnSubmitCI_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // CIDate
            // 
            this.CIDate.Location = new System.Drawing.Point(120, 125);
            this.CIDate.Margin = new System.Windows.Forms.Padding(2);
            this.CIDate.Name = "CIDate";
            this.CIDate.Size = new System.Drawing.Size(174, 20);
            this.CIDate.TabIndex = 14;
            // 
            // CIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 417);
            this.Controls.Add(this.CIDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmitCI);
            this.Controls.Add(this.txtCIInfoCI);
            this.Controls.Add(this.txtCILocation);
            this.Controls.Add(this.txtCIRevision);
            this.Controls.Add(this.txtCIName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCIName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CIForm";
            this.Text = "CIForm";
            this.Load += new System.EventHandler(this.CIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCIName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCIName;
        private System.Windows.Forms.TextBox txtCIRevision;
        private System.Windows.Forms.TextBox txtCILocation;
        private System.Windows.Forms.TextBox txtCIInfoCI;
        private System.Windows.Forms.Button btnSubmitCI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CIDate;
    }
}