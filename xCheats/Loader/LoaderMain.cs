using System;
using System.Windows.Forms;
using x = xCheats.Calls.API;
using System.Runtime.InteropServices;
using xCheats.Loader;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using System.Drawing;
using Microsoft.Win32;
using xCheats;
using System.Management;
using System.ComponentModel;
using xCheatsHelper;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using xCheats.Calls;
using System.Reflection;
using AutoUpdaterDotNET;
using xCheatsFunctions;
namespace xCheats
{
    public partial class LoaderMain : Form
    {
        private Timer timer;
        private string rdr2ProcessName = "RDR2"; // Name des Red Dead Redemption 2-Prozesses
        private string programPath = Environment.CurrentDirectory + "\\data\\Dlls\\Injector.exe";
        //public static string DllName = Properties.Settings.Default.DllName;// Pfad zu deinem Programm
        //private string programArguments = $"--process-name RDR2.exe --inject {DllName}.dll"; // Argumente für dein Programm
        private bool isRDR2Running = true;
        static Process targetProcess;
        //static string programPath;
        //static string programArguments;
        static bool isProcessRunning = false;

        bool ProcOpen = false;
        public LoaderMain()
        {
            InitializeComponent();
            x.hide();
            Console.WriteLine("Welcome to xCheats");
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 2 * 60 * 1000,
                SynchronizingObject = this
            };
            timer.Elapsed += delegate
            {
                AutoUpdater.Start("https://xcheats.dovahkiinlounge.de/update.php");
            };
            timer.Start();
            Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            Version truncatedVersion = new Version(assemblyVersion.Major, assemblyVersion.Minor, assemblyVersion.Build);
            string AV = string.Format("{0}.{1}.{2}", truncatedVersion.Major, truncatedVersion.Minor, truncatedVersion.Build.ToString("D"));
            AppVer.Text = "Version: " + AV;
        }

        private void xCheatsBtn_Click(object sender, EventArgs e)
        {

            if (xCheats.Text == "4 HD Edition")
            {
                RE4 RE4 = new RE4();
                RE4.Show();
                Notify.Dispose();
                this.Hide();
            }
            else if (xCheats.Text == "5 Gold Edition")
            {

                MessageBox.Show("ERROR", "UPDATING...");
                //RE5 RE5 = new RE5();
                //RE5.Show();
                //Notify.Dispose();
                //this.Hide();
            }
            else if (xCheats.Text == "Vice City")
            {
                GTAVC VC = new GTAVC();
                VC.Show();
                Notify.Dispose();
                this.Hide();
            }
            else if (xCheats.Text == "HomeFront TR")
            {
                HFTR hf = new HFTR();
                hf.Show();
                Notify.Dispose();
                this.Hide();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (API.backgroundWork)
            {
                this.Close();
            }
            else
            {
                Environment.Exit(0);
            }

        }
        private void Main_Shown(object sender, EventArgs e)
        {

            xCheats.Items.Add("----Capcom----");
            xCheats.Items.Add("5 Gold Edition");
            xCheats.Items.Add("4 HD Edition");
            xCheats.Items.Add("----Rockstar Games----");
            xCheats.Items.Add("Vice City");
            xCheats.Items.Add("----Deep Silver----");
            xCheats.Items.Add("HomeFront TR");
            RDR2InjST.Text = $"Inject {GameList.DllName}";

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!BWO.IsBusy)
            {
                BWO.RunWorkerAsync();
            }
            if (API.isAdmin)
            {
                xCheats.Visible = true;
            }
            else
            {
                xCheats.Visible = false;
                Admincheck.Visible = true;
                xCheatsBtn.HoverState.ForeColor = Color.Red;
            }
            OnImg.Enabled = false;
            OnImg.Visible = false;
            OffImg.Visible = false;
            OffImg.Enabled = false;
            UpdateImg.Enabled = false;
            UpdateImg.Visible = false;
            if (Properties.Settings.Default.BGInj == true)
            {
                InitializeTimer();
            }

        }


        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        private void MoneyCheat_CheckedChanged(object sender, EventArgs e)
        {
            if (MoneyCheat.Checked)
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_SHOW);
            }
            else
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
            }
        }

        private void Infos_Click(object sender, EventArgs e)
        {
            xCheats.Loader.Infos ifs = new xCheats.Loader.Infos();
            ifs.Show();
        }


        private void BWO_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            if (API.isOfflineMode == true)
            {
                OffImg.Visible = true;
                Thread.Sleep(50);
                OnOff.Text = "Offline";
            }
            else
            {
                if (reply.Status == IPStatus.Success)
                {
                    OnImg.Visible = true;
                    Thread.Sleep(50);
                    OnOff.Text = "Online";
                }
                else
                {
                    OffImg.Visible = true;
                    Thread.Sleep(50);
                    OnOff.Text = "Offline";
                }
            }
            if (File.Exists(Environment.CurrentDirectory + "\\xCheats Helper.dll"))
            {
                xCheats.Visible = true;
            }
            else
            {
                xCheats.Visible = false;
            }
        }

        private void Checking_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/C2HpFiYr3lo");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }

        private void RDOLobby_Click(object sender, EventArgs e)
        {
            RDRO RDL = new RDRO();
            RDL.Show();
            this.Hide();
        }

        private void ExitNM_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenNM_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 60000; // 5 Minuten in Millisekunden
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckRDR2Process();
        }

        private void CheckRDR2Process()
        {
            // Überprüfe, ob der RDR2-Prozess läuft
            bool isRunning = false;
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Equals(rdr2ProcessName, StringComparison.OrdinalIgnoreCase))
                {
                    isRunning = true;
                    break;
                }
            }

            if (isRunning)
            {
                // Wenn RDR2 läuft und der einmalige Start noch nicht erfolgt ist
                if (isRDR2Running)
                {
                    Thread.Sleep(10000);
                    Process.Start(programPath, GameList.RDR2);
                    isRDR2Running = false;
                }
            }
            else
            {
                isRDR2Running = true;
            }
        }

        private void RDR2InjST_Click(object sender, EventArgs e)
        {
            Process.Start(programPath, GameList.RDR2);
        }
    }
}