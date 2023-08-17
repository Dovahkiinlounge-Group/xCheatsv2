
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;
using System.Reflection;
using System.Configuration.Install;
using AutoUpdaterDotNET;
using xCheatsFunctions;
using System.Configuration;

namespace xCheats.Calls
{
    internal class API
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static  string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string appFolderPath = Path.Combine(appDataPath, "xCheats");
        static string configFilePath = Path.Combine(appFolderPath, "data\\Config\\config.ini");
        public static bool isOfflineMode = GlobalSettings.isOfflineMode;
        public static bool backgroundWork = GlobalSettings.BackgroundWork;
        public static bool isAdmin = GlobalSettings.AdminMode;
 
        public static void Sleep()
        {
            Thread.Sleep(1000);
        }

        public static void startup()
        {

            Console.WriteLine("Initialize xCheats...");
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            if (isOfflineMode == true)
            {
                Console.WriteLine($"Connection: Disabled in Settings");
                Thread.Sleep(5000);
                Console.WriteLine("Checking Version: Disabled in Settings");
                Thread.Sleep(5000);
                Console.WriteLine("Start xCheats");
                Thread.Sleep(3500);
                Application.Run(new LoaderMain());
            }
            else
            {
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Connection: Online");
                    //Thread.Sleep(5000);
                    Console.WriteLine("Check Registry...");
                    try
                    {
                        string Install = Directory.GetCurrentDirectory();
                        string Data = Directory.GetCurrentDirectory() + $"\\data\\Dlls";
                        string Services = Directory.GetCurrentDirectory() + $"\\data\\Services";
                        string Config = Directory.GetCurrentDirectory() + $"\\data\\Config";
                        using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\xCheats"))
                        {
                            // Setze den Pfad im Registrierungsschlüssel
                            key.SetValue("Path", Install);
                            key.SetValue("Dll", Data);
                            key.SetValue("Service", Services);
                            key.SetValue("Config", Config);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error
                        
                        Console.WriteLine("An error occurred: " + ex.Message);
                        ErrorLog.LogError(ex);
                    }

                    //Thread.Sleep(6000);
                    Application.Run(new LoaderMain());
                }
            }

        }

        public static void hide()
        {

            if (Properties.Settings.Default.ConsoleHideFunction == false)
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
                Console.Clear();
            }
            else
            {

            }
        }
    }

}