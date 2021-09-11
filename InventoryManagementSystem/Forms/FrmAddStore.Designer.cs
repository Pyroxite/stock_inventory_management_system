
namespace InventoryManagementSystem
{
    partial class FrmAddStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStore));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.tbxStoreName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxStoreInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStoreDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStoreAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStoreTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudStoreQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpStoreRecieveDate = new System.Windows.Forms.DateTimePicker();
            this.dgvStoreItems = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateStore = new System.Windows.Forms.Button();
            this.btnStoreSave = new System.Windows.Forms.Button();
            this.cbxStoreDepartment = new System.Windows.Forms.ComboBox();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoreQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.lblStoreName);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(947, 34);
            this.pnlMainMenu.TabIndex = 3;
            this.pnlMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainMenu_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(921, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(33, 8);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(115, 17);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "ADD NEW STORE";
            // 
            // tbxStoreName
            // 
            this.tbxStoreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxStoreName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStoreName.ForeColor = System.Drawing.Color.White;
            this.tbxStoreName.Location = new System.Drawing.Point(133, 72);
            this.tbxStoreName.Name = "tbxStoreName";
            this.tbxStoreName.Size = new System.Drawing.Size(297, 25);
            this.tbxStoreName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Store Name:";
            // 
            // tbxStoreInvoiceNo
            // 
            this.tbxStoreInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxStoreInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxStoreInvoiceNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStoreInvoiceNo.ForeColor = System.Drawing.Color.White;
            this.tbxStoreInvoiceNo.Location = new System.Drawing.Point(26, 72);
            this.tbxStoreInvoiceNo.Name = "tbxStoreInvoiceNo";
            this.tbxStoreInvoiceNo.Size = new System.Drawing.Size(90, 25);
            this.tbxStoreInvoiceNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Invoice No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantity:";
            // 
            // tbxStoreDescription
            // 
            this.tbxStoreDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxStoreDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxStoreDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStoreDescription.ForeColor = System.Drawing.Color.White;
            this.tbxStoreDescription.Location = new System.Drawing.Point(118, 145);
            this.tbxStoreDescription.Name = "tbxStoreDescription";
            this.tbxStoreDescription.Size = new System.Drawing.Size(641, 25);
            this.tbxStoreDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // tbxStoreAmount
            // 
            this.tbxStoreAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxStoreAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxStoreAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStoreAmount.ForeColor = System.Drawing.Color.White;
            this.tbxStoreAmount.Location = new System.Drawing.Point(775, 145);
            this.tbxStoreAmount.Name = "tbxStoreAmount";
            this.tbxStoreAmount.Size = new System.Drawing.Size(67, 25);
            this.tbxStoreAmount.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(772, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount:";
            // 
            // tbxStoreTotal
            // 
            this.tbxStoreTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxStoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxStoreTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStoreTotal.ForeColor = System.Drawing.Color.White;
            this.tbxStoreTotal.Location = new System.Drawing.Point(853, 145);
            this.tbxStoreTotal.Name = "tbxStoreTotal";
            this.tbxStoreTotal.Size = new System.Drawing.Size(67, 25);
            this.tbxStoreTotal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(850, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(824, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Recieved Date:";
            // 
            // nudStoreQuantity
            // 
            this.nudStoreQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nudStoreQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStoreQuantity.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.nudStoreQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStoreQuantity.ForeColor = System.Drawing.Color.White;
            this.nudStoreQuantity.Location = new System.Drawing.Point(25, 145);
            this.nudStoreQuantity.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudStoreQuantity.Name = "nudStoreQuantity";
            this.nudStoreQuantity.Size = new System.Drawing.Size(80, 25);
            this.nudStoreQuantity.TabIndex = 23;
            // 
            // dtpStoreRecieveDate
            // 
            this.dtpStoreRecieveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStoreRecieveDate.Location = new System.Drawing.Point(827, 72);
            this.dtpStoreRecieveDate.Name = "dtpStoreRecieveDate";
            this.dtpStoreRecieveDate.Size = new System.Drawing.Size(93, 25);
            this.dtpStoreRecieveDate.TabIndex = 40;
            // 
            // dgvStoreItems
            // 
            this.dgvStoreItems.AllowUserToAddRows = false;
            this.dgvStoreItems.AllowUserToDeleteRows = false;
            this.dgvStoreItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.dgvStoreItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoreItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStoreItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvStoreItems.EnableHeadersVisualStyles = false;
            this.dgvStoreItems.Location = new System.Drawing.Point(26, 179);
            this.dgvStoreItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvStoreItems.Name = "dgvStoreItems";
            this.dgvStoreItems.RowHeadersVisible = false;
            this.dgvStoreItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreItems.RowTemplate.Height = 24;
            this.dgvStoreItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreItems.Size = new System.Drawing.Size(894, 412);
            this.dgvStoreItems.TabIndex = 41;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Qty.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Item Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.FlatAppearance.BorderSize = 0;
            this.btnAddItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItems.Image")));
            this.btnAddItems.Location = new System.Drawing.Point(619, 601);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddItems.Size = new System.Drawing.Size(100, 34);
            this.btnAddItems.TabIndex = 42;
            this.btnAddItems.Text = " ADD ITEMS";
            this.btnAddItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(444, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Department:";
            // 
            // btnUpdateStore
            // 
            this.btnUpdateStore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdateStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStore.FlatAppearance.BorderSize = 0;
            this.btnUpdateStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdateStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStore.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStore.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStore.Image")));
            this.btnUpdateStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateStore.Location = new System.Drawing.Point(833, 601);
            this.btnUpdateStore.Name = "btnUpdateStore";
            this.btnUpdateStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateStore.Size = new System.Drawing.Size(86, 34);
            this.btnUpdateStore.TabIndex = 45;
            this.btnUpdateStore.Text = "  UPDATE";
            this.btnUpdateStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStore.UseVisualStyleBackColor = false;
            this.btnUpdateStore.Click += new System.EventHandler(this.btnUpdateStore_Click);
            // 
            // btnStoreSave
            // 
            this.btnStoreSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStoreSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStoreSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoreSave.FlatAppearance.BorderSize = 0;
            this.btnStoreSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStoreSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStoreSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreSave.ForeColor = System.Drawing.Color.White;
            this.btnStoreSave.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreSave.Image")));
            this.btnStoreSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStoreSave.Location = new System.Drawing.Point(731, 601);
            this.btnStoreSave.Name = "btnStoreSave";
            this.btnStoreSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStoreSave.Size = new System.Drawing.Size(90, 34);
            this.btnStoreSave.TabIndex = 46;
            this.btnStoreSave.Text = " SAVE";
            this.btnStoreSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStoreSave.UseVisualStyleBackColor = false;
            this.btnStoreSave.Click += new System.EventHandler(this.btnStoreSave_Click);
            // 
            // cbxStoreDepartment
            // 
            this.cbxStoreDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cbxStoreDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxStoreDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStoreDepartment.ForeColor = System.Drawing.Color.White;
            this.cbxStoreDepartment.FormattingEnabled = true;
            this.cbxStoreDepartment.Location = new System.Drawing.Point(447, 72);
            this.cbxStoreDepartment.Name = "cbxStoreDepartment";
            this.cbxStoreDepartment.Size = new System.Drawing.Size(132, 25);
            this.cbxStoreDepartment.TabIndex = 47;
            // 
            // FrmAddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(947, 646);
            this.ControlBox = false;
            this.Controls.Add(this.cbxStoreDepartment);
            this.Controls.Add(this.btnStoreSave);
            this.Controls.Add(this.btnUpdateStore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.dgvStoreItems);
            this.Controls.Add(this.dtpStoreRecieveDate);
            this.Controls.Add(this.nudStoreQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxStoreTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxStoreAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxStoreDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStoreInvoiceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStoreName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoreQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxClose;
        public System.Windows.Forms.Label lblStoreName;
        public System.Windows.Forms.TextBox tbxStoreName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxStoreInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxStoreDescription;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxStoreAmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxStoreTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.NumericUpDown nudStoreQuantity;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnAddItems;
        public System.Windows.Forms.DateTimePicker dtpStoreRecieveDate;
        public System.Windows.Forms.DataGridView dgvStoreItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.Button btnUpdateStore;
        public System.Windows.Forms.Button btnStoreSave;
        public System.Windows.Forms.ComboBox cbxStoreDepartment;
    }
}