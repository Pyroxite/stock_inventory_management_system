
namespace InventoryManagementSystem
{
    partial class FrmAdminAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminAccounts));
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.acDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.acID,
            this.acUsername,
            this.acPassword,
            this.acEdit,
            this.acDelete});
            this.dgvAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.Location = new System.Drawing.Point(13, 53);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(430, 237);
            this.dgvAccounts.TabIndex = 5;
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            // 
            // acID
            // 
            this.acID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.acID.HeaderText = "ID";
            this.acID.Name = "acID";
            this.acID.ReadOnly = true;
            this.acID.Width = 43;
            // 
            // acUsername
            // 
            this.acUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acUsername.HeaderText = "Username";
            this.acUsername.Name = "acUsername";
            this.acUsername.ReadOnly = true;
            // 
            // acPassword
            // 
            this.acPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acPassword.HeaderText = "Password";
            this.acPassword.Name = "acPassword";
            this.acPassword.ReadOnly = true;
            // 
            // acEdit
            // 
            this.acEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.acEdit.HeaderText = "Edit";
            this.acEdit.Image = ((System.Drawing.Image)(resources.GetObject("acEdit.Image")));
            this.acEdit.Name = "acEdit";
            this.acEdit.ReadOnly = true;
            this.acEdit.Width = 34;
            // 
            // acDelete
            // 
            this.acDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.acDelete.HeaderText = "Delete";
            this.acDelete.Image = ((System.Drawing.Image)(resources.GetObject("acDelete.Image")));
            this.acDelete.Name = "acDelete";
            this.acDelete.ReadOnly = true;
            this.acDelete.Width = 49;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.lblAddNew);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(454, 34);
            this.pnlMainMenu.TabIndex = 6;
            this.pnlMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainMenu_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.ForeColor = System.Drawing.Color.White;
            this.lblAddNew.Location = new System.Drawing.Point(28, 8);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(112, 17);
            this.lblAddNew.TabIndex = 10;
            this.lblAddNew.Text = "USER ACCOUNTS";
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(428, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // FrmAdminAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.dgvAccounts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdminAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn acID;
        private System.Windows.Forms.DataGridViewTextBoxColumn acUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn acPassword;
        private System.Windows.Forms.DataGridViewImageColumn acEdit;
        private System.Windows.Forms.DataGridViewImageColumn acDelete;
    }
}