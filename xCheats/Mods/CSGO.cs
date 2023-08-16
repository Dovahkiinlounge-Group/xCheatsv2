using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xCheats.Cheats;
using xCheats.Classes;
using xCheats.Utilities;
using xCheats.Properties;

namespace xCheats
{
    public partial class CSGO : Form
    {

        int freqValue = Properties.Settings.Default.FreqNumber;

        public CSGO()
        {
            InitializeComponent();
            FreqV.Value = freqValue;
            ToolTip toolTip = new ToolTip();
            //if (Main.RunStartup())
            //{
            //    OffsetUpdater.UpdateOffsets();
            //    #region Start Threads
            //    // found the process and everything, lets start our cheats in a new thread
            //    new Thread(() =>
            //    {
            //        Thread.CurrentThread.IsBackground = true;
            //        CheckMenu();
            //    }).Start();

            //    Tools.InitializeGlobals();

            //    new Thread(() =>
            //    {
            //        Thread.CurrentThread.IsBackground = true;
            //        Bunnyhop.Run();
            //    }).Start();

            //    new Thread(() =>
            //    {
            //        Thread.CurrentThread.IsBackground = true;
            //        Visuals v = new Visuals();
            //        v.Run();
            //    }).Start();
            //    #endregion
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the application is closing due to an error
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing ||
                e.CloseReason == CloseReason.UserClosing)

            {
                // Perform your error logging here
                string errorLogPath = $"data\\Logs\\error_log.txt";

                try
                {
                    // Write the error log
                    using (StreamWriter writer = new StreamWriter(errorLogPath, append: true))
                    {
                        writer.WriteLine($"Error occurred at: {DateTime.Now}");
                        writer.WriteLine("Write your error details here");
                        writer.WriteLine("----------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during error logging
                    MessageBox.Show($"Failed to write error log: {ex.Message}", "Error Logging Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += Application_ApplicationExit;
            TopMost = true; // make this hover over the game, can remove if you want
            var CSGO = Process.GetProcessesByName("csgo");
            if (CSGO.Length != 0)
            {
                AttachBtn.Enabled = true;
                GameStarter.Enabled = false;
            }
        }

        public void CheckMenu()
        {
            // Here we make the main variables equal to what our menu checkboxes say
            while (true)
            {
                Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;
                Main.S.ESP = ESPCheck.Checked;
                Main.S.HealthBar = HealthBarCheck.Checked;
                Main.S.Radar = Radar.Checked;
                if ((Memory.GetAsyncKeyState(Keys.VK_INSERT) & 1) > 0)
                    Visible = !Visible;
                Thread.Sleep(1000); // Greatly reduces cpu usage
            }
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                Tools.InitializeGlobals();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Visuals v = new Visuals();
                    v.Run();
                }).Start();
                #endregion
            }
        }

        private void GameStarter_Click(object sender, EventArgs e)
        {
            
            // Erkenne den Steam-Installationspfad
            string steamInstallPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);

            // Erkenne den Pfad von CS:GO
            string gameAppId = "730"; // App-ID von CS:GO
            string gameInstallPath = (string)Registry.GetValue($@"HKEY_CURRENT_USER\Software\Valve\Steam\Apps\{gameAppId}", "InstallDir", null);

            // Konfiguriere die Startoptionen für CS:GO
            string startOptions = $"-novid -freq {freqValue} -tickrate 128 -high -insecure"; // Nützliche Startoptionen für CS:GO

            // Konfiguriere den externen Prozess
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = steamInstallPath + @"\Steam.exe";
            startInfo.Arguments = $"-applaunch {gameAppId} {startOptions}";
            startInfo.WorkingDirectory = gameInstallPath;

            // Starte CS:GO als externen Prozess
            Process.Start(startInfo);

            AttachBtn.Enabled = true;
        }
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            // Trigger the MainForm_FormClosing event manually
            MainForm_FormClosing(this, new FormClosingEventArgs(CloseReason.ApplicationExitCall, false));
            Application.Exit();

        }

        private void FreqV_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FreqNumber = (int)FreqV.Value;
            Properties.Settings.Default.Save();

        }

        private void ESPBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.S.ESPBox = ESPBoxList.SelectedIndex;
        }
    }
}