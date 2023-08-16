//namespace xCheatsFunctions
//{
//    public class IniConfig
//    {
//        private readonly string filePath;

//        public IniConfig(string filePath)
//        {
//            this.filePath = filePath;
//        }

//        public void Write(string section, string key, string value)
//        {
//            var lines = File.ReadAllLines(filePath);
//            var foundSection = false;

//            for (int i = 0; i < lines.Length; i++)
//            {
//                if (lines[i].Trim() == $"[{section}]")
//                {
//                    foundSection = true;
//                    continue;
//                }

//                if (foundSection && lines[i].StartsWith($"{key}="))
//                {
//                    lines[i] = $"{key}={value}";
//                    File.WriteAllLines(filePath, lines);
//                    return;
//                }
//            }
//            File.AppendAllLines(filePath, new[] { $"{key}={value}" });
//        }

//        public string Read(string section, string key)
//        {
//            var lines = File.ReadAllLines(filePath);
//            var foundSection = false;

//            for (int i = 0; i < lines.Length; i++)
//            {
//                if (lines[i].Trim() == $"[{section}]")
//                {
//                    foundSection = true;
//                    continue;
//                }

//                if (foundSection && lines[i].StartsWith($"{key}="))
//                {
//                    return lines[i].Substring(key.Length + 1);
//                }
//            }

//            return null;
//        }
//    }
//}