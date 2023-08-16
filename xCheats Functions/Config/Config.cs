//using System;
//using System.Windows.Forms;
//using xCheatsFunctions;
//namespace xCheatsFunctions
//{
//    public class MyConfig
//    {
//        //private readonly IniConfig iniConfig;
//        //private static readonly string configFilePath = "data\\Config\\App.ini";
//        private static readonly string configFilePath = Path.Combine("data", "Config", "App.ini");

//        private static readonly IniConfig iniConfig = new IniConfig(configFilePath);
//        public static string ConfigFilePath => configFilePath;
//        public static string GetConfigFilePath()
//        {
//            return configFilePath;
//        }

//        public static void SaveConfiguration(string sectionName, string keyName, string value)
//        {
//            if (File.Exists(configFilePath))
//            {
//                // Write the value to the INI file
//                iniConfig.Write(sectionName, keyName, value);
//            }
//            else
//            {
//                // Log an error or display a message indicating that the file does not exist
//                MessageBox.Show(configFilePath + "INI file not found: ");
//            }
//        }
//        public static string ReadConfiguration(string sectionName, string keyName)
//        {
//            // Check if the INI file exists
//            if (File.Exists(configFilePath))
//            {
//                // Read the value from the INI file
//                string value = iniConfig.Read(sectionName, keyName);
//                return value;
//            }
//            else
//            {
//                // File does not exist, return an empty string or handle the missing file scenario
//                return string.Empty;
//            }
//        }
//    }
//}