using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmAdminAccounts : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;
        private string _appTitle = "INVENTORY MANAGEMENT SYSTEM";

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmAdminAccounts()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadAccount();
        }

        public void LoadAccount()
        {
            try
            {
                var _querySelect = "SELECT * FROM tbl_Accounts";
                dgvAccounts.Rows.Clear();
                var rowIndex = 0;
                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    rowIndex++;
                    dgvAccounts.Rows.Add(rowIndex,
                        _reader["AccountID"].ToString(),
                        _reader["Name"].ToString(),
                        _reader["Password"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Failed to load accounts");
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var colName = dgvAccounts.Columns[e.ColumnIndex].Name;
            if (colName == "acEdit")
            {
                var editAccount = new FrmAdminEditAccount(this);
                editAccount.tbxUserID.Text = dgvAccounts.Rows[e.RowIndex].Cells[1].Value.ToString();
                editAccount.tbxNewUsername.Text = dgvAccounts.Rows[e.RowIndex].Cells[2].Value.ToString();
                editAccount.tbxNewPassword.Text = dgvAccounts.Rows[e.RowIndex].Cells[3].Value.ToString();
                editAccount.Show();
            }
            else if (colName == "acDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this account?", _appTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        var _queryDelete = "DELETE FROM tbl_Accounts WHERE AccountID=@ACCOUNTID";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryDelete, _connection);
                        _command.Parameters.AddWithValue("@ACCOUNTID", dgvAccounts.Rows[e.RowIndex].Cells[1].Value);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        LoadAccount();
                    }
                    catch (Exception)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to delete account");
                    }
                }
            }
        }
    }
}