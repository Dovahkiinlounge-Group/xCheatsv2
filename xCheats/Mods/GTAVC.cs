using xCheatsHelper;
using System.ComponentModel;
using System.Windows.Forms;
using xCheats;

namespace xCheats
{
    public partial class GTAVC : Form
    {
        public Mem m = new Mem();
        bool ProcOpen = false;

        public GTAVC()
        {
            InitializeComponent();
        }

        private void BOWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("gta-vc"))
                {
                    
                    return;
                }
                ProcOpen = true;
                BDWorker.ReportProgress(0);
            }
        }

        private void BOWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                float hp = m.ReadFloat("base+38E7EC,354");
                Health.Text = "Health: " + hp;
                int my = m.ReadInt("base+549DD4");
                MoneyLabel.Text = "Money: " + my;
                Hbart.Text = "" + HBar.Value;
                MBarL.Text = "" + MBar.Value;
            }
            if (ProcOpen)
            {
                Injected.Text = "xCheats GTA Vice City: " + "Attached";
            }

            if (HealthChanger.Checked)
            {
                m.WriteMemory("base+38E7EC,354", "float", Hbart.Text);
                //Hbart.Text = "" + HBar.Value;
                HBar.Enabled = true;
            }
            else
            {
                HBar.Enabled = false;
            }

            if (Example2.Checked)
            {
                m.WriteMemory("base+549DD0", "int", MBarL.Text);
                MBar.Enabled = true;
            }
            else
            {
                MBar.Enabled = false;
            }
        }


        private void BOWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BDWorker.RunWorkerAsync();
        }

        private void RE4_Show(object sender, System.EventArgs e)
        {
            BDWorker.RunWorkerAsync();
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            LoaderMain Main = new LoaderMain();
            Main.Show();
            this.Close();
        }
    }
}
