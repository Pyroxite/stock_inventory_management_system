using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public static class DirectoryHelper
    {
        public static void CreateDirectory()
        {
            DirectoryInfo _hideDirectory;
            var directoryImage = Application.StartupPath + @"\Pictures\";
            var directoryBackup = Application.StartupPath + @"\Backup\";

            if (!File.Exists(directoryImage) || !File.Exists(directoryBackup))
            {
                Directory.CreateDirectory(directoryImage);
                _hideDirectory = new DirectoryInfo(directoryImage)
                {
                    Attributes = FileAttributes.Hidden
                };

                Directory.CreateDirectory(directoryBackup);
                _hideDirectory = new DirectoryInfo(directoryBackup)
                {
                    Attributes = FileAttributes.Hidden
                };
            }
            else
                return;
        }
    }
}