using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmRequests : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;

        public FrmRequests()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadSupplyOfficers();
        }

        private void ValidateClient()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                try
                {
                    int count = 0;
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = "SELECT * FROM tbl_Employee WHERE EmployeeNo = '" + txtid.Text + "'";
                    _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        count++;
                        txtEntryName.Text = _reader["EmployeeName"].ToString();
                    }

                    cbxUnit.Focus();
                    _reader.Close();
                    _connection.Close();

                    if (count == 0)
                    {
                        MessageBox.Show("No record found", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (MessageBox.Show("Would you like to add this employee?", "No record found", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            FrmEmployees frmeployee = new FrmEmployees();
                            frmeployee.txtEmpNo.Text = txtid.Text;
                            frmeployee.ShowDialog();
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _connection.Close();
                    MessageBox.Show("Failed to check employee account " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddItem()
        {
            DataGridViewRow Rows = new DataGridViewRow();
            Rows.CreateCells(dgvList);
            Rows.Cells[0].Value = cbxUnit.Text;
            Rows.Cells[1].Value = txtItemDescription.Text;
            Rows.Cells[2].Value = nudRequestQuantity.Text;
            Rows.Cells[3].Value = cbxTypeOfItem.Text;
            dgvList.Rows.Add(Rows);

            cbxUnit.Text = "";
            txtItemDescription.Clear();
            nudRequestQuantity.Value = 0;
            cbxTypeOfItem.Text = "";
            cbxUnit.Focus();
        }

        private void SaveItems()
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();
            connection.ConnectionString = DatabaseHelper.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    foreach (DataGridViewRow row in dgvList.Rows)
                    {
                        connection.Open();
                        command.Connection = connection;
                        command = new OleDbCommand("INSERT INTO tbl_RequestItem values (@ReqNo, @ReqName, @ReqUnit, @ReqDesc, @ReqQuantiy, @ReqDate, @ReqReceived, @ReqType, @ReqStatus)", connection);
                        command.Parameters.AddWithValue("@ReqNo", txtid.Text);
                        command.Parameters.AddWithValue("@ReqName", txtEntryName.Text);
                        command.Parameters.AddWithValue("@ReqUnit", row.Cells[0].Value);
                        command.Parameters.AddWithValue("@ReqDesc", row.Cells[1].Value);
                        command.Parameters.AddWithValue("@ReqQuantiy", row.Cells[2].Value);
                        command.Parameters.AddWithValue("@ReqDate", dtpDateRequested.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@ReqReceived", cbxReceivedBy.Text);
                        command.Parameters.AddWithValue("@ReqType", row.Cells[3].Value);
                        command.Parameters.AddWithValue("@ReqStatus", "Pending");
                        command.ExecuteNonQuery();
                        connection.Close();
                        DatabaseHelper.BackupDataBase();
                    }

                    dgvList.Rows.Clear();
                    Clear();
                    MessageBox.Show("New request has been added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save request " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSupplyOfficers()
        {
            try
            {
                txtid.Focus();
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT * FROM tbl_Recipient";
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    cbxReceivedBy.Items.Add(_reader["RecipName"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load request items" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtid.Text = "";
            txtEntryName.Text = "";
            cbxUnit.Text = "";
            txtItemDescription.Text = "";
            nudRequestQuantity.Text = "";
            cbxReceivedBy.Text = "";
            txtid.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxUnit.Text) || string.IsNullOrWhiteSpace(txtItemDescription.Text) || nudRequestQuantity.Value == 0 || string.IsNullOrWhiteSpace(cbxTypeOfItem.Text) || string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtEntryName.Text) || string.IsNullOrWhiteSpace(cbxReceivedBy.Text))
                MessageBox.Show("Some fields are missing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                AddItem();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
                MessageBox.Show("Employee No. is required", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (string.IsNullOrWhiteSpace(txtEntryName.Text))
                MessageBox.Show("Employee Name is required", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (string.IsNullOrWhiteSpace(cbxReceivedBy.Text))
                MessageBox.Show("Received by. is required", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (dgvList.RowCount == 0)
                MessageBox.Show("List is required", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                SaveItems();
        }

        private void FrmRequestItem_Activated(object sender, EventArgs e)
        {
            txtid.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.SelectedRows)
                if (!row.IsNewRow)
                    dgvList.Rows.Remove(row);
        }

        private void txtitemDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nudRequestQuantity.Focus();
        }

        private void nudRequestQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.Focus();
        }

        private void btnCheckEmployeeNo_Click(object sender, EventArgs e)
        {
            ValidateClient();
        }
    }
}

