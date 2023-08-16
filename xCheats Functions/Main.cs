using System.Windows.Forms;

namespace xCheatsFunctions
{
    public class ErrorLog
    {
        public static void LogError(Exception ex)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);
            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite);
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;

            string path = "data\\logs\\Error.txt";

            bool logFileExists = File.Exists(path);

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                if (logFileExists)
                {
                    sw.WriteLine("-----------------------------------------------------------");
                    sw.WriteLine();
                }

                sw.WriteLine(message);
                sw.Close();
            }

            MessageBox.Show("Send The error file to the support when u need help", "Warning");
            Environment.Exit(1);
        }
    }

    public class misc
    {
        public static void folderexistcheck()
        {
            string path = Environment.CurrentDirectory + "\\data";
            string path2 = Environment.CurrentDirectory + "\\data\\Installers";
            string path3 = Environment.CurrentDirectory + "\\data\\Downloads";
            string path4 = Environment.CurrentDirectory + "\\data\\logs";
            string path5 = Environment.CurrentDirectory + "\\data\\Dlls";
            string path6 = Environment.CurrentDirectory + "\\data\\Services";
            string path7 = Environment.CurrentDirectory + "\\data\\Config";
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