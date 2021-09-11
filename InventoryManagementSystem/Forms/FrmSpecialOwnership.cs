using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Printing;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmSpecialOwnership : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;
        private readonly string dateTimeNow = Convert.ToString(DateTime.Now.ToShortDateString());

        public FrmSpecialOwnership()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadRecords();
            LoadEmployee();
            LoadSupplyOfficers();
            lblDateUponTransfer.Text = dateTimeNow.ToString();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ClearFields()
        {
            tbxSearchName.Clear();
            tbxReqNo.Clear();
            tbxEmpPos.Clear();
            tbxEmpDep.Clear();
            tbxEmployeeID.Clear();
            tbxCurrenctOwner.Clear();
            tbxCurrenctPosition.Clear();
            tbxCurrenctDepartment.Clear();
            cbxNewOwner.Text = "";
            tbxNewPosition.Clear();
            tbxNewDepartment.Clear();
            cbxIssuedByUponTransfer.Text = "";
            tbxPreOwner.Clear();
        }

        private void LoadSupplyOfficers()
        {
            try
            {
                var _querySelect = "SELECT RecipName FROM tbl_Recipient WHERE ID";

                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    cbxIssuedByUponTransfer.Items.Add(_reader["RecipName"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load supply officers " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployee()
        {
            try
            {
                var _querySelect = "SELECT EmployeeName FROM tbl_Employee WHERE EmployeeNo";

                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    cbxNewOwner.Items.Add(_reader["EmployeeName"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load employees " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadRecords()
        {
            try
            {
                var _querySelect = "SELECT * FROM tbl_Recieved";
                var rowIndex = 0;

                dgvReciept.Rows.Clear();
                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    rowIndex++;
                    dgvReciept.Rows.Add(rowIndex,
                        _reader["ReqNo"].ToString(),
                        _reader["ReqName"].ToString(),
                        _reader["ProNo"].ToString(),
                        _reader["Unit"].ToString(),
                        _reader["Description"].ToString(),
                        _reader["Quantity"].ToString(),
                        _reader["AmountPerQty"].ToString(),
                        _reader["TotalAmount"].ToString(),
                        _reader["RecievedBy"].ToString(),
                        _reader["IssuedBy"].ToString(),
                        _reader["DateRecieved"].ToString(),
                        _reader["DateIssued"].ToString(),
                        _reader["EmployeeStatus"].ToString(),
                        _reader["EmployeeDept"].ToString(),
                        _reader["PreviousOwner"].ToString(),
                        _reader["DateUponTransfer"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load recieved list " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadToDataTable()
        {
            if (string.IsNullOrWhiteSpace(tbxSearchName.Text))
                MessageBox.Show("No name has been selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var ownershipReport = new FrmReportWindow();
                var dataSet = new DataSet();
                var dataTable = new DataTable();
                var ownership = new crpOwnership();

                dataTable.Columns.Add("Quantity", typeof(string));
                dataTable.Columns.Add("Unit", typeof(string));
                dataTable.Columns.Add("Description", typeof(string));
                dataTable.Columns.Add("Product Code", typeof(string));
                dataTable.Columns.Add("Date Upon Transfer", typeof(string));
                dataTable.Columns.Add("Total Amount", typeof(string));

                foreach (DataGridViewRow item in dgvReciept.Rows)
                {
                    dataTable.Rows.Add(
                        item.Cells[6].Value,
                        item.Cells[4].Value,
                        item.Cells[5].Value,
                        item.Cells[3].Value,
                        item.Cells[16].Value = lblDateUponTransfer.Text,
                        item.Cells[8].Value);
                }

                dataSet.Tables.Add(dataTable);
                dataSet.WriteXmlSchema("TranferedOwnership.xml");
                ownership.SetDataSource(dataSet);

                TextObject newDepartment = (TextObject)ownership.ReportDefinition.Sections["Section1"].ReportObjects["crpEntityName"];
                newDepartment.Text = tbxNewDepartment.Text;

                TextObject currentOwner = (TextObject)ownership.ReportDefinition.Sections["Section4"].ReportObjects["crpNoteCurrentOwner"];
                currentOwner.Text = tbxCurrenctOwner.Text;
                TextObject currentPosition = (TextObject)ownership.ReportDefinition.Sections["Section4"].ReportObjects["crpNoteCurrentPosition"];
                currentPosition.Text = tbxCurrenctPosition.Text;
                TextObject newOwner = (TextObject)ownership.ReportDefinition.Sections["Section4"].ReportObjects["crpNoteNewOwner"];
                newOwner.Text = cbxNewOwner.Text;
                TextObject newPosition = (TextObject)ownership.ReportDefinition.Sections["Section4"].ReportObjects["crpNoteNewPosition"];
                newPosition.Text = tbxNewPosition.Text;

                TextObject newOwnerRecieved = (TextObject)ownership.ReportDefinition.Sections["Section5"].ReportObjects["crpRecievedBy"];
                newOwnerRecieved.Text = cbxNewOwner.Text;
                TextObject newOwnerPosition = (TextObject)ownership.ReportDefinition.Sections["Section5"].ReportObjects["crpRecievedPosition"];
                newOwnerPosition.Text = tbxNewPosition.Text;
                TextObject recievedDate = (TextObject)ownership.ReportDefinition.Sections["Section5"].ReportObjects["crpRecievedDate"];
                recievedDate.Text = lblDateUponTransfer.Text;

                TextObject supplyOffiecr = (TextObject)ownership.ReportDefinition.Sections["Section5"].ReportObjects["crpIssuedBy"];
                supplyOffiecr.Text = cbxIssuedByUponTransfer.Text;
                TextObject issueddDate = (TextObject)ownership.ReportDefinition.Sections["Section5"].ReportObjects["crpIssuedDate"];
                issueddDate.Text = lblDateUponTransfer.Text;

                ownershipReport.crvReportViewer.ReportSource = ownership;
                ownershipReport.lblPrintItems.Text = "OWNERSHIP REPORT";
                ownershipReport.Show();
            }
        }

        private void tbxSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var _querySearch = "SELECT * FROM tbl_Recieved WHERE ReqName LIKE @REQNAME";
                var rowIndex = 0;

                dgvReciept.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_querySearch, _connection);
                _command.Parameters.AddWithValue("@REQNAME", tbxSearchName.Text + "%");
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    rowIndex++;
                    dgvReciept.Rows.Add(rowIndex,
                        _reader["ReqNo"].ToString(),
                        _reader["ReqName"].ToString(),
                        _reader["ProNo"].ToString(),
                        _reader["Unit"].ToString(),
                        _reader["Description"].ToString(),
                        _reader["Quantity"].ToString(),
                        _reader["AmountPerQty"].ToString(),
                        _reader["TotalAmount"].ToString(),
                        _reader["RecievedBy"].ToString(),
                        _reader["IssuedBy"].ToString(),
                        _reader["DateRecieved"].ToString(),
                        _reader["DateIssued"].ToString(),
                        _reader["EmployeeStatus"].ToString(),
                        _reader["EmployeeDept"].ToString(),
                        _reader["PreviousOwner"].ToString(),
                        _reader["DateUponTransfer"].ToString());

                    tbxReqNo.Text = _reader["ReqNo"].ToString();
                    tbxEmpPos.Text = _reader["EmployeeStatus"].ToString();
                    tbxEmpDep.Text = _reader["EmployeeDept"].ToString();
                    tbxPreOwner.Text = _reader["PreviousOwner"].ToString();
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load user list " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReciept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSearchName.Text = dgvReciept.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxCurrenctOwner.Text = tbxSearchName.Text;
            tbxCurrenctPosition.Text = tbxEmpPos.Text;
            tbxCurrenctDepartment.Text = tbxEmpDep.Text;

            tbxCurrenctOwner.Enabled = false;
            tbxCurrenctPosition.Enabled = false;
            tbxCurrenctDepartment.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxNewOwner.Text) || string.IsNullOrWhiteSpace(tbxNewPosition.Text)
                || string.IsNullOrWhiteSpace(tbxNewDepartment.Text) || string.IsNullOrWhiteSpace(cbxIssuedByUponTransfer.Text))
                MessageBox.Show("Some fields are missing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (tbxReqNo.Text == tbxEmployeeID.Text)
                {
                    MessageBox.Show("You can't change the owner's name to its own", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (tbxPreOwner.Text == "NONE")
                {
                    MessageBox.Show("You can't print unless you change the owner", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        var _queryUpdate = "UPDATE tbl_Recieved SET ReqNo=@EMPLOYEEID, ReqName=@REQNAME, EmployeeStatus=@EMPSTATUS, EmployeeDept=@EMPDEPT, PreviousOwner=@PREVIOUSOWNER, DateUponTransfer=@DATEUPONTRANSFER WHERE ReqNo=@REQNO";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryUpdate, _connection);
                        _command.Parameters.AddWithValue("@EMPLOYEEID", tbxEmployeeID.Text);
                        _command.Parameters.AddWithValue("@REQNAME", cbxNewOwner.Text);
                        _command.Parameters.AddWithValue("@EMPSTATUS", tbxNewPosition.Text);
                        _command.Parameters.AddWithValue("@EMPDEPT", tbxNewDepartment.Text);
                        _command.Parameters.AddWithValue("@PREVIOUSOWNER", tbxCurrenctOwner.Text);
                        _command.Parameters.AddWithValue("@DATEUPONTRANSFER", lblDateUponTransfer.Text);
                        _command.Parameters.AddWithValue("@REQNO", tbxReqNo.Text);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        LoadToDataTable();
                        LoadRecords();
                        ClearFields();
                        MessageBox.Show("This property has been updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to update ownership " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxNewOwner.Text = "";
            tbxNewPosition.Clear();
            tbxNewDepartment.Clear();
        }

        private void cbxNewOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT * FROM tbl_Employee WHERE EmployeeName=@NEWONER";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(query, _connection);
                _command.Parameters.AddWithValue("@NEWONER", cbxNewOwner.Text);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    tbxEmployeeID.Text = _reader["EmployeeNo"].ToString();
                    tbxNewPosition.Text = _reader["EmployeeStatus"].ToString();
                    tbxNewDepartment.Text = _reader["EmployeeDept"].ToString();
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load employee list " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}