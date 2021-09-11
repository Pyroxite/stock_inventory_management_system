using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Printing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmReleaseRequests : Form
    {
        private const string appName = "Inventory Management System";
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;
        private Form currentForm;
        private readonly string dateTimeNow = Convert.ToString(DateTime.Now.ToShortDateString());
        private FrmQuantity _quantity;

        public FrmReleaseRequests()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            pbxLoading.Visible = false;
            _quantity = new FrmQuantity(this);
            LockButtons();
            LoadRequests();
            LoadAvailableItems();
            LoadRecipient();
            lblDateIssued.Text = dateTimeNow.ToString();
        }

        private void OpenForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            form.BringToFront();
            form.ShowDialog();
        }

        private void LockButtons()
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSpecifyQty.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnRefresh.Enabled = false;
            btnAddItem.Enabled = false;
            btnRemoveClientItem.Enabled = false;
            cbxIssuedBy.Enabled = false;
            dgvAvailableItems.Enabled = false;
            dgvAddRequests.Enabled = false;
            dgvRequests.Enabled = false;
        }

        private void UnlockButtons()
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnSpecifyQty.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnRefresh.Enabled = true;
            btnAddItem.Enabled = true;
            btnRemoveClientItem.Enabled = true;
            cbxIssuedBy.Enabled = true;
            dgvAvailableItems.Enabled = true;
            dgvAddRequests.Enabled = true;
            dgvRequests.Enabled = true;
        }

        private void LoadRecipient()
        {
            try
            {
                var query = "SELECT RecipName FROM tbl_Recipient";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(query, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    cbxIssuedBy.Items.Add(_reader["RecipName"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Failed to load recipient", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRequests()
        {
            try
            {
                var status = "Pending";
                var query = "SELECT DISTINCT ReqName FROM tbl_RequestItem WHERE ReqStatus = @ReqStatus";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(query, _connection);
                _command.Parameters.AddWithValue("@ReqStatus", status);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    cbxRequestsName.Items.Add(_reader["ReqName"].ToString());
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load requests " + ex.Message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAvailableItems()
        {
            try
            {
                var query = "SELECT * FROM tbl_Products ORDER BY ProductID";
                var rowIndex = 0;

                dgvAvailableItems.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(query, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    if (Convert.ToInt32(_reader["Quantity"].ToString()) >= 1)
                    {
                        rowIndex++;
                        dgvAvailableItems.Rows.Add(rowIndex,
                            _reader["ProductID"].ToString(),
                            _reader["ProductCode"].ToString(),
                            _reader["Name"].ToString(),
                            _reader["Brand"].ToString(),
                            _reader["Units"].ToString(),
                            _reader["Quantity"].ToString(),
                            _reader["AmountPerQty"].ToString(),
                            _reader["Total"].ToString(),
                            _reader["ItemType"].ToString());
                    }
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load available items", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CopyItems()
        {
            for (int i = 0; i <= dgvAvailableItems.Rows.Count - 1; i++)
            {
                var rowAlreadyExist = false;
                var checkedCell = Convert.ToBoolean(dgvAvailableItems.Rows[i].Cells[11].Value);

                if (checkedCell == true)
                {
                    var row = dgvAvailableItems.Rows[i];

                    if (dgvAddRequests.Rows.Count != 0)
                    {
                        for (int j = 0; j <= dgvAddRequests.Rows.Count - 1; j++)
                        {
                            if (row.Cells[2].Value.ToString() == dgvAddRequests.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }

                        if (rowAlreadyExist == false)
                        {
                            dgvAddRequests.Rows.Add(row.Cells[2].Value.ToString(),
                                                   row.Cells[5].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[6].Value = 0,
                                                   row.Cells[7].Value = 0,
                                                   row.Cells[8].Value = 0,
                                                   row.Cells[9].Value.ToString()
                                                   );
                        }
                    }
                    else
                    {
                        dgvAddRequests.Rows.Add(row.Cells[2].Value.ToString(),
                                               row.Cells[5].Value.ToString(),
                                               row.Cells[3].Value.ToString(),
                                               row.Cells[6].Value = 0,
                                               row.Cells[7].Value = 0,
                                               row.Cells[8].Value = 0,
                                               row.Cells[9].Value.ToString()
                                               );
                    }
                }
            }
        }

        private void SubtractQuantity(long requestQty, object productCode, long requestTotal)
        {
            try
            {
                var convertProCode = Convert.ToInt64(productCode);
                var querySubtract = "UPDATE tbl_Products SET Quantity = Quantity - @QUANTITY , Total = Total - @REQUESTTOTAL WHERE ProductCode = @PROCODE";

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(querySubtract, _connection);
                _command.Parameters.AddWithValue("@QUANTITY", requestQty);
                _command.Parameters.AddWithValue("@REQUESTTOTAL", requestTotal);
                _command.Parameters.AddWithValue("@PROCODE", productCode);
                _command.ExecuteNonQuery();
                _connection.Close();

                LoadAvailableItems();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Failed to subtract total amount and quantity", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintCommonRequests()
        {
            var report = new FrmReportWindow();
            var dataSet = new DataSet();
            var dataTable = new DataTable();
            var crpCommon = new crpCommonRelease();

            dataTable.Columns.Add("Product Code", typeof(string));
            dataTable.Columns.Add("Unit", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));
            dataTable.Columns.Add("Amount Per Qty", typeof(string));
            dataTable.Columns.Add("Total Amount", typeof(string));

            foreach (DataGridViewRow item in dgvAddRequests.Rows)
            {
                if (item.Cells[6].Value.ToString() == "Common")
                {
                    dataTable.Rows.Add(
                    item.Cells[0].Value,
                    item.Cells[1].Value,
                    item.Cells[2].Value,
                    item.Cells[3].Value,
                    item.Cells[4].Value,
                    item.Cells[5].Value);
                }
            }

            if (dataTable.Rows.Count == 0)
                return;
            else
            {
                dataSet.Tables.Add(dataTable);
                dataSet.WriteXmlSchema("CommonRequests.xml");

                crpCommon.SetDataSource(dataSet);

                TextObject requestDepartment = (TextObject)crpCommon.ReportDefinition.Sections["Section1"].ReportObjects["crpDepartment"];
                requestDepartment.Text = tbxEmpDt.Text;
                TextObject dateRequested = (TextObject)crpCommon.ReportDefinition.Sections["Section1"].ReportObjects["crpDateRequested"];
                dateRequested.Text = lblRecievedDate.Text;
                TextObject approvedDate = (TextObject)crpCommon.ReportDefinition.Sections["Section1"].ReportObjects["crpApprovedRequest"];
                approvedDate.Text = lblDateIssued.Text;
                TextObject requestedBy = (TextObject)crpCommon.ReportDefinition.Sections["Section5"].ReportObjects["crpRequestedBy"];
                requestedBy.Text = cbxRequestsName.Text;
                TextObject position = (TextObject)crpCommon.ReportDefinition.Sections["Section5"].ReportObjects["crpPosition"];
                position.Text = tbxEmpSt.Text;

                report.crvReportViewer.ReportSource = crpCommon;
                report.lblPrintItems.Text = "COMMON REQUESTS";
                report.StartPosition = FormStartPosition.Manual;
                report.ShowDialog();
            }
        }

        private bool CheckRequestItems()
        {
            var requestItems = dgvRequests.Rows.Count;

            if (requestItems != 0)
            {
                if (MessageBox.Show("Are you sure you to continue?", "Client requests is not empty", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void SaveAndPrint()
        {
            for (int i = 0; i < dgvAvailableItems.Rows.Count; i++)
            {
                for (int j = 0; j < dgvAddRequests.Rows.Count; j++)
                {
                    if (dgvAvailableItems.Rows[i].Cells[2].Value.ToString() == dgvAddRequests.Rows[j].Cells[0].Value.ToString())
                    {
                        tbxPerPrice.Text = dgvAvailableItems.Rows[i].Cells[7].Value.ToString();
                        var availableQuantity = Convert.ToInt64(dgvAvailableItems.Rows[i].Cells[6].Value.ToString());
                        var requestQuantity = Convert.ToInt64(dgvAddRequests.Rows[j].Cells[3].Value.ToString());
                        var requestTotalAmount = Convert.ToInt64(tbxPerPrice.Text) * requestQuantity;

                        if (requestQuantity == 0)
                        {
                            MessageBox.Show("Enter a value for a request quantity to continue", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (requestQuantity > availableQuantity)
                        {
                            MessageBox.Show("Request quantity is greater than the available quantity", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (requestQuantity <= availableQuantity)
                        {
                            try
                            {
                                foreach (DataGridViewRow item in dgvAddRequests.Rows)
                                {
                                    if (dgvAvailableItems.Rows[i].Cells[2].Value.ToString() == dgvAddRequests.Rows[item.Index].Cells[0].Value.ToString())
                                    {

                                        //var _queryAdd = "INSERT INTO tbl_Recieved (ReqNo, ReqName, ProNo, Unit, Description, Quantity, ItemType, AmountPerQty, TotalAmount, RecievedBy, IssuedBy, DateRecieved, DateIssued, EmployeeStatus, EmployeeDept, PreviousOwner, DateUponTransfer) VALUES (@REQNO, @REQNAME, @PRONO, @UNIT, @DESCRIPTION, @QUANTITY, @ITEMTYPE, @AMOUNTPERQTY, @TOTALAMOUNT, @RECIEVEDBY, @ISSUEDBY, @DATERECIEVED, @DATEISSUED, @EMPLOYEESTATUS, @EMPLOYEEDEPT, @PREVIOUSOWNER, @DATEUPONTRANSFER)";

                                        //_connection.Open();
                                        //_command.Connection = _connection;
                                        //_command = new OleDbCommand(_queryAdd, _connection);

                                        //_command.Parameters.AddWithValue("@REQNO", tbxReqNo.Text);
                                        //_command.Parameters.AddWithValue("@REQNAME", cbxRequestsName.Text);
                                        //_command.Parameters.AddWithValue("@PRONO", item.Cells[0].Value);
                                        //_command.Parameters.AddWithValue("@UNIT", item.Cells[1].Value);
                                        //_command.Parameters.AddWithValue("@DESCRIPTION", item.Cells[2].Value);
                                        //_command.Parameters.AddWithValue("@QUANTITY", item.Cells[3].Value);

                                        //if (item.Cells[6].Value.ToString() == "Special")
                                        //    _command.Parameters.AddWithValue("@ITEMTYPE", "Special");
                                        //else if(item.Cells[6].Value.ToString() == "Common")
                                        //    _command.Parameters.AddWithValue("@ITEMTYPE", "Common");

                                        //_command.Parameters.AddWithValue("@AMOUNTPERQTY", tbxPerPrice.Text);
                                        //_command.Parameters.AddWithValue("@TOTALAMOUNT", requestTotalAmount);
                                        //_command.Parameters.AddWithValue("@RECIEVEDBY", tbxRecievdBy.Text);
                                        //_command.Parameters.AddWithValue("@ISSUEDBY", cbxIssuedBy.Text);
                                        //_command.Parameters.AddWithValue("@DATERECIEVED", lblRecievedDate.Text);
                                        //_command.Parameters.AddWithValue("@DATEISSUED", lblDateIssued.Text);
                                        //_command.Parameters.AddWithValue("@EMPLOYEESTATUS", tbxEmpSt.Text);
                                        //_command.Parameters.AddWithValue("@EMPLOYEEDEPT", tbxEmpDt.Text);
                                        //_command.Parameters.AddWithValue("@PREVIOUSOWNER", "None");
                                        //_command.Parameters.AddWithValue("@DATEUPONTRANSFER", "None");

                                        //_command.ExecuteNonQuery();
                                        //_connection.Close();

                                        //SubtractQuantity(requestQuantity, item.Cells[0].Value, requestTotalAmount);
                                        //DatabaseHelper.BackupDataBase();

                                        //item.Cells[4].Value = tbxPerPrice.Text;
                                        //item.Cells[5].Value = requestTotalAmount;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                _connection.Close();
                                MessageBox.Show("Failed to approve requests " + ex.Message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            MessageBox.Show("New Request items has been approved", appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrintCommonRequests();
            CheckForSpecialItems();
            pbxLoading.Visible = false;
        }

        public void CheckForSpecialItems()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Departments/Offices", typeof(string));
            dataTable.Columns.Add("Property Code", typeof(string));
            dataTable.Columns.Add("Unit Price", typeof(string));
            dataTable.Columns.Add("Serial No.", typeof(string));

            foreach (DataGridViewRow item in dgvAddRequests.Rows)
            {
                if (item.Cells[6].Value.ToString() == "Special")
                {
                    dataTable.Rows.Add(
                        item.Cells[1].Value.ToString(),
                        item.Cells[2].Value.ToString(),
                        item.Cells[3].Value.ToString(),
                        item.Cells[4].Value.ToString());
                }
            }

            if (dataTable.Rows.Count != 0)
            {
                var propertyCode = new FrmPropertyCode(dataTable);
                propertyCode.ShowDialog();
                return;
            }
            else
                return;
        }

        private void ApprovedItems()
        {
            for (int i = dgvRequests.Rows.Count - 1; i >= 0; i--)
            {
                var checkbox = Convert.ToBoolean(dgvRequests.Rows[i].Cells[5].Value);
                if (checkbox == true)
                {
                    try
                    {
                        var _queryUpdate = "UPDATE tbl_RequestItem SET tbl_RequestItem.ReqStatus = @ReqStatus WHERE ReqDesc = @ReqDesc";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryUpdate, _connection);
                        _command.Parameters.AddWithValue("@ReqStatus", "Approved");
                        _command.Parameters.AddWithValue("@REQDESC", dgvRequests.Rows[i].Cells[2].Value.ToString());
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                    }
                    catch (Exception)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to delete client request", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            cbxRequestsName_SelectedIndexChanged(null, null);
            EmptyRequest();
        }

        private void SearchItems(string searchText)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                try
                {
                    var greaterThan = 1;
                    var _querySearch = "SELECT * FROM tbl_Products WHERE Name LIKE @NAME AND Quantity >= '@QUANTITY'";
                    var rowIndex = 0;

                    dgvAvailableItems.Rows.Clear();
                    _connection.Open();
                    _command.Connection = _connection;
                    _command = new OleDbCommand(_querySearch, _connection);
                    _command.Parameters.AddWithValue("@NAME", tbxSearchItem.Text + "%");
                    _command.Parameters.AddWithValue("@QUANTITY", greaterThan);
                    _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        rowIndex++;
                        dgvAvailableItems.Rows.Add(rowIndex,
                            _reader["ProductID"].ToString(),
                            _reader["ProductCode"].ToString(),
                            _reader["Name"].ToString(),
                            _reader["Brand"].ToString(),
                            _reader["Units"].ToString(),
                            _reader["Quantity"].ToString(),
                            _reader["AmountPerQty"].ToString(),
                            _reader["Total"].ToString(),
                            _reader["ItemType"].ToString());
                    }
                    _connection.Close();
                }
                catch (Exception)
                {
                    _connection.Close();
                    MessageBox.Show("Failed to search available items", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                LoadAvailableItems();
        }

        private void ClientSelected()
        {
            try
            {
                var query = "SELECT tbl_RequestItem.*, tbl_Employee.EmployeeStatus, tbl_Employee.EmployeeDept FROM tbl_Employee INNER JOIN tbl_RequestItem ON tbl_Employee.EmployeeNo = tbl_RequestItem.ReqNo WHERE ReqName=@REQNAME AND ReqStatus=@ReqStatus";
                var rowIndex = 0;

                dgvRequests.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(query, _connection);
                _command.Parameters.AddWithValue("@REQNAME", cbxRequestsName.Text);
                _command.Parameters.AddWithValue("@ReqStatus", "Pending");
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    rowIndex++;
                    dgvRequests.Rows.Add(rowIndex,
                        _reader["ReqUnit"].ToString(),
                        _reader["ReqDesc"].ToString(),
                        _reader["ReqQuantity"].ToString(),
                        _reader["ReqType"].ToString());

                    lblRecievedDate.Text = _reader["ReqDate"].ToString();
                    tbxReqNo.Text = _reader["ReqNo"].ToString();
                    tbxRecievdBy.Text = _reader["ReqReceived"].ToString();
                    tbxEmpSt.Text = _reader["EmployeeStatus"].ToString();
                    tbxEmpDt.Text = _reader["EmployeeDept"].ToString();
                }
                _reader.Close();
                _connection.Close();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Failed to load client requests", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewItemImage(DataGridViewCellEventArgs e)
        {
            var colName = dgvAvailableItems.Columns[e.ColumnIndex].Name;
            if (colName == "releaseImgView")
            {
                var viewImage = new FrmViewImage();
                viewImage.lblViewCode.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                viewImage.lblViewName.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[3].Value.ToString();
                viewImage.lblViewBrand.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[4].Value.ToString();

                Image image;
                var profilePath = dgvAvailableItems.Rows[e.RowIndex].Cells[2].Value.ToString() + ".jpg";
                var applicationPath = Application.StartupPath + @"\Pictures\";
                var getProfile = Path.Combine(applicationPath, profilePath);

                if (File.Exists(getProfile))
                {
                    using (Stream stream = File.OpenRead(getProfile))
                        image = Image.FromStream(stream);

                    viewImage.pbxViewImage.Image = image;
                }
                else
                    viewImage.pbxViewImage.Image = null;

                viewImage.Show();
            }
        }

        private void EmptyRequest()
        {
            if (dgvAddRequests.Rows.Count == 0)
            {
                cbxRequestsName.Items.Clear();
                cbxRequestsName.Text = "";
            }
        }

        private void RemoveItems()
        {
            for (int i = dgvAddRequests.Rows.Count - 1; i >= 0; i--)
            {
                var checkbox = Convert.ToBoolean(dgvAddRequests.Rows[i].Cells[7].Value);
                if (checkbox == true)
                    dgvAddRequests.Rows.RemoveAt(i);
            }
        }

        private void cbxRequestsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSelected();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new FrmItems();
            OpenForm(new FrmAddItem(item));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAvailableItems();
        }

        private void tbxSearchItem_TextChanged(object sender, EventArgs e)
        {
            SearchItems(tbxSearchItem.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvAddRequests.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvAddRequests.Rows.Count == 0)
                MessageBox.Show("Request item is empty add item to continue", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrWhiteSpace(cbxIssuedBy.Text))
                MessageBox.Show("Issuing officer is required", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (CheckRequestItems() == false)
                return;
            else
            {
                pbxLoading.Visible = true;
                SaveAndPrint();
            }
        }

        private void cbxRequestsName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UnlockButtons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CopyItems();
            LoadAvailableItems();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItems();
        }

        private void btnSpecifyQty_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmQuantity(this));
        }

        private void btnRemoveClientItem_Click(object sender, EventArgs e)
        {
            ApprovedItems();
        }

        private void dgvAvailableItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewItemImage(e);
        }
    }
}