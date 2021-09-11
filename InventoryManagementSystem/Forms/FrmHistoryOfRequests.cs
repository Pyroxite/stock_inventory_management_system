using DGVPrinterHelper;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmHistoryOfRequests : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private string RowsData = "";
        private string strID = "";

        public FrmHistoryOfRequests()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            LoadDepartment();
        }

        private void LoadDepartment()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT * FROM tbl_Department";
                OleDbDataReader rd = _command.ExecuteReader();
                while (rd.Read())
                {
                    cboDept.Items.Add(rd["Department"].ToString());
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load department " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reportlist()
        {
            try
            {
                dataGridView.Rows.Clear();
                if (dgvID.Rows.Count != 0)
                {
                    int intCount = 0;
                    for (int i = 0; i < this.dgvID.Rows.Count; i += 1)
                    {
                        intCount++;
                        if (intCount != this.dgvID.Rows.Count)
                        {
                            strID = dgvID.Rows[i].Cells[0].Value.ToString();
                            _connection.Open();
                            _command.Connection = _connection;
                            _command.CommandText = "SELECT * FROM tbl_Recieved INNER JOIN tbl_Employee ON tbl_Recieved.ReqNo = tbl_Employee.EmployeeNo WHERE ReqNo = '" + strID + "'";
                            OleDbDataReader rd = _command.ExecuteReader();
                            while (rd.Read())
                            {
                                DataGridViewRow Rows = new DataGridViewRow();
                                Rows.CreateCells(dataGridView);
                                Rows.Cells[0].Value = rd["Description"].ToString();
                                Rows.Cells[1].Value = rd["ProCode"].ToString();
                                Rows.Cells[2].Value = rd["TotalAmount"].ToString();
                                Rows.Cells[3].Value = rd["DateIssued"].ToString();
                                dataGridView.Rows.Add(Rows);
                            }
                            _connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to load request list " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvID.Rows.Clear();
            _connection.Open();
            _command.Connection = _connection;
            _command.CommandText = "SELECT * FROM tbl_Employee WHERE EmployeeDept = '" + this.cboDept.Text + "'";
            OleDbDataReader rd = _command.ExecuteReader();
            while (rd.Read())
            {
                DataGridViewRow Rows = new DataGridViewRow();
                Rows.CreateCells(dgvID);
                Rows.Cells[0].Value = rd["EmployeeNo"].ToString();
                dgvID.Rows.Add(Rows);
            }
            _connection.Close();
            reportlist();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = cboDept.Text; //give your report name
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = ""; //this is the footer
            printer.FooterSpacing = 11;
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintDataGridView(dataGridView);
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnPrintWeekly_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT * FROM tbl_Recieved INNER JOIN tbl_Employee ON tbl_Recieved.ReqNo = tbl_Employee.EmployeeNo WHERE DateIssued BETWEEN '" + dtpStartDate.Value + "' AND '" + dtpEndDate.Value + "'";
                OleDbDataReader rd = _command.ExecuteReader();

                while (rd.Read())
                {
                    DataGridViewRow RowKo = new DataGridViewRow();
                    RowKo.CreateCells(dataGridView);
                    RowKo.Cells[0].Value = rd["tbl_Employee.EmployeeDept"].ToString();
                    RowKo.Cells[1].Value = rd["TotalAmount"].ToString();
                    RowKo.Cells[2].Value = rd["ProCode"].ToString();
                    RowKo.Cells[3].Value = rd["DateIssued"].ToString();
                    dataGridView.Rows.Add(RowKo);

                    reqItems.HeaderText = "Department";
                    proCode.HeaderText = "Price";
                    reqPrice.HeaderText = "Property Code";
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to search by date " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}