
namespace InventoryManagementSystem
{
    partial class FrmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddItem));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxProductCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxUnits = new System.Windows.Forms.ComboBox();
            this.tbxPerQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbxItemImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoGenerate = new System.Windows.Forms.Button();
            this.rbnCommon = new System.Windows.Forms.RadioButton();
            this.rbnSpecial = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.lblAddNew);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(497, 34);
            this.pnlMainMenu.TabIndex = 2;
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
            this.pbxClose.Location = new System.Drawing.Point(471, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.ForeColor = System.Drawing.Color.White;
            this.lblAddNew.Location = new System.Drawing.Point(36, 8);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(106, 17);
            this.lblAddNew.TabIndex = 0;
            this.lblAddNew.Text = "ADD NEW ITEM";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(285, 82);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(202, 25);
            this.tbxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // tbxBrand
            // 
            this.tbxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrand.ForeColor = System.Drawing.Color.White;
            this.tbxBrand.Location = new System.Drawing.Point(285, 119);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(202, 25);
            this.tbxBrand.TabIndex = 3;
            this.tbxBrand.Text = "Brand X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalAmount.ForeColor = System.Drawing.Color.White;
            this.tbxTotalAmount.Location = new System.Drawing.Point(286, 267);
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.Size = new System.Drawing.Size(201, 25);
            this.tbxTotalAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(91, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(101, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "  ADD ITEM";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(203, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(86, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "  UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductCode.ForeColor = System.Drawing.Color.White;
            this.tbxProductCode.Location = new System.Drawing.Point(285, 45);
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.Size = new System.Drawing.Size(169, 25);
            this.tbxProductCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(185, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit:";
            // 
            // tbxProductID
            // 
            this.tbxProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductID.ForeColor = System.Drawing.Color.White;
            this.tbxProductID.Location = new System.Drawing.Point(441, 349);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(43, 25);
            this.tbxProductID.TabIndex = 0;
            this.tbxProductID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(414, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            this.label8.Visible = false;
            // 
            // cbxUnits
            // 
            this.cbxUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cbxUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnits.ForeColor = System.Drawing.Color.White;
            this.cbxUnits.FormattingEnabled = true;
            this.cbxUnits.Items.AddRange(new object[] {
            "Unit",
            "Set",
            "Pack",
            "Pcs",
            "Quarts",
            "Reams",
            "Boxes",
            "Roll",
            "Pad",
            "Bottle",
            "Box",
            "Little",
            "Gallon",
            "Can"});
            this.cbxUnits.Location = new System.Drawing.Point(286, 156);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(201, 25);
            this.cbxUnits.TabIndex = 4;
            // 
            // tbxPerQty
            // 
            this.tbxPerQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbxPerQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPerQty.Enabled = false;
            this.tbxPerQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPerQty.ForeColor = System.Drawing.Color.White;
            this.tbxPerQty.Location = new System.Drawing.Point(285, 230);
            this.tbxPerQty.Name = "tbxPerQty";
            this.tbxPerQty.Size = new System.Drawing.Size(202, 25);
            this.tbxPerQty.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(168, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount Per Qty:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(301, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "  CANCEL";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.ForeColor = System.Drawing.Color.White;
            this.nudQuantity.Location = new System.Drawing.Point(285, 193);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(202, 25);
            this.nudQuantity.TabIndex = 5;
            // 
            // pbxItemImage
            // 
            this.pbxItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxItemImage.Image")));
            this.pbxItemImage.Location = new System.Drawing.Point(15, 74);
            this.pbxItemImage.Name = "pbxItemImage";
            this.pbxItemImage.Size = new System.Drawing.Size(150, 150);
            this.pbxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxItemImage.TabIndex = 12;
            this.pbxItemImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.Location = new System.Drawing.Point(15, 230);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrowse.Size = new System.Drawing.Size(132, 32);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "  BROWSE IMAGE";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Image:";
            // 
            // btnAutoGenerate
            // 
            this.btnAutoGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAutoGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoGenerate.FlatAppearance.BorderSize = 0;
            this.btnAutoGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAutoGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAutoGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoGenerate.ForeColor = System.Drawing.Color.White;
            this.btnAutoGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoGenerate.Image")));
            this.btnAutoGenerate.Location = new System.Drawing.Point(460, 45);
            this.btnAutoGenerate.Name = "btnAutoGenerate";
            this.btnAutoGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAutoGenerate.Size = new System.Drawing.Size(29, 25);
            this.btnAutoGenerate.TabIndex = 15;
            this.btnAutoGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoGenerate.UseVisualStyleBackColor = false;
            this.btnAutoGenerate.Click += new System.EventHandler(this.btnAutoGenerate_Click);
            // 
            // rbnCommon
            // 
            this.rbnCommon.AutoSize = true;
            this.rbnCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbnCommon.ForeColor = System.Drawing.Color.White;
            this.rbnCommon.Location = new System.Drawing.Point(285, 304);
            this.rbnCommon.Name = "rbnCommon";
            this.rbnCommon.Size = new System.Drawing.Size(82, 21);
            this.rbnCommon.TabIndex = 17;
            this.rbnCommon.TabStop = true;
            this.rbnCommon.Text = "Common";
            this.rbnCommon.UseVisualStyleBackColor = true;
            // 
            // rbnSpecial
            // 
            this.rbnSpecial.AutoSize = true;
            this.rbnSpecial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbnSpecial.ForeColor = System.Drawing.Color.White;
            this.rbnSpecial.Location = new System.Drawing.Point(371, 304);
            this.rbnSpecial.Name = "rbnSpecial";
            this.rbnSpecial.Size = new System.Drawing.Size(67, 21);
            this.rbnSpecial.TabIndex = 18;
            this.rbnSpecial.TabStop = true;
            this.rbnSpecial.Text = "Special";
            this.rbnSpecial.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(206, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Item Type:";
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(497, 399);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbnSpecial);
            this.Controls.Add(this.rbnCommon);
            this.Controls.Add(this.btnAutoGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbxItemImage);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxPerQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxUnits);
            this.Controls.Add(this.tbxProductID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxProductCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FrmAddItems_Activated);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxBrand;
        public System.Windows.Forms.TextBox tbxTotalAmount;
        public System.Windows.Forms.TextBox tbxProductCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbxUnits;
        public System.Windows.Forms.TextBox tbxPerQty;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblAddNew;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NumericUpDown nudQuantity;
        public System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pbxItemImage;
        public System.Windows.Forms.Button btnAutoGenerate;
        public System.Windows.Forms.RadioButton rbnCommon;
        public System.Windows.Forms.RadioButton rbnSpecial;
        private System.Windows.Forms.Label label10;
    }
}