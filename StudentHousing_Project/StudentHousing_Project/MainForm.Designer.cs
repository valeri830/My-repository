namespace StudentHousing_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAdminPanel = new System.Windows.Forms.TabPage();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.rbUnread = new System.Windows.Forms.RadioButton();
            this.rbShowRead = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.btnMarkAsRead = new System.Windows.Forms.Button();
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panelLBComplaintsBorder = new System.Windows.Forms.Panel();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.tpHouseRules = new System.Windows.Forms.TabPage();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.panelLBHouseRulesBorder = new System.Windows.Forms.Panel();
            this.lbHouseRules = new System.Windows.Forms.ListBox();
            this.panelTBnewRuleBorder = new System.Windows.Forms.Panel();
            this.tbNewRule = new System.Windows.Forms.TextBox();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.panelRTBdescriptionBorder = new System.Windows.Forms.Panel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbEvent = new System.Windows.Forms.RadioButton();
            this.rbComplaint = new System.Windows.Forms.RadioButton();
            this.panelTBtitleBorder = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panelLBEventsBorder = new System.Windows.Forms.Panel();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnEventInfo = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.tpDashboard = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpAdminPanel.SuspendLayout();
            this.panelLBComplaintsBorder.SuspendLayout();
            this.tpHouseRules.SuspendLayout();
            this.panelLBHouseRulesBorder.SuspendLayout();
            this.panelTBnewRuleBorder.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.panelRTBdescriptionBorder.SuspendLayout();
            this.panelTBtitleBorder.SuspendLayout();
            this.panelLBEventsBorder.SuspendLayout();
            this.tpDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcMain.Controls.Add(this.tpDashboard);
            this.tcMain.Controls.Add(this.tpAdminPanel);
            this.tcMain.Controls.Add(this.tpHouseRules);
            this.tcMain.Controls.Add(this.tpCreate);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcMain.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.ItemSize = new System.Drawing.Size(87, 150);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(649, 354);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 0;
            // 
            // tpAdminPanel
            // 
            this.tpAdminPanel.Controls.Add(this.btnShowMore);
            this.tpAdminPanel.Controls.Add(this.rbUnread);
            this.tpAdminPanel.Controls.Add(this.rbShowRead);
            this.tpAdminPanel.Controls.Add(this.rbShowAll);
            this.tpAdminPanel.Controls.Add(this.btnMarkAsRead);
            this.tpAdminPanel.Controls.Add(this.btnDeleteComplaint);
            this.tpAdminPanel.Controls.Add(this.lblAdminPanel);
            this.tpAdminPanel.Controls.Add(this.panelLBComplaintsBorder);
            this.tpAdminPanel.Location = new System.Drawing.Point(154, 4);
            this.tpAdminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAdminPanel.Name = "tpAdminPanel";
            this.tpAdminPanel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAdminPanel.Size = new System.Drawing.Size(491, 346);
            this.tpAdminPanel.TabIndex = 1;
            this.tpAdminPanel.Text = "Admin";
            this.tpAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnShowMore
            // 
            this.btnShowMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMore.Location = new System.Drawing.Point(383, 77);
            this.btnShowMore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(76, 32);
            this.btnShowMore.TabIndex = 7;
            this.btnShowMore.Text = "More";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // rbUnread
            // 
            this.rbUnread.AutoSize = true;
            this.rbUnread.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnread.Location = new System.Drawing.Point(383, 298);
            this.rbUnread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUnread.Name = "rbUnread";
            this.rbUnread.Size = new System.Drawing.Size(79, 25);
            this.rbUnread.TabIndex = 5;
            this.rbUnread.Text = "Unread";
            this.rbUnread.UseVisualStyleBackColor = true;
            this.rbUnread.CheckedChanged += new System.EventHandler(this.rbUnread_CheckedChanged);
            // 
            // rbShowRead
            // 
            this.rbShowRead.AutoSize = true;
            this.rbShowRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowRead.Location = new System.Drawing.Point(383, 270);
            this.rbShowRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbShowRead.Name = "rbShowRead";
            this.rbShowRead.Size = new System.Drawing.Size(63, 25);
            this.rbShowRead.TabIndex = 4;
            this.rbShowRead.Text = "Read";
            this.rbShowRead.UseVisualStyleBackColor = true;
            this.rbShowRead.CheckedChanged += new System.EventHandler(this.rbShowRead_CheckedChanged);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowAll.Location = new System.Drawing.Point(383, 243);
            this.rbShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(46, 25);
            this.rbShowAll.TabIndex = 3;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "All";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsRead.Location = new System.Drawing.Point(383, 125);
            this.btnMarkAsRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(76, 32);
            this.btnMarkAsRead.TabIndex = 2;
            this.btnMarkAsRead.Text = "Mark";
            this.btnMarkAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAsRead.Click += new System.EventHandler(this.btnMarkAsRead_Click);
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComplaint.Location = new System.Drawing.Point(383, 173);
            this.btnDeleteComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(76, 32);
            this.btnDeleteComplaint.TabIndex = 1;
            this.btnDeleteComplaint.Text = "Delete";
            this.btnDeleteComplaint.UseVisualStyleBackColor = true;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.btnDeleteComplaint_Click);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(120, 6);
            this.lblAdminPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(249, 51);
            this.lblAdminPanel.TabIndex = 0;
            this.lblAdminPanel.Text = "Admin Panel";
            // 
            // panelLBComplaintsBorder
            // 
            this.panelLBComplaintsBorder.Controls.Add(this.lbComplaints);
            this.panelLBComplaintsBorder.Location = new System.Drawing.Point(35, 65);
            this.panelLBComplaintsBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLBComplaintsBorder.Name = "panelLBComplaintsBorder";
            this.panelLBComplaintsBorder.Size = new System.Drawing.Size(319, 254);
            this.panelLBComplaintsBorder.TabIndex = 8;
            // 
            // lbComplaints
            // 
            this.lbComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 21;
            this.lbComplaints.Location = new System.Drawing.Point(1, 1);
            this.lbComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(317, 252);
            this.lbComplaints.TabIndex = 6;
            // 
            // tpHouseRules
            // 
            this.tpHouseRules.Controls.Add(this.btnDeleteRule);
            this.tpHouseRules.Controls.Add(this.btnAddRule);
            this.tpHouseRules.Controls.Add(this.lblHouseRules);
            this.tpHouseRules.Controls.Add(this.panelLBHouseRulesBorder);
            this.tpHouseRules.Controls.Add(this.panelTBnewRuleBorder);
            this.tpHouseRules.Location = new System.Drawing.Point(154, 4);
            this.tpHouseRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpHouseRules.Name = "tpHouseRules";
            this.tpHouseRules.Size = new System.Drawing.Size(491, 346);
            this.tpHouseRules.TabIndex = 2;
            this.tpHouseRules.Text = "House rules";
            this.tpHouseRules.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRule.Location = new System.Drawing.Point(381, 300);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(80, 32);
            this.btnDeleteRule.TabIndex = 5;
            this.btnDeleteRule.Text = "Delete";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRule.Location = new System.Drawing.Point(273, 300);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(80, 32);
            this.btnAddRule.TabIndex = 4;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseRules.Location = new System.Drawing.Point(117, 6);
            this.lblHouseRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(242, 51);
            this.lblHouseRules.TabIndex = 1;
            this.lblHouseRules.Text = "House Rules";
            // 
            // panelLBHouseRulesBorder
            // 
            this.panelLBHouseRulesBorder.Controls.Add(this.lbHouseRules);
            this.panelLBHouseRulesBorder.Location = new System.Drawing.Point(37, 71);
            this.panelLBHouseRulesBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLBHouseRulesBorder.Name = "panelLBHouseRulesBorder";
            this.panelLBHouseRulesBorder.Size = new System.Drawing.Size(424, 212);
            this.panelLBHouseRulesBorder.TabIndex = 6;
            // 
            // lbHouseRules
            // 
            this.lbHouseRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHouseRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHouseRules.FormattingEnabled = true;
            this.lbHouseRules.ItemHeight = 21;
            this.lbHouseRules.Location = new System.Drawing.Point(1, 1);
            this.lbHouseRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbHouseRules.Name = "lbHouseRules";
            this.lbHouseRules.Size = new System.Drawing.Size(422, 210);
            this.lbHouseRules.TabIndex = 2;
            // 
            // panelTBnewRuleBorder
            // 
            this.panelTBnewRuleBorder.Controls.Add(this.tbNewRule);
            this.panelTBnewRuleBorder.Location = new System.Drawing.Point(37, 302);
            this.panelTBnewRuleBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTBnewRuleBorder.Name = "panelTBnewRuleBorder";
            this.panelTBnewRuleBorder.Size = new System.Drawing.Size(209, 24);
            this.panelTBnewRuleBorder.TabIndex = 7;
            // 
            // tbNewRule
            // 
            this.tbNewRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewRule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewRule.Location = new System.Drawing.Point(1, 1);
            this.tbNewRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewRule.Name = "tbNewRule";
            this.tbNewRule.Size = new System.Drawing.Size(207, 22);
            this.tbNewRule.TabIndex = 3;
            // 
            // tpCreate
            // 
            this.tpCreate.Controls.Add(this.lblDescription);
            this.tpCreate.Controls.Add(this.lblTitle);
            this.tpCreate.Controls.Add(this.panelRTBdescriptionBorder);
            this.tpCreate.Controls.Add(this.lblNew);
            this.tpCreate.Controls.Add(this.btnCreate);
            this.tpCreate.Controls.Add(this.rbEvent);
            this.tpCreate.Controls.Add(this.rbComplaint);
            this.tpCreate.Controls.Add(this.panelTBtitleBorder);
            this.tpCreate.Location = new System.Drawing.Point(154, 4);
            this.tpCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Size = new System.Drawing.Size(491, 346);
            this.tpCreate.TabIndex = 3;
            this.tpCreate.Text = "New";
            this.tpCreate.UseVisualStyleBackColor = true;
            // 
            // panelRTBdescriptionBorder
            // 
            this.panelRTBdescriptionBorder.Controls.Add(this.rtbDescription);
            this.panelRTBdescriptionBorder.Location = new System.Drawing.Point(10, 127);
            this.panelRTBdescriptionBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRTBdescriptionBorder.Name = "panelRTBdescriptionBorder";
            this.panelRTBdescriptionBorder.Size = new System.Drawing.Size(340, 196);
            this.panelRTBdescriptionBorder.TabIndex = 7;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(1, 1);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(338, 194);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(0, 0);
            this.lblNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(257, 51);
            this.lblNew.TabIndex = 5;
            this.lblNew.Text = "CREATE NEW";
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(374, 285);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbEvent
            // 
            this.rbEvent.AutoSize = true;
            this.rbEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEvent.Location = new System.Drawing.Point(374, 171);
            this.rbEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEvent.Name = "rbEvent";
            this.rbEvent.Size = new System.Drawing.Size(66, 25);
            this.rbEvent.TabIndex = 1;
            this.rbEvent.Text = "Event";
            this.rbEvent.UseVisualStyleBackColor = true;
            // 
            // rbComplaint
            // 
            this.rbComplaint.AutoSize = true;
            this.rbComplaint.Checked = true;
            this.rbComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComplaint.Location = new System.Drawing.Point(374, 128);
            this.rbComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbComplaint.Name = "rbComplaint";
            this.rbComplaint.Size = new System.Drawing.Size(100, 25);
            this.rbComplaint.TabIndex = 0;
            this.rbComplaint.TabStop = true;
            this.rbComplaint.Text = "Complaint";
            this.rbComplaint.UseVisualStyleBackColor = true;
            // 
            // panelTBtitleBorder
            // 
            this.panelTBtitleBorder.Controls.Add(this.tbTitle);
            this.panelTBtitleBorder.Location = new System.Drawing.Point(9, 79);
            this.panelTBtitleBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTBtitleBorder.Name = "panelTBtitleBorder";
            this.panelTBtitleBorder.Size = new System.Drawing.Size(341, 24);
            this.panelTBtitleBorder.TabIndex = 6;
            // 
            // tbTitle
            // 
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(1, 1);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(339, 22);
            this.tbTitle.TabIndex = 3;
            // 
            // panelLBEventsBorder
            // 
            this.panelLBEventsBorder.Controls.Add(this.lbEvents);
            this.panelLBEventsBorder.Location = new System.Drawing.Point(37, 65);
            this.panelLBEventsBorder.Margin = new System.Windows.Forms.Padding(2);
            this.panelLBEventsBorder.Name = "panelLBEventsBorder";
            this.panelLBEventsBorder.Size = new System.Drawing.Size(424, 212);
            this.panelLBEventsBorder.TabIndex = 4;
            // 
            // lbEvents
            // 
            this.lbEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 21;
            this.lbEvents.Location = new System.Drawing.Point(1, 1);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(422, 210);
            this.lbEvents.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDashboard.Location = new System.Drawing.Point(144, 6);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(216, 51);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventInfo.Location = new System.Drawing.Point(37, 296);
            this.btnEventInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(100, 32);
            this.btnEventInfo.TabIndex = 2;
            this.btnEventInfo.Text = "Event Info";
            this.btnEventInfo.UseVisualStyleBackColor = true;
            this.btnEventInfo.Click += new System.EventHandler(this.btnEventInfo_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.Location = new System.Drawing.Point(359, 296);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteEvent.TabIndex = 3;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // tpDashboard
            // 
            this.tpDashboard.BackColor = System.Drawing.Color.Transparent;
            this.tpDashboard.Controls.Add(this.btnDeleteEvent);
            this.tpDashboard.Controls.Add(this.btnEventInfo);
            this.tpDashboard.Controls.Add(this.lblDashboard);
            this.tpDashboard.Controls.Add(this.panelLBEventsBorder);
            this.tpDashboard.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDashboard.Location = new System.Drawing.Point(154, 4);
            this.tpDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.tpDashboard.Name = "tpDashboard";
            this.tpDashboard.Padding = new System.Windows.Forms.Padding(2);
            this.tpDashboard.Size = new System.Drawing.Size(491, 346);
            this.tpDashboard.TabIndex = 0;
            this.tpDashboard.Text = "Dashboard";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 56);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 105);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 354);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Student Housing BV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tcMain.ResumeLayout(false);
            this.tpAdminPanel.ResumeLayout(false);
            this.tpAdminPanel.PerformLayout();
            this.panelLBComplaintsBorder.ResumeLayout(false);
            this.tpHouseRules.ResumeLayout(false);
            this.tpHouseRules.PerformLayout();
            this.panelLBHouseRulesBorder.ResumeLayout(false);
            this.panelTBnewRuleBorder.ResumeLayout(false);
            this.panelTBnewRuleBorder.PerformLayout();
            this.tpCreate.ResumeLayout(false);
            this.tpCreate.PerformLayout();
            this.panelRTBdescriptionBorder.ResumeLayout(false);
            this.panelTBtitleBorder.ResumeLayout(false);
            this.panelTBtitleBorder.PerformLayout();
            this.panelLBEventsBorder.ResumeLayout(false);
            this.tpDashboard.ResumeLayout(false);
            this.tpDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAdminPanel;
        private System.Windows.Forms.TabPage tpHouseRules;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.RadioButton rbUnread;
        private System.Windows.Forms.RadioButton rbShowRead;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.Button btnMarkAsRead;
        private System.Windows.Forms.Button btnDeleteComplaint;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox tbNewRule;
        private System.Windows.Forms.ListBox lbHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbEvent;
        private System.Windows.Forms.RadioButton rbComplaint;
        private System.Windows.Forms.Panel panelLBHouseRulesBorder;
        private System.Windows.Forms.Panel panelTBnewRuleBorder;
        private System.Windows.Forms.Button btnShowMore;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Panel panelLBComplaintsBorder;
        private System.Windows.Forms.Panel panelTBtitleBorder;
        private System.Windows.Forms.Panel panelRTBdescriptionBorder;
        private System.Windows.Forms.TabPage tpDashboard;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnEventInfo;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panelLBEventsBorder;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
    }
}

