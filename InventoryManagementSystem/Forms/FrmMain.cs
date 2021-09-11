using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmMain : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private FrmLogin _login;
        private Form currentMainChildForm;
        private Form currentForm;
        private Form tempForm;

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmMain(FrmLogin login)
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            DirectoryHelper.CreateDirectory();
            _login = login;
        }

        public void AdminChecker(string username, string password)
        {
            if (username == "pyroxite" && password == "pyroxitethegiant")
                btnManageAccounts.Visible = true;
            else
                btnManageAccounts.Visible = false;
        }

        private void CheckFormState()
        {
            if (pnlMain.Controls.Contains(tempForm))
            {
                int width = Convert.ToInt32(pnlMain.Size.Width.ToString());
                int height = Convert.ToInt32(pnlMain.Size.Height.ToString());
                tempForm.Size = new System.Drawing.Size(width, height);

                switch (tempForm.Name)
                {
                    case "FrmRequests":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                    case "FrmHistoryOfRequests":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                    case "FrmOwnership":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                    case "FrmReleaseRequests":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                    case "FrmItems":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                    case "FrmStoreLog":
                        pnlMain.Controls.Clear();
                        pnlMain.Controls.Add(tempForm);
                        tempForm.BringToFront();
                        tempForm.Show();
                        break;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentMainChildForm != null)
                currentMainChildForm.Close();

            currentMainChildForm = childForm;
            tempForm = childForm;

            tempForm.TopLevel = false;
            pnlMain.Controls.Add(tempForm);
            pnlMain.Tag = tempForm;
            tempForm.BringToFront();
            tempForm.Show();
        }

        private void OpenForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            form.BringToFront();
            form.ShowDialog();
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
            Application.Exit();
        }

        private void pbxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                CheckFormState();
            }
            else
            {
                WindowState = FormWindowState.Normal;
                CheckFormState();
            }
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmItems());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _login.Show();
            Hide();
        }

        private void btnManageProperties_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSpecialOwnership());
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAdminAccounts());
        }

        private void btnManageRequest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRequests());
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReleaseRequests());
        }

        private void btnHistoryResquests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHistoryOfRequests());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEmployees());
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            CheckFormState();
        }

        private void btnStoreLog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmStoreLog());
        }
    }
}