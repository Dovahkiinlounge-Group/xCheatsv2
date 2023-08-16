using AutoUpdaterDotNET;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Windows.Forms;
using xCheatsFunctions;

namespace xCheats_Launcher
{
    public partial class Launcher : Form
    {
        static bool isAdmin;
        private bool isFunction1Active;
        private Timer clickTimer;
        static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string appFolderPath = Path.Combine(appDataPath, "xCheats");
        static string configFilePath = Path.Combine(appFolderPath, "data\\Config\\config.ini");
        IniConfig config = new IniConfig();
        public Launcher()
        {
            System.Threading.Thread.Sleep(500);
            config.Check(configFilePath);
            //AutoUpdater.Start("https://xcheats.dovahkiinlounge.de/update.php");
            //AutoUpdater.ShowSkipButton = false;
            //AutoUpdater.LetUserSelectRemindLater = false;
            //AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours;
            //AutoUpdater.RemindLaterAt = 1;
            InitializeComponent();
            
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            if (isAdmin)
            {
                StartBtn.Text = "Start xCheats(Admin)";
            }
            else
            {
                StartBtn.Text = "Start xCheats(Not Admin)";
            }
            OffTggl.ForeColor = Color.Red;
            clickTimer = new Timer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += ClickTimer_Tick;
            config.Load(configFilePath);
            bool isOfflineMode = GlobalSettings.isOfflineMode;
            if (isOfflineMode)
            {
                isFunction1Active = !isOfflineMode; // Reverse the state for OffTggl
                OffTggl.Checked = isOfflineMode; // Set the state for OffTggl
                UpdateOfflineLabel(isOfflineMode); // Update OffLbl text and forecolor
            }
            else
            {
                OffTggl.Checked = isFunction1Active; // Set the default state
                UpdateOfflineLabel(false); // Set the default OffLbl text and forecolor
            }
            this.ShowInTaskbar = true;
        }
        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            OffTggl.Enabled = true;
            clickTimer.Stop();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string arguments = "-u6sq8#bhysa68@1c0&$";
            string mainAppPath = Environment.CurrentDirectory + "\\xCheats.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(mainAppPath);
            startInfo.Arguments = arguments;
            bool isAdmin = GlobalSettings.AdminMode;
            if (isAdmin)
            {
                startInfo.Verb = "runas"; // This indicates that the process should be run as an administrator
            }
            try
            {
                Process.Start(startInfo);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                // Handle exceptions if the process cannot be started
                MessageBox.Show("Error starting the application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void OffTggl_Click(object sender, EventArgs e)
        {
            isFunction1Active = !isFunction1Active;
            OffTggl.Enabled = false;
            clickTimer.Start();
            OffTggl.Checked = isFunction1Active;
            UpdateOfflineLabel(OffTggl.Checked);
            config.SetValue("Settings", "OfflineMode", OffTggl.Checked.ToString().ToLower());
            config.Save(configFilePath);
        }

        private void UpdateOfflineLabel(bool isOfflineMode)
        {
            if (isOfflineMode)
            {
                OffTggl.Text = "Offline Enabled";
                OffTggl.ForeColor = Color.Red;
            }
            else
            {
                OffTggl.Text = "Online(Click Here to go Offline)";
                OffTggl.ForeColor = Color.Green;
            }
        }
    }
}
