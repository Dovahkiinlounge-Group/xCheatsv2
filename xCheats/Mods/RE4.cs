using xCheatsFunctions.mem;
using System.ComponentModel;
using System.Windows.Forms;
using x = xCheats.Calls.API;
using System;

namespace xCheats
{
    public partial class RE4 : Form
    {
        memory m = new memory();
        bool ProcOpen = false;


        
        public RE4()
        {
            InitializeComponent();
            //x.RPC_RE4();
        }

        private void BOWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("bio4"))
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
               int mxhp = m.Read2Byte("base+85F716");
               MXHealth.Text = "Max Health: " + mxhp;
               int hp = m.Read2Byte("base+85F714");
               Health.Text = "Health: " + hp;
               HBar2.Text = "" + HBar.Value;
               int my = m.ReadInt("base+85F708");
               MoneyLabel.Text = "Money: " + my;
            }
            if (ProcOpen)
            {
                Injected.Text = "xCheats Resident Evil 4: " + "Attached";
            }

            if (HealthChanger.Checked)
            {
                //HBar.Visible = true;
                //HBar2.Visible = true;
                //HBar5.Visible = true;
                //m.WriteMemory("base+85F714", "int", HBar2.Text);
               // m.WriteMemory("base+85F716", "2byte", HBar2.Text);
            }
            else
            {
                HBar.Visible = false;
                HBar2.Visible = false;
                HBar5.Visible = false;
            }

            if (MoneyCheat.Checked)
            {
                MoneyT.Visible = true;
                MoneyValue.Visible = true;
                MaxVLabel.Visible = true;
                SetBtn.Visible = true;
            }
            else
            {
                MoneyT.Visible = false;
                MoneyValue.Visible = false;
                MaxVLabel.Visible = false;
                SetBtn.Visible = false;
            }

            if (DeathCount.Checked)
            {
                m.WriteMemory("base+806F3C,8460", "2byte", "0");
                m.WriteMemory("base+806F3C,8462", "2byte", "0");
            }
            if (InfAmmo.Checked)
            {
                m.WriteMemory("bio4.exe+0x3091E3", "bytes", "90 90 90 90");
                m.WriteMemory("bio4.exe+0x3088C9", "bytes", "90");
            }
            else
            {
                m.WriteMemory("bio4.exe+0x3091E3", "bytes", "66 89 57 08");
                m.WriteMemory("bio4.exe+0x3088C9", "bytes", "4A");
            }
        }

        private void SetBtn_Click(object sender, System.EventArgs e)
        {
            m.WriteMemory("base+85F708", "int", MoneyValue.Text);
        }

        private void BOWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BOWorker.RunWorkerAsync();
        }

        private void RE4_Show(object sender, System.EventArgs e)
        {

        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            //x.RPC();
            LoaderMain Main = new LoaderMain();
            Main.Show();
            this.Close();
            
        }

        private void RE4_Load(object sender, EventArgs e)
        {
            BOWorker.RunWorkerAsync();
        }
    }
}
