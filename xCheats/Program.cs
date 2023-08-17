using System;
using System.Drawing;
using System.IO;
using System.Management.Automation.Remoting;
using System.Security.Principal;
using System.Windows.Forms;
using x = xCheats.Calls.API;
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
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Customize the console appearance
                Console.WindowHeight = 20;
                Console.WindowWidth = 100;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Title = "xCheats";

                // Temporarily set the buffer height to hide the vertical scrollbar
                int originalBufferHeight = Console.BufferHeight;
                Console.BufferHeight = Console.WindowHeight;

                //if (args.Length > 0 && args[0] == "-u6sq8#bhysa68@1c0&$")
                //{
                    x.startup();
                //}
                //else
                //{
                //    Console.WriteLine("xCheats must be launched from the launcher.");
                //    Console.WriteLine("Please use the launcher to start xCheats.");
                //    Console.Read();
                //}

                // Restore the original buffer height
                Console.BufferHeight = originalBufferHeight;
            }
            catch (Exception ex)
            {
                // Log the error using your ErrorLog class library
                ErrorLogv2.LogError(ex);
            }
        }
    }
}
