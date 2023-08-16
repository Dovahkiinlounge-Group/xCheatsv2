using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xCheats.Calls
{
    internal class GameList
    {
        public static string DllName = Properties.Settings.Default.DllName;
        public static string RDR2 = $"--process-name RDR2.exe --inject {DllName}.dll";

        
    }
}

