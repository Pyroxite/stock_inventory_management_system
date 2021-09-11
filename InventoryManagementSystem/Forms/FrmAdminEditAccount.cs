using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmAdminEditAccount : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private readonly FrmAdminAccounts _account;

        public FrmAdminEditAccount(FrmAdminAccounts account)
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            _account = account;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var _queryUpdate = "UPDATE tbl_Accounts SET tbl_Accounts.Name=@NAME, tbl_Accounts.Password=@PASSWORD WHERE AccountID=@ACCOUNTID";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_queryUpdate, _connection);
                _command.Parameters.AddWithValue("@NAME", tbxNewUsername.Text);
                _command.Parameters.AddWithValue("@PASSWORD", tbxNewPassword.Text);
                _command.Parameters.AddWithValue("@ACCOUNTID", tbxUserID.Text);
                _command.ExecuteNonQuery();
                _connection.Close();
                _account.LoadAccount();
                DatabaseHelper.BackupDataBase();

                MessageBox.Show("This username has been updated");
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Connection Failed", ex.Message);
            }
        }

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}