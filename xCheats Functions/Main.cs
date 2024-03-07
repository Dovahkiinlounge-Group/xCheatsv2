
namespace xCheatsFunctions
{
    public class misc
    {
        public static void Folderexistcheck()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataPath, "xCheats");
            string data = Path.Combine(appFolderPath, "\\data");
            string installer = Path.Combine(appFolderPath, "\\data\\Installers");
            string downloads = Path.Combine(appFolderPath, "\\data\\Downloads");
            string logs = Path.Combine(appFolderPath, "\\data\\logs");
            string dlls = Path.Combine(appFolderPath, "\\data\\Dlls");
            string services = Path.Combine(appFolderPath, "\\data\\Services");
            string config = Path.Combine(appFolderPath, "\\data\\Config");
            try
            {
                if (!Directory.Exists(data))
                {
                    DirectoryInfo di = Directory.CreateDirectory(data);
                }
                if (!Directory.Exists(installer))
                {
                    DirectoryInfo di = Directory.CreateDirectory(installer);
                }
                if (!Directory.Exists(downloads))
                {
                    DirectoryInfo di = Directory.CreateDirectory(downloads);
                }
                if (!Directory.Exists(logs))
                {
                    DirectoryInfo di = Directory.CreateDirectory(logs);
                }
                if (!Directory.Exists(dlls))
                {
                    DirectoryInfo di = Directory.CreateDirectory(dlls);
                }
                if (!Directory.Exists(services))
                {
                    DirectoryInfo di = Directory.CreateDirectory(services);
                }
                if (!Directory.Exists(config))
                {
                    DirectoryInfo di = Directory.CreateDirectory(config);
                }

            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message, "Warning");
                ErrorLogv2.LogError(ioex);
                return;
            }
        }
    }
}