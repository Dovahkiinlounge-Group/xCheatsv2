namespace xCheatsFunctions
{
    public class ErrorLog
    {
        public static void LogError(Exception ex, string customPath = null)
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

            string path = customPath ?? GetDefaultLogPath();

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
            MessageBox.Show("Send the error file to support when you need help", "Warning");
        }

        private static string GetDefaultLogPath()
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataPath, appName);
            string logsFolderPath = Path.Combine(appFolderPath, "logs");
            Directory.CreateDirectory(logsFolderPath); // Create the directory if it doesn't exist

            return Path.Combine(logsFolderPath, "Error.txt");
        }
    }

    public class ErrorLogv2
    {
        public static void LogError(Exception ex, string fileNamePrefix = "Error", string customPath = null)
        {
            string currentDate = DateTime.Now.ToString("dd.MM.yy hh-mm-ss"); // Using underscore instead of colon
            string fileName = $"{fileNamePrefix}_{currentDate}.txt";

            string message = $"Time: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}{Environment.NewLine}";
            message += "-----------------------------------------------------------" + Environment.NewLine;
            message += $"Message: {ex.Message}{Environment.NewLine}";
            message += $"StackTrace: {ex.StackTrace}{Environment.NewLine}";
            message += $"Source: {ex.Source}{Environment.NewLine}";
            message += $"TargetSite: {ex.TargetSite}{Environment.NewLine}";
            message += $"InnerException: {ex.InnerException} {Environment.NewLine}";
            message += "-----------------------------------------------------------" + Environment.NewLine;

            string path = customPath ?? GetDefaultLogPath(fileName);

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(message);
            }

            MessageBox.Show("Send the error file to support when you need help", "Warning");
        }

        private static string GetDefaultLogPath(string fileName)
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataPath, appName);
            string logsFolderPath = Path.Combine(appFolderPath, "logs");
            Directory.CreateDirectory(logsFolderPath); // Create the directory if it doesn't exist

            return Path.Combine(logsFolderPath, fileName);
        }
    }



}




