using xCheatsHelper;
using System.ComponentModel;
using System.Windows.Forms;
using x = xCheats.Calls.API;

using System;

namespace xCheats
{
    public partial class HFTR : Form
    {
        public Mem m = new Mem();
        bool ProcOpen = false;
        private KeyboardListener _listener;


        public HFTR()
        {
            InitializeComponent();
        }

        private void BOWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("Homefront2_Release"))
                {
                    return;
                }
                ProcOpen = true;
                x.Sleep();
                BOWorker.ReportProgress(0);
            }
        }

        private void BOWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                float FOV = m.ReadFloat("base+302EA68");
                FOVNum.Text = "" + FOV;
            }
            if (ProcOpen)
            {
                Injected.Text = "xCheats HomeFront The Revolution: " + "Attached";

            }
            if (MoneyCheat.Checked)
            {
                m.WriteMemory("base+0x95A03A", "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+0x95A03A", "bytes", "42 89 44 A7 50");
            }
            if (CraftItems.Checked)
            {
                m.WriteMemory("base+0x7B1AD8", "bytes", "90 90 90 90");            
            }
            else
            {
                m.WriteMemory("base+0x7B1AD8", "bytes", "44 29 04 B7");
            }
            if (InfAmmo.Checked)
            {
                m.WriteMemory("base+0x838A4E", "bytes", "90 90 90 90");
                m.WriteMemory("base+0x19F6D99", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+0x838A4E", "bytes", "44 89 58 08");
                m.WriteMemory("base+0x19F6D99", "bytes", "89 18");
            }
             if (ActivateMoneyS.Checked)
             {
                MoneyVText.Text = "" + MoneyVSlider.Value;
                m.WriteMemory("base+026339B8,54", "2bytes", MoneyVText.Text);
             }
             if (FOVSliderBox.Checked)
             {
                ChFov.Text = "" + FOVSlider.Value;
                
                m.WriteMemory("base+302EA68", "float", ChFov.Text);
                m.WriteMemory("base+302EA64", "float", ChFov.Text);
            }
        }
        private void BOWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BOWorker.RunWorkerAsync();
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            LoaderMain Main = new LoaderMain();
            Main.Show();
            this.Close();
        }

        private void UpdateBtN_Click(object sender, EventArgs e)
        {
            float FOV = m.ReadFloat("base+302EA68");
            FOVNum.Text = "" + FOV;
            FOVSlider.Value = (int)FOV;
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            BOWorker.RunWorkerAsync();
        }

        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            switch (e.KeyPressed.ToString())
            {
                case "V":
                    FOVSliderBox.Checked = !FOVSliderBox.Checked;
                    break;
                default:
                    break;
            }
        }

        private void HFTR_Load(object sender, EventArgs e)
        {
            _listener = new KeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            if (Properties.Settings.Default.KeyboardListenerState == true)
            {
                _listener.HookKeyboard();

            }
            else
            {
                _listener.UnHookKeyboard();
            }
        }
    }
}
