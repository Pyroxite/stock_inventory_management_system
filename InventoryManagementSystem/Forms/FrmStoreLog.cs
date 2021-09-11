using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmStoreLog : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command;
        private OleDbDataReader _reader;
        private Form currentForm;
        public FrmStoreLog()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadStore();
        }
        private void OpenForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            form.BringToFront();
            form.Show();
        }

        public void LoadStore()
        {
            try
            {
                var _querySelect = "SELECT DISTINCT tbl_StoreLog.StoreName, tbl_StoreLog.StoreInvoiceNo, tbl_StoreLog.StoreDepartment, tbl_StoreLog.StoreRecievedDate FROM tbl_StoreLog";
                var rowIndex = 0;

                dgvStoreList.Rows.Clear();
                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    rowIndex++;
                    dgvStoreList.Rows.Add(rowIndex,
                        _reader["StoreName"].ToString(),
                        _reader["StoreInvoiceNo"].ToString(),
                        _reader["StoreDepartment"].ToString(),
                        _reader["StoreRecievedDate"].ToString());
                }
                _reader.Close();
                _connection.Close();

            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Unable to load store list " + ex.Message);
            }
        }

        private void ModifyStoreLog(DataGridViewCellEventArgs e)
        {
            var colName = dgvStoreList.Columns[e.ColumnIndex].Name;

            if (colName == "storeView")
            {
                var addStore = new FrmAddStore(this);
                addStore.tbxStoreName.ReadOnly = true;
                addStore.tbxStoreInvoiceNo.ReadOnly = true;
                addStore.cbxStoreDepartment.Enabled = false;
                addStore.dtpStoreRecieveDate.Enabled = false;
                addStore.nudStoreQuantity.ReadOnly = true;
                addStore.tbxStoreDescription.ReadOnly = true;
                addStore.tbxStoreAmount.ReadOnly = true;
                addStore.tbxStoreTotal.ReadOnly = true;
                addStore.btnAddItems.Enabled = false;
                addStore.btnStoreSave.Enabled = false;
                addStore.btnUpdateStore.Enabled = false;
                addStore.dgvStoreItems.ReadOnly = true;
                addStore.lblStoreName.Text = dgvStoreList.Rows[e.RowIndex].Cells[1].Value.ToString();

                addStore.tbxStoreName.Text = dgvStoreList.Rows[e.RowIndex].Cells[1].Value.ToString();
                addStore.tbxStoreInvoiceNo.Text = dgvStoreList.Rows[e.RowIndex].Cells[2].Value.ToString();
                addStore.cbxStoreDepartment.Text = dgvStoreList.Rows[e.RowIndex].Cells[3].Value.ToString();
                addStore.dtpStoreRecieveDate.Value = DateTime.Parse(dgvStoreList.Rows[e.RowIndex].Cells[4].Value.ToString());

                try
                {
                    var querySelect = "SELECT tbl_StoreLog.StoreQuantity, tbl_StoreLog.StoreDescription, tbl_StoreLog.StoreAmount, tbl_StoreLog.StoreTotal FROM tbl_StoreLog WHERE StoreInvoiceNo = @StoreInvoiceNo";
                    var rowIndex = 0;

                    addStore.dgvStoreItems.Rows.Clear();
                    _connection.Open();
                    _command.Connection = _connection;
                    _command = new OleDbCommand(querySelect, _connection);
                    _command.Parameters.AddWithValue("@StoreInvoiceNo", dgvStoreList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    _command.Parameters.AddWithValue("@StoreRecievedDate", DateTime.Parse(dgvStoreList.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        rowIndex++;
                        addStore.dgvStoreItems.Rows.Add(rowIndex,
                            _reader["StoreQuantity"].ToString(),
                            _reader["StoreDescription"].ToString(),
                            _reader["StoreAmount"].ToString(),
                            _reader["StoreTotal"].ToString());
                    }
                    _reader.Close();
                    _connection.Close();
                    addStore.Show();
                }
                catch (Exception ex)
                {
                    _connection.Close();
                    MessageBox.Show("Failed to load store records " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (colName == "storeEdit")
            {
                var addStore = new FrmAddStore(this);
                addStore.btnAddItems.Enabled = false;
                addStore.btnStoreSave.Enabled = false;
                addStore.lblStoreName.Text = dgvStoreList.Rows[e.RowIndex].Cells[1].Value.ToString();
                addStore.nudStoreQuantity.Enabled = false;
                addStore.tbxStoreDescription.Enabled = false;
                addStore.tbxStoreAmount.Enabled = false;
                addStore.tbxStoreTotal.Enabled = false;

                addStore.tbxStoreName.Text = dgvStoreList.Rows[e.RowIndex].Cells[1].Value.ToString();
                addStore.tbxStoreInvoiceNo.Text = dgvStoreList.Rows[e.RowIndex].Cells[2].Value.ToString();
                addStore.cbxStoreDepartment.Text = dgvStoreList.Rows[e.RowIndex].Cells[3].Value.ToString();
                addStore.dtpStoreRecieveDate.Value = DateTime.Parse(dgvStoreList.Rows[e.RowIndex].Cells[4].Value.ToString());

                try
                {
                    var querySelect = "SELECT tbl_StoreLog.StoreQuantity, tbl_StoreLog.StoreDescription, tbl_StoreLog.StoreAmount, tbl_StoreLog.StoreTotal FROM tbl_StoreLog WHERE StoreInvoiceNo = @StoreInvoiceNo";
                    var rowIndex = 0;

                    addStore.dgvStoreItems.Rows.Clear();
                    _connection.Open();
                    _command.Connection = _connection;
                    _command = new OleDbCommand(querySelect, _connection);
                    _command.Parameters.AddWithValue("@StoreInvoiceNo", dgvStoreList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    _command.Parameters.AddWithValue("@StoreRecievedDate", DateTime.Parse(dgvStoreList.Rows[e.RowIndex].Cells[4].Value.ToString()));
                    _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        rowIndex++;
                        addStore.dgvStoreItems.Rows.Add(rowIndex,
                            _reader["StoreQuantity"].ToString(),
                            _reader["StoreDescription"].ToString(),
                            _reader["StoreAmount"].ToString(),
                            _reader["StoreTotal"].ToString());
                    }
                    _reader.Close();
                    _connection.Close();
                    addStore.Show();
                }
                catch (Exception ex)
                {
                    _connection.Close();
                    MessageBox.Show("Failed to load store records " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (colName == "storeDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this store?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        var _queryDelete = "DELETE FROM tbl_StoreLog WHERE StoreInvoiceNo=@StoreInvoiceNo";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryDelete, _connection);
                        _command.Parameters.AddWithValue("@StoreInvoiceNo", dgvStoreList.Rows[e.RowIndex].Cells[2].Value);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        LoadStore();
                    }
                    catch (Exception ex)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to delete item " + ex.Message);
                    }
                }
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAddStore(this));
        }

        private void dgvStoreList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyStoreLog(e);
        }
    }
}
