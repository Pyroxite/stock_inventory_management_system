using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmAdminCreateAccount : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;

        public FrmAdminCreateAccount()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();

            var _random = new Random();
            tbxID.Text = _random.Next(1, 1000).ToString();
        }

        private void ClearFields()
        {
            tbxID.Clear();
            tbxCreateUsername.Clear();
            tbxCreatePassword.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxCreateUsername.Text) || !string.IsNullOrWhiteSpace(tbxCreatePassword.Text))
            {
                try
                {
                    var _querySelect = "SELECT * FROM tbl_Accounts WHERE Name LIKE'" + tbxCreateUsername.Text + "'";

                    _connection.Open();
                    _command = new OleDbCommand(_querySelect, _connection);
                    _reader = _command.ExecuteReader();

                    if (_reader.Read())
                    {
                        _reader.Close();
                        MessageBox.Show("Username already exist");
                        _connection.Close();
                    }
                    else
                    {
                        var _queryAdd = "INSERT INTO tbl_Accounts VALUES (@ACCOUNTID, @NAME, @PASSWORD)";

                        _reader.Close();
                        _command = new OleDbCommand(_queryAdd, _connection);
                        _command.Parameters.AddWithValue("@ACCOUNTID", tbxID.Text);
                        _command.Parameters.AddWithValue("@NAME", tbxCreateUsername.Text);
                        _command.Parameters.AddWithValue("@PASSWORD", tbxCreatePassword.Text);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        ClearFields();
                        MessageBox.Show("Account has been created");
                    }
                }
                catch (Exception)
                {
                    _connection.Close();
                    MessageBox.Show("Failed To Create Account");
                }
            }
            else
            {
                MessageBox.Show("Missing fields");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new FrmLogin();
            login.Show();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chxCreateShowPassword.Checked == true)
                tbxCreatePassword.UseSystemPasswordChar = false;
            else
                tbxCreatePassword.UseSystemPasswordChar = true;
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