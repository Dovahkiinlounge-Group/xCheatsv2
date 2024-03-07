using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace xCheats.Overlay
{
    public partial class RE5___Overlay : Form
    {
        public const string WINDOW_NAME = "RESIDENT EVIL 5";
        private RE5 re5Instance;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public RE5___Overlay(RE5 re5Instance)
        {
            InitializeComponent();
            this.re5Instance = re5Instance;
            this.FormClosing += RE5___Overlay_FormClosing;
        }

        private void RE5___Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        private void RE5___Overlay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                string moneyVV = (string)Invoke(new Func<string>(() => re5Instance.GetMoneyText()));
                money.Text = moneyVV;
                GetWindowRect(handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

                this.Left = rect.left;
                this.Top = rect.top;
                Thread.Sleep(50);
            }
        }
    }
}
