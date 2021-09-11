namespace InventoryManagementSystem
{
    partial class FrmHistoryOfRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoryOfRequests));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.dgvID = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintDepartment = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.reqItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchWeekly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDept
            // 
            this.cboDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cboDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.ForeColor = System.Drawing.Color.White;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(104, 56);
            this.cboDept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(197, 25);
            this.cboDept.TabIndex = 3;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // dgvID
            // 
            this.dgvID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dgvID.Location = new System.Drawing.Point(712, 121);
            this.dgvID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvID.Name = "dgvID";
            this.dgvID.RowTemplate.Height = 24;
            this.dgvID.Size = new System.Drawing.Size(210, 160);
            this.dgvID.TabIndex = 5;
            this.dgvID.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department:";
            // 
            // btnPrintDepartment
            // 
            this.btnPrintDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrintDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDepartment.FlatAppearance.BorderSize = 0;
            this.btnPrintDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrintDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPrintDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDepartment.ForeColor = System.Drawing.Color.White;
            this.btnPrintDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDepartment.Image")));
            this.btnPrintDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintDepartment.Location = new System.Drawing.Point(969, 57);
            this.btnPrintDepartment.Name = "btnPrintDepartment";
            this.btnPrintDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrintDepartment.Size = new System.Drawing.Size(79, 25);
            this.btnPrintDepartment.TabIndex = 28;
            this.btnPrintDepartment.Text = "  PRINT";
            this.btnPrintDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintDepartment.UseVisualStyleBackColor = false;
            this.btnPrintDepartment.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqItems,
            this.proCode,
            this.reqPrice,
            this.reqDate});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(17, 99);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1031, 562);
            this.dataGridView.TabIndex = 29;
            // 
            // reqItems
            // 
            this.reqItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reqItems.HeaderText = "Items";
            this.reqItems.Name = "reqItems";
            this.reqItems.ReadOnly = true;
            this.reqItems.Width = 450;
            // 
            // proCode
            // 
            this.proCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.proCode.HeaderText = "Property Code";
            this.proCode.Name = "proCode";
            this.proCode.ReadOnly = true;
            this.proCode.Width = 116;
            // 
            // reqPrice
            // 
            this.reqPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reqPrice.HeaderText = "Price";
            this.reqPrice.Name = "reqPrice";
            this.reqPrice.ReadOnly = true;
            this.reqPrice.Width = 59;
            // 
            // reqDate
            // 
            this.reqDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reqDate.HeaderText = "Date";
            this.reqDate.Name = "reqDate";
            this.reqDate.ReadOnly = true;
            this.reqDate.Width = 58;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.label5);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1066, 34);
            this.pnlMainMenu.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(1040, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "HISTORY";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(417, 56);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(103, 25);
            this.dtpStartDate.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Weekly:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(526, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "To:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(557, 56);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(103, 25);
            this.dtpEndDate.TabIndex = 34;
            // 
            // btnSearchWeekly
            // 
            this.btnSearchWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchWeekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchWeekly.FlatAppearance.BorderSize = 0;
            this.btnSearchWeekly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSearchWeekly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWeekly.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWeekly.ForeColor = System.Drawing.Color.White;
            this.btnSearchWeekly.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchWeekly.Image")));
            this.btnSearchWeekly.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchWeekly.Location = new System.Drawing.Point(666, 56);
            this.btnSearchWeekly.Name = "btnSearchWeekly";
            this.btnSearchWeekly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearchWeekly.Size = new System.Drawing.Size(79, 25);
            this.btnSearchWeekly.TabIndex = 36;
            this.btnSearchWeekly.Text = " SEARCH";
            this.btnSearchWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchWeekly.UseVisualStyleBackColor = false;
            this.btnSearchWeekly.Click += new System.EventHandler(this.btnPrintWeekly_Click);
            // 
            // FrmHistoryOfRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1066, 684);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearchWeekly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnPrintDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvID);
            this.Controls.Add(this.cboDept);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmHistoryOfRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History of Request";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.DataGridView dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintDepartment;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearchWeekly;
    }
}