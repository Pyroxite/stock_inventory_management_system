using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FrmAddItem : Form
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private readonly FrmItems _product;

        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmAddItem(FrmItems product)
        {
            InitializeComponent();
            _connection.ConnectionString = DatabaseHelper.GetConnection();
            _product = product;
            btnUpdate.Enabled = false;
        }

        private void Clear()
        {
            tbxProductCode.Clear();
            tbxName.Clear();
            tbxBrand.Clear();
            cbxUnits.Text = "";
            nudQuantity.Value = 0;
            tbxPerQty.Clear();
            tbxTotalAmount.Clear();
            rbnCommon.Checked = false;
            rbnSpecial.Checked = false;
            _product.tbxSearchAvailableItem.Clear();
            _product.tbxSearchOutStock.Clear();

            Image image;
            var profilePath = "background.png";
            var applicationPath = Application.StartupPath + @"\Pictures\";
            var getProfile = Path.Combine(applicationPath, profilePath);

            using (Stream stream = File.OpenRead(getProfile))
                image = Image.FromStream(stream);

            pbxItemImage.Image = image;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxProductCode.Text) || string.IsNullOrWhiteSpace(tbxName.Text) || string.IsNullOrWhiteSpace(cbxUnits.Text) || string.IsNullOrWhiteSpace(tbxTotalAmount.Text))
                MessageBox.Show("Some fields are missing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();

                try
                {
                    pbxItemImage.Image.Save(Application.StartupPath + @"\Pictures\" + tbxProductCode.Text + ".jpg");
                    pbxItemImage.Image.Dispose();

                    var imagePath = Application.StartupPath + @"\Pictures\" + tbxProductCode.Text + ".jpg";

                    var devideByTwo = Convert.ToInt32(tbxTotalAmount.Text) / Convert.ToInt32(nudQuantity.Value);
                    tbxPerQty.Text = devideByTwo.ToString();
                    var _queryAdd = "INSERT INTO tbl_Products (ProductCode, Name, Brand, Units, Quantity, AmountPerQty, Total, ImagePath, ItemType, DateAdded) VALUES (@PRODUCTCODE, @NAME, @BRAND, @UNITS, @QUANTITY, @AMOUNTPERQTY, @TOTAL, @IMAGEPATH, @ITEMTYPE, @DATEADDED)";

                    connection.ConnectionString = DatabaseHelper.GetConnection();
                    connection.Open();
                    command.Connection = connection;
                    command = new OleDbCommand(_queryAdd, connection);
                    command.Parameters.AddWithValue("@PRODUCTCODE", tbxProductCode.Text);
                    command.Parameters.AddWithValue("@NAME", tbxName.Text);
                    command.Parameters.AddWithValue("@BRAND", tbxBrand.Text);
                    command.Parameters.AddWithValue("@UNITS", cbxUnits.Text);
                    command.Parameters.AddWithValue("@QUANTITY", nudQuantity.Value);
                    command.Parameters.AddWithValue("@AMOUNTPERQTY", tbxPerQty.Text);
                    command.Parameters.AddWithValue("@TOTAL", tbxTotalAmount.Text);
                    command.Parameters.AddWithValue("@IMAGEPATH", imagePath);
                    if (rbnSpecial.Checked == true)
                        command.Parameters.AddWithValue("@ITEMTYPE", rbnSpecial.Text);
                    else if(rbnCommon.Checked == true)
                        command.Parameters.AddWithValue("@ITEMTYPE", rbnCommon.Text);
                    command.Parameters.AddWithValue("@DATEADDED", DateTime.Now.ToShortDateString());
                    command.ExecuteNonQuery();
                    connection.Close();
                    _product.LoadAvailableItems();
                    _product.LoadOutOfStock();
                    DatabaseHelper.BackupDataBase();
                    Clear();
                    MessageBox.Show("New item has been added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show("Failed to add new item " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var imagePath = Application.StartupPath + @"\Pictures\" + tbxProductCode.Text + ".jpg";
                Bitmap newImage = new Bitmap(pbxItemImage.Image);
                if (File.Exists(imagePath))
                    File.Delete(imagePath);
                newImage.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                newImage.Dispose();

                var _queryUpdate = "UPDATE tbl_Products SET ProductCode= @PRODUCTCODE, Name= @NAME, Brand= @BRAND, Units= @UNITS, Quantity= @QUANTITY, AmountPerQty= @AMOUNTPERQTY, Total= @TOTAL, ImagePath= @IMAGEPATH, ItemType= @ITEMTYPE, DateAdded= @DATEADDED WHERE ProductID LIKE'" + tbxProductID.Text + "'";

                var devideByTwo = Convert.ToInt32(tbxTotalAmount.Text) / Convert.ToInt32(nudQuantity.Value);
                tbxPerQty.Text = devideByTwo.ToString();

                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(_queryUpdate, _connection);

                _command.Parameters.AddWithValue("@PRODUCTCODE", tbxProductCode.Text);
                _command.Parameters.AddWithValue("@NAME", tbxName.Text);
                _command.Parameters.AddWithValue("@BRAND", tbxBrand.Text);
                _command.Parameters.AddWithValue("@UNITS", cbxUnits.Text);
                _command.Parameters.AddWithValue("@QUANTITY", nudQuantity.Value);
                _command.Parameters.AddWithValue("@AMOUNTPERQTY", tbxPerQty.Text);
                _command.Parameters.AddWithValue("@TOTAL", tbxTotalAmount.Text);
                _command.Parameters.AddWithValue("@IMAGEPATH", imagePath);
                if (rbnSpecial.Checked == true)
                    _command.Parameters.AddWithValue("@ITEMTYPE", rbnSpecial.Text);
                else if (rbnCommon.Checked == true)
                    _command.Parameters.AddWithValue("@ITEMTYPE", rbnCommon.Text);
                _command.Parameters.AddWithValue("@DATEADDED", DateTime.Now.ToShortDateString());

                _command.ExecuteNonQuery();
                _connection.Close();
                _product.LoadAvailableItems();
                _product.LoadOutOfStock();
                DatabaseHelper.BackupDataBase();
                MessageBox.Show("This item has been updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Dispose();
            }
            catch (Exception ex)
            {
                _connection.Close();
                MessageBox.Show("Failed to update this item " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmAddItems_Activated(object sender, EventArgs e)
        {
            tbxProductCode.Focus();
        }

        private void pnlMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openImage = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp, *.png"
            };
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pbxItemImage.Image = new Bitmap(openImage.FileName);
            }
        }

        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            tbxProductCode.Clear();
            var autoGenerate = new AutoGenerateID();
            var selectQuery = "SELECT tbl_Products.ProductCode FROM tbl_Products ORDER BY ProductID";
            var code = "ProductCode";
            autoGenerate.IncrementID(selectQuery, code, tbxProductCode);
        }
    }
}