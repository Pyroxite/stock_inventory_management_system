using CrystalDecisions.CrystalReports.Engine;
using InventoryManagementSystem.Printing;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmItems : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command;
        private OleDbDataReader _reader;
        private Form currentForm;
        private readonly string _appTitle = "Inventory Management System";

        public FrmItems()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadAvailableItems();
            LoadOutOfStock();
        }

        private void PrintMonthlyItems()
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;

            try
            {
                connection.ConnectionString = DatabaseHelper.GetConnection();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT tbl_Products.Name, tbl_Products.Units, tbl_Products.Quantity FROM tbl_Products WHERE tbl_Products.DateAdded BETWEEN'" + dtpStartDate.Value.ToShortDateString() + "' AND '" + dtpEndDate.Value.ToShortDateString() + "'";
                reader = command.ExecuteReader();

                var itemReport = new FrmReportWindow();
                var dataSet = new DataSet();
                var dataTable = new DataTable();
                var crpMonthlyReport = new crpMonthlyReport();
                dataTable.Columns.Add("Product Name", typeof(string));
                dataTable.Columns.Add("Unit", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(string));

                while (reader.Read())
                {
                    dataTable.Rows.Add(
                        reader["Name"].ToString(),
                        reader["Units"].ToString(),
                        reader["Quantity"].ToString());
                }
                connection.Close();

                dataSet.Tables.Add(dataTable);
                dataSet.WriteXmlSchema("MonthlyReport.xml");

                crpMonthlyReport.SetDataSource(dataSet);

                TextObject dtMonthly = (TextObject)crpMonthlyReport.ReportDefinition.Sections["Section1"].ReportObjects["dtMonthlyReport"];
                dtMonthly.Text = dtpEndDate.Value.ToString("MMMM/dd/yyyy");

                itemReport.crvReportViewer.ReportSource = crpMonthlyReport;
                itemReport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to print by date " + ex.Message);
            }
        }

        private void ModifyAvailableItems(DataGridViewCellEventArgs e)
        {
            var colName = dgvAvailableItems.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                var addProduct = new FrmAddItem(this);
                addProduct.lblAddNew.Text = "EDIT";
                addProduct.btnAdd.Enabled = false;
                addProduct.btnUpdate.Enabled = true;
                addProduct.tbxProductCode.Enabled = false;
                addProduct.btnAutoGenerate.Enabled = false;

                addProduct.tbxProductID.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                addProduct.tbxProductCode.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                addProduct.tbxName.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[3].Value.ToString();
                addProduct.tbxBrand.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                addProduct.cbxUnits.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                addProduct.nudQuantity.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[6].Value.ToString();
                addProduct.tbxPerQty.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[7].Value.ToString();
                addProduct.tbxTotalAmount.Text = dgvAvailableItems.Rows[e.RowIndex].Cells[8].Value.ToString();

                if (dgvAvailableItems.Rows[e.RowIndex].Cells[9].Value.ToString() == "True")
                    addProduct.rbnCommon.Checked = true;
                else if (dgvAvailableItems.Rows[e.RowIndex].Cells[9].Value.ToString() == "False")
                    addProduct.rbnCommon.Checked = false;

                Image image;
                var profilePath = dgvAvailableItems.Rows[e.RowIndex].Cells[2].Value.ToString() + ".jpg";
                var applicationPath = Application.StartupPath + @"\Pictures\";
                var getProfile = Path.Combine(applicationPath, profilePath);

                if (File.Exists(getProfile))
                {
                    using (Stream stream = File.OpenRead(getProfile))
                        image = Image.FromStream(stream);

                    addProduct.pbxItemImage.Image = image;
                }
                else
                    addProduct.pbxItemImage.Image = null;

                addProduct.Show();
            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", _appTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        var _queryDelete = "DELETE FROM tbl_Products WHERE ProductID=@PRODUCTID";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryDelete, _connection);
                        _command.Parameters.AddWithValue("@PRODUCTID", dgvAvailableItems.Rows[e.RowIndex].Cells[1].Value);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        LoadAvailableItems();
                        tbxSearchAvailableItem.Clear();
                    }
                    catch (Exception)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to delete item");
                    }
                }
            }
            else if (colName == "imgView")
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

        private void ModifyOutOfStock(DataGridViewCellEventArgs e)
        {
            var colName = dgvOutOfStock.Columns[e.ColumnIndex].Name;
            if (colName == "outAdd")
            {
                var addProduct = new FrmAddItem(this);
                addProduct.lblAddNew.Text = "ADD ITEM";
                addProduct.btnAdd.Enabled = false;
                addProduct.btnUpdate.Enabled = true;

                addProduct.tbxProductCode.Enabled = false;

                addProduct.tbxProductID.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[1].Value.ToString();
                addProduct.tbxProductCode.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                addProduct.tbxName.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                addProduct.tbxBrand.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[4].Value.ToString();
                addProduct.cbxUnits.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[5].Value.ToString();
                addProduct.nudQuantity.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[6].Value.ToString();
                addProduct.tbxPerQty.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[7].Value.ToString();
                addProduct.tbxTotalAmount.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[8].Value.ToString();

                if (dgvOutOfStock.Rows[e.RowIndex].Cells[9].Value.ToString() == "True")
                    addProduct.rbnCommon.Checked = true;
                else if (dgvOutOfStock.Rows[e.RowIndex].Cells[9].Value.ToString() == "False")
                    addProduct.rbnCommon.Checked = false;

                Image image;
                var profilePath = dgvOutOfStock.Rows[e.RowIndex].Cells[2].Value.ToString() + ".jpg";
                var applicationPath = Application.StartupPath + @"\Pictures\";
                var getProfile = Path.Combine(applicationPath, profilePath);

                if (File.Exists(getProfile))
                {
                    using (Stream stream = File.OpenRead(getProfile))
                        image = Image.FromStream(stream);

                    addProduct.pbxItemImage.Image = image;
                }
                else
                    addProduct.pbxItemImage.Image = null;

                addProduct.Show();
            }
            else if (colName == "outDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", _appTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        var _queryDelete = "DELETE FROM tbl_Products WHERE ProductID=@PRODUCTID";

                        _connection.Open();
                        _command.Connection = _connection;
                        _command = new OleDbCommand(_queryDelete, _connection);
                        _command.Parameters.AddWithValue("@PRODUCTID", dgvOutOfStock.Rows[e.RowIndex].Cells[1].Value);
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        DatabaseHelper.BackupDataBase();
                        LoadAvailableItems();
                        tbxSearchOutStock.Clear();
                    }
                    catch (Exception)
                    {
                        _connection.Close();
                        MessageBox.Show("Failed to delete");
                    }
                }
            }
            else if (colName == "outImgView")
            {
                var viewImage = new FrmViewImage();
                viewImage.lblViewCode.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                viewImage.lblViewName.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                viewImage.lblViewBrand.Text = dgvOutOfStock.Rows[e.RowIndex].Cells[4].Value.ToString();

                Image image;
                var profilePath = dgvOutOfStock.Rows[e.RowIndex].Cells[2].Value.ToString() + ".jpg";
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

        private void OpenForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            form.BringToFront();
            form.ShowDialog();
        }

        public void LoadOutOfStock()
        {
            try
            {
                var _querySelect = "SELECT * FROM tbl_Products ORDER BY ProductID";
                var proID = "";
                var rowIndex = 0;

                dgvOutOfStock.Rows.Clear();
                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    if (Convert.ToInt32(_reader["Quantity"].ToString()) == 0)
                    {
                        rowIndex++;
                        dgvOutOfStock.Rows.Add(rowIndex,
                            _reader["ProductID"].ToString(),
                            _reader["ProductCode"].ToString(),
                            _reader["Name"].ToString(),
                            _reader["Brand"].ToString(),
                            _reader["Units"].ToString(),
                            _reader["Quantity"].ToString(),
                            _reader["AmountPerQty"].ToString(),
                            _reader["Total"].ToString(),
                            _reader["ItemType"].ToString());

                        ZeroAmount(Convert.ToInt32(_reader["Quantity"].ToString()));
                        proID = _reader["ProductID"].ToString();
                    }
                }
                _reader.Close();
                _connection.Close();

            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Unable to load out of stock items " + ex.Message);
            }
        }

        private void PrintOutOfStock()
        {
            var itemReport = new FrmReportWindow();
            itemReport.lblPrintItems.Text = "PRINT OUT OF STOCK";
            var dataSet = new DataSet();
            var dataTable = new DataTable();
            var crpOutOfStock = new crpOutOfStock();

            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Unit", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));

            foreach (DataGridViewRow item in dgvOutOfStock.Rows)
            {
                dataTable.Rows.Add(
                    item.Cells[3].Value,
                    item.Cells[5].Value,
                    item.Cells[6].Value);
            }

            dataSet.Tables.Add(dataTable);
            dataSet.WriteXmlSchema("OutOfStock.xml");

            crpOutOfStock.SetDataSource(dataSet);

            itemReport.crvReportViewer.ReportSource = crpOutOfStock;
            itemReport.ShowDialog();
        }

        private void PrintAvailableItems()
        {
            var itemReport = new FrmReportWindow();
            var dataSet = new DataSet();
            var dataTable = new DataTable();
            var crpAvailableItems = new crpAvailableItems();

            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Unit", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(string));

            foreach (DataGridViewRow item in dgvAvailableItems.Rows)
            {
                dataTable.Rows.Add(
                    item.Cells[3].Value,
                    item.Cells[5].Value,
                    item.Cells[6].Value);
            }

            dataSet.Tables.Add(dataTable);
            dataSet.WriteXmlSchema("AvailableItems.xml");

            crpAvailableItems.SetDataSource(dataSet);

            TextObject asOf = (TextObject)crpAvailableItems.ReportDefinition.Sections["Section1"].ReportObjects["dpAvailableItems"];
            asOf.Text = DateTime.Now.ToString("MMMM/dd/yyyy");

            itemReport.crvReportViewer.ReportSource = crpAvailableItems;
            itemReport.ShowDialog();
        }

        public void LoadAvailableItems()
        {
            try
            {
                var _querySelect = "SELECT * FROM tbl_Products ORDER BY ProductID";
                var rowIndex = 0;

                dgvAvailableItems.Rows.Clear();
                _connection.Open();
                _command = new OleDbCommand(_querySelect, _connection);
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
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load products " + ex.Message);
            }
        }

        private void SearchOutOfStock()
        {
            try
            {
                var _querySearch = "SELECT * FROM tbl_Products WHERE Name LIKE @NAME";
                var rowIndex = 0;

                dgvOutOfStock.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_querySearch, _connection);
                _command.Parameters.AddWithValue("@NAME", tbxSearchOutStock.Text + "%");
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    if (Convert.ToInt32(_reader["Quantity"].ToString()) == 0)
                    {
                        rowIndex++;
                        dgvOutOfStock.Rows.Add(rowIndex,
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
                _connection.Close();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Error in searching items");
            }
        }

        private void SearchAvailableItems()
        {
            try
            {
                var _querySearch = "SELECT * FROM tbl_Products WHERE Name LIKE @NAME";
                var rowIndex = 0;

                dgvAvailableItems.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_querySearch, _connection);
                _command.Parameters.AddWithValue("@NAME", tbxSearchAvailableItem.Text + "%");
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
                _connection.Close();
            }
            catch (Exception)
            {
                _connection.Close();
                MessageBox.Show("Error in searching items");
            }
        }

        private void ZeroAmount(int quantity)
        {
            try
            {
                var querySubtract = "UPDATE tbl_Products SET AmountPerQty=@AMOUNTPERQTY, Total=@TOTAL WHERE Quantity=@QUANTITY";

                _command.Connection = _connection;
                _command = new OleDbCommand(querySubtract, _connection);
                _command.Parameters.AddWithValue("@AMOUNTPERQTY", 0);
                _command.Parameters.AddWithValue("@TOTAL", 0);
                _command.Parameters.AddWithValue("@QUANTITY", quantity);
                _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in subtracting amount from the product");
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAddItem(this));
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSearchAvailableItem.Text))
                SearchAvailableItems();
            else
                LoadAvailableItems();
        }

        private void dgvOutOfStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyOutOfStock(e);
        }


        private void btnOutRefresh_Click(object sender, EventArgs e)
        {
            tbxSearchOutStock.Clear();
            LoadOutOfStock();
        }

        private void tbxSearchOutStock_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearchOutStock.Text))
                LoadOutOfStock();
            else
                SearchOutOfStock();
        }

        private void btnPrintAvailableItem_Click(object sender, EventArgs e)
        {
            if (dgvAvailableItems.Rows.Count == 0)
            {
                MessageBox.Show("Nothing to print because available item is empty", "Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                PrintAvailableItems();
        }

        private void btnPrintOutOfStock_Click(object sender, EventArgs e)
        {
            PrintOutOfStock();
        }

        private void btnAvailableRefresh_Click(object sender, EventArgs e)
        {
            tbxSearchAvailableItem.Clear();
            LoadAvailableItems();
        }

        private void btnPrintMonthly_Click(object sender, EventArgs e)
        {
            PrintMonthlyItems();
        }

        private void dgvAvailableItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyAvailableItems(e);
        }
    }
}