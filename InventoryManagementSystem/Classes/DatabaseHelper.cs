using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public static class DatabaseHelper
    {
        public static string GetConnection()
        {
            string _connection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + @"\STOCK.mdb; Jet OLEDB:Database Password = stock2132021";
            return _connection;
        }

        public static void BackupDataBase()
        {
            var dateBaseName = "STOCK.mdb";
            var sourcePath = Application.StartupPath;
            var targetPath = Application.StartupPath + @"\Backup\";

            var sourceFile = Path.Combine(sourcePath, dateBaseName);
            var destinationFile = Path.Combine(targetPath, dateBaseName);

            File.Copy(sourceFile, destinationFile, true);
        }
    }
}