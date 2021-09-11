using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmLogin : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmLogin()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
        }

        private void Login()
        {
            try
            {
                var _querySelect = "SELECT * FROM tbl_Accounts WHERE Name=@NAME AND Password=@PASSWORD";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_querySelect, _connection);
                _command.Parameters.AddWithValue("@NAME", tbxUsername.Text);
                _command.Parameters.AddWithValue("@PASSWORD", tbxPassword.Text);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    var main = new FrmMain(this);
                    main.lblUserName.Text = tbxUsername.Text;
                    main.AdminChecker(tbxUsername.Text, tbxPassword.Text);
                    main.Show();
                    Clear();
                    Hide();
                }
                else
                    MessageBox.Show("Username or Password are not available", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to login " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            tbxPassword.Clear();
            tbxUsername.Clear();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowPassword.Checked == true)
                tbxPassword.UseSystemPasswordChar = false;
            else
                tbxPassword.UseSystemPasswordChar = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            var createAccount = new FrmAdminCreateAccount();
            createAccount.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxUsername.Text) || !string.IsNullOrWhiteSpace(tbxPassword.Text))
                Login();
            else
                MessageBox.Show("Some fields are missing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}