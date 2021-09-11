
namespace InventoryManagementSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnStoreLog = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnManageProperties = new System.Windows.Forms.Button();
            this.btnHistoryResquests = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnManageRequest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainMenu.Controls.Add(this.lblUserName);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.pbxMaximize);
            this.pnlMainMenu.Controls.Add(this.pbxMinimize);
            this.pnlMainMenu.Controls.Add(this.label1);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1264, 34);
            this.pnlMainMenu.TabIndex = 0;
            this.pnlMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainMenu_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(376, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "SSC Supply Office";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(1236, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaximize.Image")));
            this.pbxMaximize.Location = new System.Drawing.Point(1212, 9);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(15, 15);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaximize.TabIndex = 3;
            this.pbxMaximize.TabStop = false;
            this.pbxMaximize.Click += new System.EventHandler(this.pbxMaximize_Click);
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimize.Image")));
            this.pbxMinimize.Location = new System.Drawing.Point(1185, 9);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 2;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "      INVENTORY MANAGEMENT SYSTEM |";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 627);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(212, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "   LOGOUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "STOCK";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashboard.Controls.Add(this.btnManageAccounts);
            this.pnlDashboard.Controls.Add(this.btnLogout);
            this.pnlDashboard.Controls.Add(this.btnClients);
            this.pnlDashboard.Controls.Add(this.btnStoreLog);
            this.pnlDashboard.Controls.Add(this.btnManageProduct);
            this.pnlDashboard.Controls.Add(this.btnManageProperties);
            this.pnlDashboard.Controls.Add(this.btnHistoryResquests);
            this.pnlDashboard.Controls.Add(this.btnRelease);
            this.pnlDashboard.Controls.Add(this.btnManageRequest);
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Controls.Add(this.panel2);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 34);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(212, 670);
            this.pnlDashboard.TabIndex = 1;
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnManageAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccounts.FlatAppearance.BorderSize = 0;
            this.btnManageAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnManageAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManageAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccounts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccounts.ForeColor = System.Drawing.Color.White;
            this.btnManageAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageAccounts.Image")));
            this.btnManageAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccounts.Location = new System.Drawing.Point(0, 382);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManageAccounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageAccounts.Size = new System.Drawing.Size(210, 32);
            this.btnManageAccounts.TabIndex = 5;
            this.btnManageAccounts.Text = "   ACCOUNTS";
            this.btnManageAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageAccounts.UseVisualStyleBackColor = false;
            this.btnManageAccounts.Visible = false;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 350);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClients.Size = new System.Drawing.Size(210, 32);
            this.btnClients.TabIndex = 8;
            this.btnClients.Text = "   EMPLOYEES";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnStoreLog
            // 
            this.btnStoreLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnStoreLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoreLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStoreLog.FlatAppearance.BorderSize = 0;
            this.btnStoreLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStoreLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStoreLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreLog.ForeColor = System.Drawing.Color.White;
            this.btnStoreLog.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreLog.Image")));
            this.btnStoreLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreLog.Location = new System.Drawing.Point(0, 318);
            this.btnStoreLog.Name = "btnStoreLog";
            this.btnStoreLog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStoreLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStoreLog.Size = new System.Drawing.Size(210, 32);
            this.btnStoreLog.TabIndex = 11;
            this.btnStoreLog.Text = "   STORE LOGS";
            this.btnStoreLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStoreLog.UseVisualStyleBackColor = false;
            this.btnStoreLog.Click += new System.EventHandler(this.btnStoreLog_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnManageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProduct.FlatAppearance.BorderSize = 0;
            this.btnManageProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnManageProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.ForeColor = System.Drawing.Color.White;
            this.btnManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProduct.Image")));
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(0, 286);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManageProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageProduct.Size = new System.Drawing.Size(210, 32);
            this.btnManageProduct.TabIndex = 3;
            this.btnManageProduct.Text = "   ITEMS";
            this.btnManageProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageProperties
            // 
            this.btnManageProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnManageProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProperties.FlatAppearance.BorderSize = 0;
            this.btnManageProperties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnManageProperties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManageProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProperties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProperties.ForeColor = System.Drawing.Color.White;
            this.btnManageProperties.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProperties.Image")));
            this.btnManageProperties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProperties.Location = new System.Drawing.Point(0, 254);
            this.btnManageProperties.Name = "btnManageProperties";
            this.btnManageProperties.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManageProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageProperties.Size = new System.Drawing.Size(210, 32);
            this.btnManageProperties.TabIndex = 4;
            this.btnManageProperties.Text = "   TRANSFER OWNERSHIP";
            this.btnManageProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProperties.UseVisualStyleBackColor = false;
            this.btnManageProperties.Click += new System.EventHandler(this.btnManageProperties_Click);
            // 
            // btnHistoryResquests
            // 
            this.btnHistoryResquests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnHistoryResquests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoryResquests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoryResquests.FlatAppearance.BorderSize = 0;
            this.btnHistoryResquests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHistoryResquests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHistoryResquests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryResquests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryResquests.ForeColor = System.Drawing.Color.White;
            this.btnHistoryResquests.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryResquests.Image")));
            this.btnHistoryResquests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryResquests.Location = new System.Drawing.Point(0, 222);
            this.btnHistoryResquests.Name = "btnHistoryResquests";
            this.btnHistoryResquests.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistoryResquests.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHistoryResquests.Size = new System.Drawing.Size(210, 32);
            this.btnHistoryResquests.TabIndex = 2;
            this.btnHistoryResquests.Text = "   HISTORY";
            this.btnHistoryResquests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoryResquests.UseVisualStyleBackColor = false;
            this.btnHistoryResquests.Click += new System.EventHandler(this.btnHistoryResquests_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelease.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(0, 190);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRelease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRelease.Size = new System.Drawing.Size(210, 32);
            this.btnRelease.TabIndex = 7;
            this.btnRelease.Text = "   RELEASE REQUESTS";
            this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnManageRequest
            // 
            this.btnManageRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.btnManageRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageRequest.FlatAppearance.BorderSize = 0;
            this.btnManageRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnManageRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManageRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRequest.ForeColor = System.Drawing.Color.White;
            this.btnManageRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRequest.Image")));
            this.btnManageRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRequest.Location = new System.Drawing.Point(0, 158);
            this.btnManageRequest.Name = "btnManageRequest";
            this.btnManageRequest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManageRequest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageRequest.Size = new System.Drawing.Size(210, 32);
            this.btnManageRequest.TabIndex = 1;
            this.btnManageRequest.Text = "   REQUESTS";
            this.btnManageRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageRequest.UseVisualStyleBackColor = false;
            this.btnManageRequest.Click += new System.EventHandler(this.btnManageRequest_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 158);
            this.panel2.TabIndex = 10;
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxUser.Image = ((System.Drawing.Image)(resources.GetObject("pbxUser.Image")));
            this.pbxUser.Location = new System.Drawing.Point(52, 15);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(100, 100);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(212, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1052, 670);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 704);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.Button btnManageRequest;
        private System.Windows.Forms.Button btnManageProperties;
        private System.Windows.Forms.Button btnHistoryResquests;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStoreLog;
    }
}

