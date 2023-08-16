using System;
using System.Drawing;
using System.IO;
using System.Management.Automation.Remoting;
using System.Security.Principal;
using System.Windows.Forms;
using x = xCheats.Calls.API;
using static xCheatsHelper.Imps;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using xCheats.Calls;
using xCheatsFunctions;

namespace xCheats
{

    
    public static class Program
    {
        static bool isAdmin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            if (isAdmin)
            {
                Console.Title = "xCheats Console(Admin)";
            }
            else
            {
                Console.Title = "xCheats Console(Not Admin)";
            }
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;

            if (args.Length > 0 && args[0] == "-u6sq8#bhysa68@1c0&$")
            {
                x.LoadConfiguration();
                x.startup();
            }
            else
            {
                Console.WriteLine("xCheats must be launched from the launcher.");
                Console.WriteLine("Please use the launcher to start xCheats.");
                Console.Read();
            }


        }
    }
}
