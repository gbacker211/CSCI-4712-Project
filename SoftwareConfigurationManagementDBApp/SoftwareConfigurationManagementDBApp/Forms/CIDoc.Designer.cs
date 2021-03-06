﻿namespace SoftwareConfigurationManagementDBApp.Forms
{
    partial class CIDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIDoc));
            this.btnSubmitCIDoc = new System.Windows.Forms.Button();
            this.txtCIInfoCI = new System.Windows.Forms.TextBox();
            this.txtCIDocRevision = new System.Windows.Forms.TextBox();
            this.txtCIDocName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.CIDocDate = new System.Windows.Forms.DateTimePicker();
            this.lblCIDocLocation = new System.Windows.Forms.Label();
            this.txtCIDocLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmitCIDoc
            // 
            this.btnSubmitCIDoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCIDoc.Location = new System.Drawing.Point(240, 345);
            this.btnSubmitCIDoc.Name = "btnSubmitCIDoc";
            this.btnSubmitCIDoc.Size = new System.Drawing.Size(98, 39);
            this.btnSubmitCIDoc.TabIndex = 36;
            this.btnSubmitCIDoc.Text = "Submit";
            this.btnSubmitCIDoc.UseVisualStyleBackColor = true;
            this.btnSubmitCIDoc.Click += new System.EventHandler(this.btnSubmitCIDoc_Click);
            // 
            // txtCIInfoCI
            // 
            this.txtCIInfoCI.Location = new System.Drawing.Point(156, 217);
            this.txtCIInfoCI.Multiline = true;
            this.txtCIInfoCI.Name = "txtCIInfoCI";
            this.txtCIInfoCI.Size = new System.Drawing.Size(397, 99);
            this.txtCIInfoCI.TabIndex = 34;
            // 
            // txtCIDocRevision
            // 
            this.txtCIDocRevision.Location = new System.Drawing.Point(156, 146);
            this.txtCIDocRevision.Name = "txtCIDocRevision";
            this.txtCIDocRevision.Size = new System.Drawing.Size(170, 20);
            this.txtCIDocRevision.TabIndex = 33;
            // 
            // txtCIDocName
            // 
            this.txtCIDocName.Location = new System.Drawing.Point(156, 85);
            this.txtCIDocName.Name = "txtCIDocName";
            this.txtCIDocName.Size = new System.Drawing.Size(170, 20);
            this.txtCIDocName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevision.Location = new System.Drawing.Point(80, 145);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(68, 19);
            this.lblRevision.TabIndex = 28;
            this.lblRevision.Text = "Revision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "CI Documentation";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(100, 115);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 19);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Date";
            // 
            // CIDocDate
            // 
            this.CIDocDate.Location = new System.Drawing.Point(156, 115);
            this.CIDocDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CIDocDate.Name = "CIDocDate";
            this.CIDocDate.Size = new System.Drawing.Size(170, 20);
            this.CIDocDate.TabIndex = 38;
            // 
            // lblCIDocLocation
            // 
            this.lblCIDocLocation.AutoSize = true;
            this.lblCIDocLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIDocLocation.Location = new System.Drawing.Point(70, 177);
            this.lblCIDocLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCIDocLocation.Name = "lblCIDocLocation";
            this.lblCIDocLocation.Size = new System.Drawing.Size(67, 19);
            this.lblCIDocLocation.TabIndex = 39;
            this.lblCIDocLocation.Text = "Location";
            // 
            // txtCIDocLocation
            // 
            this.txtCIDocLocation.Location = new System.Drawing.Point(156, 179);
            this.txtCIDocLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCIDocLocation.Name = "txtCIDocLocation";
            this.txtCIDocLocation.Size = new System.Drawing.Size(170, 20);
            this.txtCIDocLocation.TabIndex = 40;
            // 
            // CIDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 426);
            this.Controls.Add(this.txtCIDocLocation);
            this.Controls.Add(this.lblCIDocLocation);
            this.Controls.Add(this.CIDocDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSubmitCIDoc);
            this.Controls.Add(this.txtCIInfoCI);
            this.Controls.Add(this.txtCIDocRevision);
            this.Controls.Add(this.txtCIDocName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CIDoc";
            this.Text = "CIDoc";
            this.Load += new System.EventHandler(this.CIDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitCIDoc;
        private System.Windows.Forms.TextBox txtCIInfoCI;
        private System.Windows.Forms.TextBox txtCIDocRevision;
        private System.Windows.Forms.TextBox txtCIDocName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker CIDocDate;
        private System.Windows.Forms.Label lblCIDocLocation;
        private System.Windows.Forms.TextBox txtCIDocLocation;
    }
}