using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public class AutoGenerateID
    {
        private readonly OleDbConnection _connection = new OleDbConnection();
        private OleDbCommand _command = new OleDbCommand();
        private OleDbDataReader _reader;

        private void InitializedConnection()
        {
            _connection.ConnectionString = DatabaseHelper.GetConnection();
        }

        public void IncrementID(string _selectQuery, string productCode, TextBox tbxID)
        {
            InitializedConnection();
            try
            {
                var querySearch = _selectQuery;
                _connection.Open();
                _command.Connection = _connection;
                _command = new OleDbCommand(querySearch, _connection);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    var fullProductCode = _reader[productCode].ToString();
                    var convertedProductCode = Convert.ToInt32(fullProductCode);
                    var increment = convertedProductCode + 1;
                    var addZero = "0000";
                    var returnID = addZero + increment.ToString();
                    GetIncrementedID(returnID, tbxID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate product code " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetIncrementedID(string returnID, TextBox tbxID)
        {
            tbxID.Text = returnID;
            return tbxID.Text;
        }
    }
}
