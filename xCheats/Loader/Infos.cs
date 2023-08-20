using System;
using AltoHttp;
using System.Diagnostics;
using System.Windows.Forms;
using x = xCheats.Calls.API;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using Color = System.Drawing.Color;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text;
using System.Drawing;
using System.Security.Policy;
using System.Threading;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using File = System.IO.File;
using xCheatsFunctions;
using xCheats.Calls;
using System.ComponentModel;

namespace xCheats.Loader
{
    public partial class Infos : Form
    {
        private const string DOWNLOAD_URL = "https://github.com/CelinaxCute/xCheatsv2/releases/download/GFWLInstaller/Release.zip";
        private const string DOWNLOAD_URL2 = "https://github.com/CelinaxCute/xCheatsv2/releases/download/4GBx64Patch/Release.zip";
        public string Message = "Offline Mode enabled";
        private const string DCUSERINFO1 = "https://api.auvos.app/getdiscorduser/749592637455073300";
        private const string DCUSERINFO2 = "https://api.auvos.app/getdiscorduser/405427472436559884";

        private string DCUSERINFO1_DATA = "";
        private string DCUSERINFO2_DATA = "";
       
        private HttpDownloader httpDwn;
        private DownloadManager downloadManager = new DownloadManager();

        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        private static extern bool SetDlgItemText(IntPtr hWnd, int nIDDlgItem, string lpString);

        delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        static HookProc dlgHookProc;

        private const long WH_CBT = 5;
        private const long HCBT_ACTIVATE = 5;

        private const int ID_BUT_OK = 1;
        private const int ID_BUT_CANCEL = 2;
        private const int ID_BUT_ABORT = 3;
        private const int ID_BUT_RETRY = 4;
        private const int ID_BUT_IGNORE = 5;
        private const int ID_BUT_YES = 6;
        private const int ID_BUT_NO = 7;

        private const string BUT_OK = "Open";
        private const string BUT_CANCEL = "Ignore";
        private const string BUT_ABORT = "Stop";
        private const string BUT_RETRY = "Continue";
        private const string BUT_IGNORE = "Ignore";
        private const string BUT_YES = "Yes";
        private const string BUT_NO = "No";

        private static int _hook = 0;

        private static int DialogHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
            {
                return CallNextHookEx(_hook, nCode, wParam, lParam);
            }

            if (nCode == HCBT_ACTIVATE)
            {
                SetDlgItemText(wParam, ID_BUT_OK, BUT_OK);
                SetDlgItemText(wParam, ID_BUT_CANCEL, BUT_CANCEL);
                SetDlgItemText(wParam, ID_BUT_ABORT, BUT_ABORT);
                SetDlgItemText(wParam, ID_BUT_RETRY, BUT_RETRY);
                SetDlgItemText(wParam, ID_BUT_IGNORE, BUT_IGNORE);
                SetDlgItemText(wParam, ID_BUT_YES, BUT_YES);
                SetDlgItemText(wParam, ID_BUT_NO, BUT_NO);
            }

