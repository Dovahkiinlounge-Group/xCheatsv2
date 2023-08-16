using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using Memory;

namespace Loader
{
    public partial class RE5Trainer : Form
    {
        public Mem m = new Mem();

        public RE5Trainer()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
          
        }

        private void BOWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("re5dx9"))
                {
                    Thread.Sleep(1000);
                    return;
                }

                ProcOpen = true;
                Thread.Sleep(1000);
                RE5Worker.ReportProgress(0);
            }
        }

        private void RE5Trainer_Shown(object sender, EventArgs e)
        {
            RE5Worker.RunWorkerAsync();
        }



        private void BOWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RE5Worker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           m.WriteMemory("base+00DA21B8,1C0", "int", ValueBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            m.WriteMemory("base+00DA283C,24,21A8", "2bytes", "1542");
            m.WriteMemory("base+00DA283C,24,21A8", "2bytes", "1542");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+00E39D58,1A4,364,28,C,40,0,1E4", "int", ValueBox.Text);
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Close();
        }

        private void BOWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                label2.Text = "Thea Industries RE5: " + "Attached :)";
            }
            if (GMChris.Checked)
            {
                m.WriteMemory("base+00DA283C,24,1364", "2bytes", "999");
            }
            /*if (ChrisAmmo.Checked)
            {
                m.WriteMemory("base+00DA283C,24,21AC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,21DC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,22OC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,223C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,229C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,226C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,22CC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,22FC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,24,232C", "2bytes", "50");
            }*/
            if (GMSheva.Checked)
            {
                m.WriteMemory("base+00DA283C,28,1364", "2bytes", "999");
            }
            if (capacity.Checked)
            {
                // Fehlerfreie Kapazität
                m.WriteMemory("base+00CDB348,54", "init", "9999");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,9C", "init", "9999");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,E4", "init", "9999");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,12C", "init", "9999");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB344,1BC", "init", "1000");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,204", "init", "1000");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,294", "init", "1000");
                Thread.Sleep(100);
                m.WriteMemory("base+CDB34C,180", "init", "1000");
                Thread.Sleep(100);
                m.WriteMemory("base+00CDB348,210", "init", "1000");
            }
            if (GMBoth.Checked)
            {
                m.WriteMemory("base+00DA283C,24,1364", "2bytes", "999");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,1364", "2bytes", "999");
            }
            /*if (AmmoSheva.Checked)
            {
                m.WriteMemory("base+00DA283C,28,21AC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,21DC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,22OC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,223C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,229C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,226C", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,22CC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,22FC", "2bytes", "50");
                Thread.Sleep(100);
                m.WriteMemory("base+00DA283C,28,232C", "2bytes", "50");
                
            }*/
        }

    }
}
