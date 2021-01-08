namespace StudentHousing_Project
{
    partial class ComplaintInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_complaint_description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbl_date_created = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Complaint Subject";
            // 
            // lbl_complaint_description
            // 
            this.lbl_complaint_description.AutoSize = true;
            this.lbl_complaint_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complaint_description.Location = new System.Drawing.Point(16, 70);
            this.lbl_complaint_description.Name = "lbl_complaint_description";
            this.lbl_complaint_description.Size = new System.Drawing.Size(188, 24);
            this.lbl_complaint_description.TabIndex = 1;
            this.lbl_complaint_description.Text = "complaint description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 2);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "lblDescription";
            // 
            // pnDescription
            // 
            this.pnDescription.Controls.Add(this.lblDescription);
            this.pnDescription.Location = new System.Drawing.Point(20, 93);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(308, 134);
            this.pnDescription.TabIndex = 3;
            // 
            // lbl_date_created
            // 
            this.lbl_date_created.AutoSize = true;
            this.lbl_date_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_created.Location = new System.Drawing.Point(16, 230);
            this.lbl_date_created.Name = "lbl_date_created";
            this.lbl_date_created.Size = new System.Drawing.Size(109, 20);
            this.lbl_date_created.TabIndex = 4;
            this.lbl_date_created.Text = "Date Created:";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.Location = new System.Drawing.Point(122, 230);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(89, 20);
            this.lblCreatedAt.TabIndex = 5;
            this.lblCreatedAt.Text = "01/01/2001";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(16, 250);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(64, 20);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(73, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Read";
            // 
            // ComplaintInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 278);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lbl_date_created);
            this.Controls.Add(this.pnDescription);
            this.Controls.Add(this.lbl_complaint_description);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComplaintInfo";
            this.Text = "ComplaintInfo";
            this.pnDescription.ResumeLayout(false);
            this.pnDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_complaint_description;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Label lbl_date_created;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lblStatus;
    }
}