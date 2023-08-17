namespace xCheatsFunctions
{
    public class IniConfig
    {
        private readonly Dictionary<string, Dictionary<string, string>> sections;

        public IniConfig()
        {
            sections = new Dictionary<string, Dictionary<string, string>>();
        }

        public void Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("INI file not found.", filePath);
            }

            sections.Clear();

            string[] lines = File.ReadAllLines(filePath);

            string currentSection = "";

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentSection = trimmedLine.Substring(1, trimmedLine.Length - 2);
                    continue;
                }

                int separatorIndex = trimmedLine.IndexOf("=");
                if (separatorIndex > 0)
                {
                    string key = trimmedLine.Substring(0, separatorIndex).Trim();
                    string value = trimmedLine.Substring(separatorIndex + 1).Trim();

                    if (!sections.ContainsKey(currentSection))
                    {
                        sections[currentSection] = new Dictionary<string, string>();
                    }

                    sections[currentSection][key] = value;
                }
            }
        }

        public string GetValue(string section, string key, string defaultValue = "")
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    if (bool.TryParse(value, out bool boolValue))
                    {
                        return boolValue.ToString();
                    }
                    return value;
                }
            }

            return defaultValue;
        }
        public string GetStringValue(string section, string key, string defaultValue = "")
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    return value;
                }
            }

            return defaultValue;
        }

        public int GetIntValue(string section, string key, int defaultValue = 0)
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    if (int.TryParse(value, out int intValue))
                    {
                        return intValue;
                    }
                }
            }

            return defaultValue;
        }

        public void SetValue(string section, string key, string value)
        {
            if (!sections.ContainsKey(section))
            {
                sections[section] = new Dictionary<string, string>();
            }

            sections[section][key] = value;
        }

        public void Save(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var section in sections)
                {
                    writer.WriteLine($"[{section.Key}]");

                    foreach (var kvp in section.Value)
                    {
                        writer.WriteLine($"{kvp.Key}={kvp.Value}");
                    }

                    writer.WriteLine();
                }
            }
        }
        public void Check(string filepath)
        {
            if (!File.Exists(filepath))
            {
                SetValue("Settings", "OfflineMode", "false");
                SetValue("Settings", "AdminMode", "false");
                SetValue("Settings", "BackgroundWorker", "false");
                SetValue("Path", "RedDead2", "");
                SetValue("Path", "RedDead2Btn", "0"); // Changed default value to "0"
                Save(filepath);
            }
            else
            {
                Load(filepath);
                bool configChanged = false;

                // Check and set missing values
                if (GetValue("Settings", "OfflineMode") == "")
                {
                    SetValue("Settings", "OfflineMode", "false");
                    configChanged = true;
                }
                if (GetValue("Settings", "AdminMode") == "")
                {
                    SetValue("Settings", "AdminMode", "false");
                    configChanged = true;
                }
                if (GetValue("Settings", "BackgroundWorker") == "")
                {
                    SetValue("Settings", "BackgroundWorker", "false");
                    configChanged = true;
                }
                if (GetValue("Path", "RedDead2") == "")
                {
                    SetValue("Path", "RedDead2", "");
                    configChanged = true;
                }
                if (GetValue("Path", "RedDead2Btn") == "")
                {
                    SetValue("Path", "RedDead2Btn", "0");
                    configChanged = true;
                }
                if (configChanged)
                {
                    Save(filepath);
                }
            }
        }

    }
}
