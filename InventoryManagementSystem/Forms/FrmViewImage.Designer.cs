
namespace InventoryManagementSystem
{
    partial class FrmViewImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewImage));
            this.pbxViewImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.lblViewCode = new System.Windows.Forms.Label();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblViewBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewImage)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxViewImage
            // 
            this.pbxViewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxViewImage.Location = new System.Drawing.Point(12, 51);
            this.pbxViewImage.Name = "pbxViewImage";
            this.pbxViewImage.Size = new System.Drawing.Size(300, 300);
            this.pbxViewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxViewImage.TabIndex = 0;
            this.pbxViewImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Brand:";
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.Controls.Add(this.pictureBox2);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.lblAddNew);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(570, 34);
            this.pnlMainMenu.TabIndex = 7;
            this.pnlMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainMenu_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(544, 9);
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
            this.lblAddNew.Size = new System.Drawing.Size(86, 17);
            this.lblAddNew.TabIndex = 0;
            this.lblAddNew.Text = "VIEW IMAGE";
            // 
            // lblViewCode
            // 
            this.lblViewCode.AutoSize = true;
            this.lblViewCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCode.ForeColor = System.Drawing.Color.White;
            this.lblViewCode.Location = new System.Drawing.Point(332, 66);
            this.lblViewCode.Name = "lblViewCode";
            this.lblViewCode.Size = new System.Drawing.Size(62, 15);
            this.lblViewCode.TabIndex = 8;
            this.lblViewCode.Text = ": 0944256";
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewName.ForeColor = System.Drawing.Color.White;
            this.lblViewName.Location = new System.Drawing.Point(332, 104);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(177, 15);
            this.lblViewName.TabIndex = 9;
            this.lblViewName.Text = ": B40 Gaming Wifi Motherbaord";
            // 
            // lblViewBrand
            // 
            this.lblViewBrand.AutoSize = true;
            this.lblViewBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBrand.ForeColor = System.Drawing.Color.White;
            this.lblViewBrand.Location = new System.Drawing.Point(332, 142);
            this.lblViewBrand.Name = "lblViewBrand";
            this.lblViewBrand.Size = new System.Drawing.Size(43, 15);
            this.lblViewBrand.TabIndex = 10;
            this.lblViewBrand.Text = ": ASUS";
            // 
            // FrmViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(570, 372);
            this.ControlBox = false;
            this.Controls.Add(this.lblViewBrand);
            this.Controls.Add(this.lblViewName);
            this.Controls.Add(this.lblViewCode);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxViewImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmViewImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewImage)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbxClose;
        public System.Windows.Forms.Label lblAddNew;
        public System.Windows.Forms.PictureBox pbxViewImage;
        public System.Windows.Forms.Label lblViewCode;
        public System.Windows.Forms.Label lblViewName;
        public System.Windows.Forms.Label lblViewBrand;
    }
}