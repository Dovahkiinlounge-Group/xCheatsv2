namespace xCheatsFunctions
{
    public static class GlobalSettings
    {
        private static readonly IniConfig config;
        private static readonly string configFilePath;

        static GlobalSettings() // Static constructor
        {
            config = new IniConfig();
             string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
             string appFolderPath = Path.Combine(appDataPath, "DovahkiinLounge Group", "xCheats");
             configFilePath = Path.Combine(appFolderPath, "Config\\config.ini");
            LoadSettings();
        }

        public static bool AdminMode { get; set; }
        public static bool IsOfflineMode { get; set; }
        public static bool BackgroundWork { get; set; }
        public static string SelectedInstallPath { get; set; }
        public static int buttonMode { get; set; }

        private static void LoadSettings()
        {
            config.Load(configFilePath);
            bool.TryParse(config.GetValue("Settings", "AdminMode"), out bool adminModeValue);
            bool.TryParse(config.GetValue("Settings", "OfflineMode"), out bool offlineModeValue);
            bool.TryParse(config.GetValue("Settings", "BackgroundWork"), out bool backgroundWorkValue);
            string SelectedPath = config.GetStringValue("Path", "RedDead2", "");
            int btnmode = config.GetIntValue("Path", "RedDead2Btn");
            BackgroundWork = backgroundWorkValue;
            AdminMode = adminModeValue;
            IsOfflineMode = offlineModeValue;
            SelectedInstallPath = SelectedPath;
            buttonMode = btnmode;
        }
    }
}
