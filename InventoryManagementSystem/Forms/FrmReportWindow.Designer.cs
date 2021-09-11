
namespace InventoryManagementSystem
{
    partial class FrmReportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportWindow));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.lblPrintItems = new System.Windows.Forms.Label();
            this.crvReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMainMenu.Controls.Add(this.pbxMaximize);
            this.pnlMainMenu.Controls.Add(this.pbxMinimize);
            this.pnlMainMenu.Controls.Add(this.pictureBox1);
            this.pnlMainMenu.Controls.Add(this.pbxClose);
            this.pnlMainMenu.Controls.Add(this.lblPrintItems);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(989, 34);
            this.pnlMainMenu.TabIndex = 4;
            this.pnlMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainMenu_MouseDown);
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaximize.Image")));
            this.pbxMaximize.Location = new System.Drawing.Point(937, 9);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(15, 15);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaximize.TabIndex = 7;
            this.pbxMaximize.TabStop = false;
            this.pbxMaximize.Click += new System.EventHandler(this.pbxMaximize_Click);
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimize.Image")));
            this.pbxMinimize.Location = new System.Drawing.Point(910, 9);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 6;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(963, 9);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(15, 15);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 4;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // lblPrintItems
            // 
            this.lblPrintItems.AutoSize = true;
            this.lblPrintItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintItems.ForeColor = System.Drawing.Color.White;
            this.lblPrintItems.Location = new System.Drawing.Point(35, 8);
            this.lblPrintItems.Name = "lblPrintItems";
            this.lblPrintItems.Size = new System.Drawing.Size(159, 17);
            this.lblPrintItems.TabIndex = 0;
            this.lblPrintItems.Text = "PRINT AVAILABLE ITEMS";
            // 
            // crvReportViewer
            // 
            this.crvReportViewer.ActiveViewIndex = -1;
            this.crvReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportViewer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crvReportViewer.Location = new System.Drawing.Point(0, 34);
            this.crvReportViewer.Name = "crvReportViewer";
            this.crvReportViewer.ShowCloseButton = false;
            this.crvReportViewer.ShowCopyButton = false;
            this.crvReportViewer.ShowExportButton = false;
            this.crvReportViewer.ShowGroupTreeButton = false;
            this.crvReportViewer.ShowLogo = false;
            this.crvReportViewer.ShowParameterPanelButton = false;
            this.crvReportViewer.ShowTextSearchButton = false;
            this.crvReportViewer.Size = new System.Drawing.Size(989, 525);
            this.crvReportViewer.TabIndex = 5;
            this.crvReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.ControlBox = false;
            this.Controls.Add(this.crvReportViewer);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "FrmReportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxClose;
        public System.Windows.Forms.Label lblPrintItems;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportViewer;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private System.Windows.Forms.PictureBox pbxMinimize;
    }
}