            return CallNextHookEx(_hook, nCode, wParam, lParam);
        }


        
        public Infos()
        {
            InitializeComponent();
            
            TestLabel.Text = "OS Version: " + HardwareInfo.GetOSInformation() + ".";
            GPU.Text = "GPU: " + DeviceInfo.GetGPUName + ".";
            CPU.Text = "CPU: " + DeviceInfo.GetProcessorName + ".";
            CPUStat.Text = "CPU-Status: " + DeviceInfo.GetProcessorStatus + ".";
            MBoard.Text = "M-Board: " + DeviceInfo.GetProduct + ".";
            int buttonMode = Properties.Settings.Default.Autostart;
            downloadManager.ProgressChanged += DownloadManager_ProgressChanged;
            downloadManager.DownloadCompleted += DownloadManager_DownloadCompleted;
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/3KbEsy7E2A");
        }
        private void setDiscordUserdata()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DCUSERINFO1);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            byte[] bytes = Encoding.Default.GetBytes(responseText);
            responseText = Encoding.UTF8.GetString(bytes);
            DCUSERINFO1_DATA = responseText;

            request = (HttpWebRequest)WebRequest.Create(DCUSERINFO2);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            responseText = reader.ReadToEnd();
            bytes = Encoding.Default.GetBytes(responseText);
            responseText = Encoding.UTF8.GetString(bytes);
            DCUSERINFO2_DATA = responseText;
        }
            public async void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                try
                {
                string tag = DCCopyTag.Text.Substring(DCCopyTag.Text.IndexOf(":") + 1).Trim();
                Clipboard.SetText(tag);


                }
                catch (Exception ex)
                {

                }
            }

        private void Infos_Load(object sender, EventArgs e)
        {
            UpdateToggleButtonLabel();
            if (API.backgroundWork == true)
            {
                AutoStartBtn.Enabled = true;
            }
            else
            {
                AutoStartBtn.Enabled= false;
            }

            if (API.isOfflineMode == true)
            {
                ConInfo.ForeColor = Color.Red;
                ConInfo.Text = "Offline";
            }
            else
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);


                if (reply.Status == IPStatus.Success)
                {
                    ConInfo.ForeColor = Color.Green;
                    ConInfo.Text = "Online";
                }
                else
                {
                    ConInfo.ForeColor = Color.Red;
                    ConInfo.Text = "Offline";
                }
            }
        }

        private void DownloadManager_ProgressChanged(object sender, xCheatsFunctions.ProgressChangedEventArgs e)
        {
            // Update your progress bar based on the progress percentage
            DwnBar.Visible = true;
            DwnBar.Value = e.ProgressPercentage;
        }

        private void DownloadManager_DownloadCompleted(object sender, DownloadCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                // Successful download and extraction
                string downloadFolderPath = Path.GetDirectoryName(e.FilePath);
                MessageBox.Show("Download and extraction completed successfully.");
                DwnBar.Visible = false;
            }
            else
            {
                // Error occurred during download or extraction
                MessageBox.Show("An error occurred during download or extraction. Please check the error log.");
            }
        }

        private void GamesWinLiveDwn_Click(object sender, EventArgs e)
        {
            if (API.isOfflineMode == true)
            {
                MessageBox.Show(Message, "Warning");
            }
            else
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string xCheatsDownloadsPath = Path.Combine(appDataPath, "xCheats", "data", "Downloads");
                string xCheatsDownloadsPath2 = Path.Combine(appDataPath, "xCheats", "data", "Downloads", "Games For Windows LIve");
                string zipFilePath = Path.Combine(xCheatsDownloadsPath, "Release.zip");

                // Delete the ZIP file if it exists
                if (File.Exists(zipFilePath))
                {
                    File.Delete(zipFilePath);
                }

                // Delete the entire target directory if it exists
                if (Directory.Exists(xCheatsDownloadsPath2))
                {
                    Directory.Delete(xCheatsDownloadsPath2, true);
                }

                // Start the download and extraction
                downloadManager.DownloadAndExtractZip(DOWNLOAD_URL, xCheatsDownloadsPath);
            }
        }




        private void SaveSet_Click(object sender, EventArgs e)
        {
            if (AutoInjectCB.Checked)
            {
                Properties.Settings.Default.DllName = DllNameBox.Text;
                Properties.Settings.Default.Save();
                UpdateToggleButtonLabel();
                Application.Restart();
            }
            else
            {
                Properties.Settings.Default.Save();
                UpdateToggleButtonLabel();
            }
        }



        private void Defender_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderDial.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string path = FolderDial.SelectedPath;


                    using (PowerShell PowerShellInst = PowerShell.Create())
                    {
                        PowerShellInst.AddScript(@"Add-MpPreference -ExclusionPath '" + path + "'");
                        Collection<PSObject> PSOutput = PowerShellInst.Invoke();
                        Console.WriteLine("[+] " + path + " | to Windows Defender as Exclusion");
                        MessageBox.Show("Added " + "(" + path + ")" +
                            " to Windows Defender as Exclusion",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Automation_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            setDiscordUserdata();
            Thread.Sleep(50);
            try
            {
                //Cèline
                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(DCUSERINFO1_DATA);
                DCName.Text = jsonResponse.name;
                DCCopyTag.Text = "Discord Tag: " + jsonResponse.name;
                GLName.Text = "DisplayName: " + jsonResponse.global_name;
                DCAV1.ImageLocation = jsonResponse.avatar_url;
                CRA.Text = "Created At:" + jsonResponse.created_at;

                //Apy
                jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(DCUSERINFO2_DATA);
                DCName2.Text = jsonResponse.name;
                GLName2.Text = "DisplayName: " + jsonResponse.global_name;
                DCAV2.ImageLocation = jsonResponse.avatar_url;
                CRA2.Text = "Created At:" + jsonResponse.created_at;
            }
            catch (Exception ex)
            {
                ErrorLog.LogError(ex);
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Autostart == 1)
            {
                DeleteShortcut();
                Properties.Settings.Default.Autostart = 0;
            }
            else
            {
                CreateShortcut();
                Properties.Settings.Default.Autostart = 1;
            }

            Properties.Settings.Default.Save();
            UpdateToggleButtonLabel();
        }

        private void CreateShortcut()
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\xCheats.lnk";
            string targetPath = Environment.CurrentDirectory + @"\xCheats.exe"; // Geben Sie den Pfad zu Ihrem Programm an
            string description = "for starting xCheats";

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = targetPath;
            shortcut.Description = description;
            shortcut.WindowStyle = (int)WshWindowStyle.WshMinimizedNoFocus; 
            shortcut.Save();

            MessageBox.Show("Programm start now after PC Restart");
        }
        private void DeleteShortcut()
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\xCheats.lnk"; // Ändern Sie den Namen entsprechend dem Namen der Verknüpfung, die Sie gelöscht haben möchten

            if (File.Exists(shortcutPath))
            {
                File.Delete(shortcutPath);
                MessageBox.Show("Deactivate Sucess!");
            }
            else
            {
                MessageBox.Show("Not Found.");
            }
        }

        private void UpdateToggleButtonLabel()
        {
            AutoStartBtn.Text = Properties.Settings.Default.Autostart == 1 ? "Delete Autostart" : "Create Autostart";
            AutoStartBtn.Enabled = Properties.Settings.Default.BackgroundWork == true ? true : false;
            AutoInjectCB.Enabled = Properties.Settings.Default.BackgroundWork == true ? true : false;
        }
        private void GithubRepo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/CelinaxCute/xCheats");
        }

        private void ExodusBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://exodusmenu.com/");
        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneTabControl1.SelectedTab == Credits)
            {
                if (!Automation.IsBusy)
                {
                    Automation.RunWorkerAsync();
                }
            }
        }

        private void PatchDwn_Click(object sender, EventArgs e)
        {
            if (API.isOfflineMode == true)
            {
                MessageBox.Show(Message, "Warning");
            }
            else
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string xCheatsDownloadsPath = Path.Combine(appDataPath, "xCheats", "data", "Downloads");
                string xCheatsDownloadsPath2 = Path.Combine(appDataPath, "xCheats", "data", "Downloads", "4GB Patch for 32bit Games");
                string zipFilePath = Path.Combine(xCheatsDownloadsPath, "Release.zip");

                // Delete the ZIP file if it exists
                if (File.Exists(zipFilePath))
                {
                    File.Delete(zipFilePath);
                }

                // Delete the entire target directory if it exists
                if (Directory.Exists(xCheatsDownloadsPath2))
                {
                    Directory.Delete(xCheatsDownloadsPath2, true);
                }

                // Start the download and extraction
                downloadManager.DownloadAndExtractZipv2(DOWNLOAD_URL2, xCheatsDownloadsPath);
            }
        }
    }
}
