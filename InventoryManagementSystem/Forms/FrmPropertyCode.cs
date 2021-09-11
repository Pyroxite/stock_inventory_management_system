using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Printing;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmPropertyCode : Form
    {
        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private DataTable _dataTable;

        public FrmPropertyCode(DataTable dataTable)
        {
            InitializeComponent();
            _dataTable = dataTable;
            AddToDataGrid(_dataTable);
        }

        private void AddToDataGrid(DataTable dataTable)
        {
            dgvPropertyItems.DataSource = dataTable;
            dgvPropertyItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPropertyItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPropertyItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPropertyItems.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void PrintSpecialRequests()
        {
            var report = new FrmReportWindow();
            var dataSet = new DataSet();
            var dataTable = new DataTable();
            var crpSpecial = new crpSpecialRelease();

            dataTable.Columns.Add("Departments/Offices", typeof(string));
            dataTable.Columns.Add("Property Code", typeof(string));
            dataTable.Columns.Add("Unit Price", typeof(string));
            dataTable.Columns.Add("Serial No.", typeof(string));

            foreach (DataGridViewRow item in dgvPropertyItems.Rows)
            {
                dataTable.Rows.Add(
                item.Cells[0].Value,
                item.Cells[1].Value,
                item.Cells[2].Value,
                item.Cells[3].Value);
            }

            if (dataTable.Rows.Count == 0)
                return;
            else
            {
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXmlSchema("SpecialRequests.xml");

                //crpSpecial.SetDataSource(dataSet);

                //TextObject requestDepartment = (TextObject)crpSpecial.ReportDefinition.Sections["Section1"].ReportObjects["crpDepartment"];
                //requestDepartment.Text = tbxEmpDt.Text;
                //TextObject dateRequested = (TextObject)crpSpecial.ReportDefinition.Sections["Section1"].ReportObjects["crpDateRequested"];
                //dateRequested.Text = lblRecievedDate.Text;
                //TextObject approvedDate = (TextObject)crpSpecial.ReportDefinition.Sections["Section1"].ReportObjects["crpApprovedRequest"];
                //approvedDate.Text = lblDateIssued.Text;
                //TextObject requestedBy = (TextObject)crpSpecial.ReportDefinition.Sections["Section5"].ReportObjects["crpRequestedBy"];
                //requestedBy.Text = cbxRequestsName.Text;
                //TextObject position = (TextObject)crpSpecial.ReportDefinition.Sections["Section5"].ReportObjects["crpPosition"];
                //position.Text = tbxEmpSt.Text;

                //report.crvReportViewer.ReportSource = crpSpecial;
                //report.lblPrintItems.Text = "SPECIAL REQUESTS";
                //report.ShowDialog();
            }
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrintSpecialRequests();
        }
    }
}
