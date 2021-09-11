using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmQuantity : Form
    {
        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;
        private readonly FrmReleaseRequests _release;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmQuantity(FrmReleaseRequests release)
        {
            InitializeComponent();
            _release = release;
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value == 0)
                MessageBox.Show("Quantity should be greater than 0", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (DataGridViewRow item in _release.dgvAddRequests.SelectedRows)
                    item.Cells[3].Value = nudQuantity.Value;
            }
            Dispose();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lblAddNew_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}