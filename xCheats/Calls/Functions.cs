﻿
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

        private const string DCUSERINFO1 = "https://streamzone.app/api/getuser.php?userid=749592637455073300";
        private const string DCUSERINFO2 = "https://streamzone.app/api/getuser.php?userid=405427472436559884";

        private string DCUSERINFO1_DATA = "";
        private string DCUSERINFO2_DATA = "";

        public static void LoadConfiguration()
        {
            IniConfig config = new IniConfig();
            config.Load("data\\Config\\config.ini");
            bool InternetOff = config.GetValue("Settings", "OfflineMode", "false").Equals("true", StringComparison.OrdinalIgnoreCase);

            GlobalConfig.Offline = InternetOff;
        }

        public void setDiscordUserdata()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DCUSERINFO1);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            DCUSERINFO1_DATA = responseText;

            request = (HttpWebRequest)WebRequest.Create(DCUSERINFO2);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            responseText = reader.ReadToEnd();
            DCUSERINFO2_DATA = responseText;
        }

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
            if(GlobalConfig.Offline == true)
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
                    Thread.Sleep(5000);
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

                    Thread.Sleep(6000);
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