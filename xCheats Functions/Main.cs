using System.Windows.Forms;

namespace xCheatsFunctions
{
    public class misc
    {
        public static void folderexistcheck()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataPath, "xCheats");
            string path = Path.Combine(appFolderPath, "\\data");
            string path2 = Path.Combine(appFolderPath, "\\data\\Installers");
            string path3 = Path.Combine(appFolderPath, "\\data\\Downloads");
            string path4 = Path.Combine(appFolderPath, "\\data\\logs");
            string path5 = Path.Combine(appFolderPath, "\\data\\Dlls");
            string path6 = Path.Combine(appFolderPath, "\\data\\Services");
            string path7 = Path.Combine(appFolderPath, "\\data\\Config");
            try
            {
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                if (!Directory.Exists(path2))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path2);
                }
                if (!Directory.Exists(path3))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path3);
                }
                if (!Directory.Exists(path4))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path4);
                }
                if (!Directory.Exists(path5))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path5);
                }
                if (!Directory.Exists(path6))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path6);
                }
                if (!Directory.Exists(path7))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path7);
                }

            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message, "Warning");
                ErrorLog.LogError(ioex);
                return;
            }
        }
    }
}