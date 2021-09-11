using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmEmployees : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmEmployees()
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            txtEmpNo.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpNo.Text) || string.IsNullOrWhiteSpace(txtEmpName.Text) || string.IsNullOrWhiteSpace(cboEmpStatus.Text) || string.IsNullOrWhiteSpace(cboEmpDept.Text) || string.IsNullOrWhiteSpace(cboEmpProcode.Text))
            {
                MessageBox.Show("Some fields are missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = "Insert into tbl_Employee Values(@EmployeeNo,@EmployeeName,@EmployeeStatus,@EmployeeDept,@ProCode)";
                    _command.Parameters.AddWithValue("@EmployeeNo", txtEmpNo.Text);
                    _command.Parameters.AddWithValue("@Employeename", txtEmpName.Text);
                    _command.Parameters.AddWithValue("@EmployeeStatus", cboEmpStatus.Text);
                    _command.Parameters.AddWithValue("@EmployeeDept", cboEmpDept.Text);
                    _command.Parameters.AddWithValue("@ProCode", cboEmpProcode.Text);
                    _command.ExecuteNonQuery();
                    _connection.Close();
                    DatabaseHelper.BackupDataBase();
                    ViewEmployee();
                    ClearFields();
                    MessageBox.Show("New employee ha been added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add new employee " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            ViewEmployee();
        }

        private void ViewEmployee()
        {
            try
            {
                txtEmpNo.Focus();
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "Select EmployeeNo as [No], EmployeeName as [Name], EmployeeStatus as [Status], EmployeeDept as [Department], ProCode as [Property Code] From tbl_Employee";
                OleDbDataAdapter adapter = new OleDbDataAdapter(_command);
                DataTable dtEmployeeList = new DataTable();
                adapter.Fill(dtEmployeeList);
                dgvEmployeeList.DataSource = dtEmployeeList;
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employee!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cboEmpStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cboEmpDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpNo.Text))
                MessageBox.Show("Select an employee to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = "UPDATE tbl_Employee SET EmployeeNo='" + txtEmpNo.Text + "', EmployeeName= '" + txtEmpName.Text + "', EmployeeStatus='" + cboEmpStatus.Text + "', EmployeeDept= '" + cboEmpDept.Text + "', ProCode= '" + cboEmpProcode.Text + "' WHERE EmployeeNo = '" + txtEmpNo.Text + "'";
                    _command.ExecuteNonQuery();
                    _connection.Close();
                    DatabaseHelper.BackupDataBase();
                    ViewEmployee();
                    ClearFields();
                    MessageBox.Show("This employee has bee updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _connection.Close();
                    MessageBox.Show("Failed to update this employee " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            cboEmpStatus.Text = "";
            cboEmpDept.Text = "";
            cboEmpProcode.Text = "";
            txtEmpNo.Focus();
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvEmployeeList.Rows[e.RowIndex];
                txtEmpNo.Text = Row.Cells[0].Value.ToString();
                txtEmpName.Text = Row.Cells[1].Value.ToString();
                cboEmpStatus.Text = Row.Cells[2].Value.ToString();
                cboEmpDept.Text = Row.Cells[3].Value.ToString();
                cboEmpProcode.Text = Row.Cells[4].Value.ToString();
            }
        }
    }
}
