using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmAddStore : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private readonly FrmStoreLog _frmStore;
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmAddStore(FrmStoreLog frmStore)
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadDepartment();
            _frmStore = frmStore;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ClearFields()
        {
            tbxStoreInvoiceNo.Clear();
            tbxStoreName.Clear();
            cbxStoreDepartment.Text = "";
            nudStoreQuantity.Value = 0;
            dtpStoreRecieveDate.Value = DateTime.Now;
            tbxStoreDescription.Clear();
            tbxStoreAmount.Clear();
            tbxStoreTotal.Clear();
            dgvStoreItems.Rows.Clear();
        }

        private void LoadDepartment()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT * FROM tbl_Department";
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    cbxStoreDepartment.Items.Add(_reader["Department"].ToString());
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load department " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStoreSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();
            connection.ConnectionString = DatabaseHelper.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    foreach (DataGridViewRow row in dgvStoreItems.Rows)
                    {
                        connection.Open();
                        command.Connection = connection;
                        command = new OleDbCommand("INSERT INTO tbl_StoreLog (StoreInvoiceNo, StoreName, StoreQuantity, StoreDescription, StoreAmount, StoreTotal, StoreRecievedDate, StoreDepartment) VALUES (@StoreInvoiceNo, @StoreName, @StoreQuantity, @StoreDescription, @StoreAmount, @StoreTotal, @StoreRecievedDate, @StoreDepartment)", connection);

                        command.Parameters.AddWithValue("@StoreInvoiceNo", tbxStoreInvoiceNo.Text);
                        command.Parameters.AddWithValue("@StoreName", tbxStoreName.Text);
                        command.Parameters.AddWithValue("@StoreQuantity", row.Cells[1].Value);
                        command.Parameters.AddWithValue("@StoreDescription", row.Cells[2].Value);
                        command.Parameters.AddWithValue("@StoreAmount", row.Cells[3].Value);
                        command.Parameters.AddWithValue("@StoreTotal", row.Cells[4].Value);
                        command.Parameters.AddWithValue("@StoreRecievedDate", dtpStoreRecieveDate.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@StoreDepartment", cbxStoreDepartment.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                        _frmStore.LoadStore();
                        ClearFields();
                        DatabaseHelper.BackupDataBase();
                    }

                    dgvStoreItems.Rows.Clear();
                    MessageBox.Show("New store has been added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save this store " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            DataGridViewRow Rows = new DataGridViewRow();
            Rows.CreateCells(dgvStoreItems);
            Rows.Cells[1].Value = nudStoreQuantity.Value;
            Rows.Cells[2].Value = tbxStoreDescription.Text;
            Rows.Cells[3].Value = tbxStoreAmount.Text;
            Rows.Cells[4].Value = tbxStoreTotal.Text;
            dgvStoreItems.Rows.Add(Rows);

            nudStoreQuantity.Value = 0;
            tbxStoreDescription.Clear();
            tbxStoreAmount.Clear();
            tbxStoreTotal.Clear();
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {         
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    foreach (DataGridViewRow row in dgvStoreItems.Rows)
                    {
                        var _queryUpdate = "UPDATE tbl_StoreLog SET StoreName= @StoreName, StoreQuantity= @StoreQuantity, StoreDescription= @StoreDescription, StoreAmount= @StoreAmount, StoreTotal= @StoreTotal, StoreRecievedDate= @StoreRecievedDate, StoreDepartment= @StoreDepartment WHERE StoreInvoiceNo=@StoreInvoiceNo";
                        
                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryUpdate, _connection);
                        _command.Parameters.AddWithValue("@StoreName", tbxStoreName.Text);
                        _command.Parameters.AddWithValue("@StoreQuantity", row.Cells[1].Value);
                        _command.Parameters.AddWithValue("@StoreDescription", row.Cells[2].Value);
                        _command.Parameters.AddWithValue("@StoreAmount", row.Cells[3].Value);
                        _command.Parameters.AddWithValue("@StoreTotal", row.Cells[4].Value);
                        _command.Parameters.AddWithValue("@StoreRecievedDate", dtpStoreRecieveDate.Value.ToShortDateString());
                        _command.Parameters.AddWithValue("@StoreDepartment", cbxStoreDepartment.Text);
                        _command.Parameters.AddWithValue("@StoreInvoiceNo", tbxStoreInvoiceNo.Text);
                        _command.ExecuteNonQuery();
                        _connection.Close();

                        _frmStore.LoadStore();
                        ClearFields();
                        DatabaseHelper.BackupDataBase();
                    }

                    MessageBox.Show("this store has been updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save this store " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
