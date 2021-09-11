
namespace InventoryManagementSystem
{
    partial class FrmStoreLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreLog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxSearchStore = new System.Windows.Forms.TextBox();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.dgvStoreList = new System.Windows.Forms.DataGridView();
            this.StoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeRecieveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeView = new System.Windows.Forms.DataGridViewImageColumn();
            this.storeEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.storeDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.label2);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1052, 34);
            this.pnlMainMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(1027, 8);
            this.pbxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(17, 17);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "STORE LOGS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(822, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tbxSearchStore
            // 
            this.tbxSearchStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxSearchStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearchStore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchStore.ForeColor = System.Drawing.Color.White;
            this.tbxSearchStore.Location = new System.Drawing.Point(855, 48);
            this.tbxSearchStore.Name = "tbxSearchStore";
            this.tbxSearchStore.Size = new System.Drawing.Size(179, 25);
            this.tbxSearchStore.TabIndex = 7;
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStore.FlatAppearance.BorderSize = 0;
            this.btnAddStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStore.ForeColor = System.Drawing.Color.White;
            this.btnAddStore.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStore.Image")));
            this.btnAddStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStore.Location = new System.Drawing.Point(16, 48);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddStore.Size = new System.Drawing.Size(102, 25);
            this.btnAddStore.TabIndex = 9;
            this.btnAddStore.Text = "  ADD STORE";
            this.btnAddStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // dgvStoreList
            // 
            this.dgvStoreList.AllowUserToAddRows = false;
            this.dgvStoreList.AllowUserToDeleteRows = false;
            this.dgvStoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoreList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.dgvStoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreNo,
            this.storeName,
            this.storeInvoiceNo,
            this.storeDepartment,
            this.storeRecieveDate,
            this.storeView,
            this.storeEdit,
            this.storeDelete});
            this.dgvStoreList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStoreList.EnableHeadersVisualStyles = false;
            this.dgvStoreList.Location = new System.Drawing.Point(16, 89);
            this.dgvStoreList.Name = "dgvStoreList";
            this.dgvStoreList.ReadOnly = true;
            this.dgvStoreList.RowHeadersVisible = false;
            this.dgvStoreList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreList.Size = new System.Drawing.Size(1018, 555);
            this.dgvStoreList.TabIndex = 10;
            this.dgvStoreList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreList_CellContentClick);
            // 
            // StoreNo
            // 
            this.StoreNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StoreNo.HeaderText = "#";
            this.StoreNo.Name = "StoreNo";
            this.StoreNo.ReadOnly = true;
            this.StoreNo.Visible = false;
            this.StoreNo.Width = 39;
            // 
            // storeName
            // 
            this.storeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storeName.HeaderText = "Store Name";
            this.storeName.Name = "storeName";
            this.storeName.ReadOnly = true;
            // 
            // storeInvoiceNo
            // 
            this.storeInvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeInvoiceNo.HeaderText = "Invoice No.";
            this.storeInvoiceNo.Name = "storeInvoiceNo";
            this.storeInvoiceNo.ReadOnly = true;
            this.storeInvoiceNo.Width = 96;
            // 
            // storeDepartment
            // 
            this.storeDepartment.HeaderText = "Department";
            this.storeDepartment.Name = "storeDepartment";
            this.storeDepartment.ReadOnly = true;
            // 
            // storeRecieveDate
            // 
            this.storeRecieveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeRecieveDate.HeaderText = "Date Recieved";
            this.storeRecieveDate.Name = "storeRecieveDate";
            this.storeRecieveDate.ReadOnly = true;
            this.storeRecieveDate.Width = 114;
            // 
            // storeView
            // 
            this.storeView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeView.HeaderText = "View";
            this.storeView.Image = ((System.Drawing.Image)(resources.GetObject("storeView.Image")));
            this.storeView.Name = "storeView";
            this.storeView.ReadOnly = true;
            this.storeView.Width = 39;
            // 
            // storeEdit
            // 
            this.storeEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeEdit.HeaderText = "Edit";
            this.storeEdit.Image = ((System.Drawing.Image)(resources.GetObject("storeEdit.Image")));
            this.storeEdit.Name = "storeEdit";
            this.storeEdit.ReadOnly = true;
            this.storeEdit.Width = 34;
            // 
            // storeDelete
            // 
            this.storeDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeDelete.HeaderText = "Delete";
            this.storeDelete.Image = ((System.Drawing.Image)(resources.GetObject("storeDelete.Image")));
            this.storeDelete.Name = "storeDelete";
            this.storeDelete.ReadOnly = true;
            this.storeDelete.Width = 49;
            // 
            // FrmStoreLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1052, 670);
            this.Controls.Add(this.dgvStoreList);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxSearchStore);
            this.Controls.Add(this.pnlMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStoreLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox tbxSearchStore;
        private System.Windows.Forms.Button btnAddStore;
        public System.Windows.Forms.DataGridView dgvStoreList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeRecieveDate;
        private System.Windows.Forms.DataGridViewImageColumn storeView;
        private System.Windows.Forms.DataGridViewImageColumn storeEdit;
        private System.Windows.Forms.DataGridViewImageColumn storeDelete;
    }
}