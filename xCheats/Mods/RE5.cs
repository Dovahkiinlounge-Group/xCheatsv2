using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using xCheatsHelper;
using x = xCheats.Calls.API;

namespace xCheats
{
    public partial class RE5 : Form
    {
        private KeyboardListener _listener;
        private bool validNumber = false;
        private int temporaryNumb = 0;
        private Mem m = new Mem();
        private int processID;
        private bool processOpen = false;

        public RE5()
        {
            //x.RPC_RE5();
            InitializeComponent();
            
        }
        private void SaveMoneyButton_Click(object sender, EventArgs e)
        {
            validNumber = int.TryParse(moneyTextBox.Text, out temporaryNumb);

            if (validNumber)
            {
                m.WriteMemory("base+00DB2158,1c0", "int", moneyTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ScoreButton_Click(object sender, EventArgs e)
        {
            validNumber = int.TryParse(scoreTextBox.Text, out temporaryNumb);

            if (validNumber && temporaryNumb <= 999999)
            {
                m.WriteMemory("base+E243A8,1042C,6B4", "int", scoreTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RE5Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            findProcessID();

            if (!processOpen)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            RE5Worker.ReportProgress(0);
        }

        private void RE5Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            //int my = m.ReadInt("base+00DA23D8,1c0");
            //MoneyV.Text = "Money: " + my;
            //int Health = m.ReadInt("base+77CB40");
            //HealthV.Text = "Health: " + Health;

            if (GodMode.Checked)
            {
                m.WriteMemory("base+77CB40", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+77CB40", "bytes", "66 29 8E 64 13 00 00");
            }
            if (Ammo.Checked)
            {
                m.WriteMemory("base+84B8FB", "bytes", "90 90 90");
                //m.WriteMemory("base+3EC402", "byte", "EB");
                //m.WriteMemory("base+3EBC3E", "byte", "EB");
            }
            else
            {
                m.WriteMemory("base+84C1EF", "bytes", "89 41 08");
               // m.WriteMemory("base+3EC402", "byte", "75");
               // m.WriteMemory("base+3EBC3E", "byte", "75");
            }
            if (AmmoR.Checked)
            {
                m.WriteMemory("base+84D3DB", "bytes", "90 90 90");
            }
            else
            {
                m.WriteMemory("base+84D3DB", "bytes", "29 6E 08");
            }
            if (MoneyF.Checked)
            {
                m.WriteMemory("base+8EEACB", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+8EEACB", "bytes", "89 81 88 01 00 00");
            }
            if (EatEggs.Checked)
            {
                m.WriteMemory("base+3EB64B", "bytes", "90 90 90");
            }
            else
            {
                m.WriteMemory("base+3EB64B", "bytes", "89 71 08");
            }
            if (ComboTimer.Checked)
            {
                m.WriteMemory("base+321A31", "bytes", "90 90 90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+321A31", "bytes", "F3 0F 11 84 31 A0 06 00 00");
            }
            if (CountdownTimer.Checked)
            {
                m.WriteMemory("base+31CCBF", "bytes", "90 90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+31CCBF", "bytes", "F3 0F 11 87 DC 04 00 00");
            }
            if (OnOffSlider.Checked)
            {
                MoneySlider.Enabled = true;
                SliderV.Visible = true;
                SliderV.Text = "" + MoneySlider.Value;
                m.WriteMemory("base+00DA23D8,1c0", "int", SliderV.Text);
                saveMoneyButton.Enabled = false;
            }
            else
            {
                MoneySlider.Enabled = false;
                saveMoneyButton.Enabled = true;
                SliderV.Visible = false;
            }
        }

        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            switch (e.KeyPressed.ToString())
            {
                case "F1":
                    GodMode.Checked = !GodMode.Checked;
                    break;
                case "F2":
                    Ammo.Checked = !Ammo.Checked;
                    break;
                case "F3":
                    AmmoR.Checked = !AmmoR.Checked;
                    break;
                case "F4":
                    MoneyF.Checked = !MoneyF.Checked;
                    break;
                case "F5":
                    EatEggs.Checked = !EatEggs.Checked;
                    break;
                case "F6":
                    ComboTimer.Checked = !ComboTimer.Checked;
                    break;
                case "F7":
                    CountdownTimer.Checked = !CountdownTimer.Checked;
                    break;
                default:
                    break;
            }
        }

        //Locates PID
        private void findProcessID()
        {
            processID = m.GetProcIdFromName("re5dx9"); //Gets process ID
            processOpen = m.OpenProcess(processID);

            if (processID > 0)
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = processID.ToString();
                    procIdLabel.ForeColor = Color.Lime;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate {
                    gameProcessNameLabel.Text = "re5dx9.exe";
                    gameProcessNameLabel.ForeColor = Color.Lime;
                });
            }
            else
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = "Process ID Not Found";
                    procIdLabel.ForeColor = Color.Red;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate {
                    gameProcessNameLabel.Text = "N/A";
                    gameProcessNameLabel.ForeColor = Color.Red;
                });
            }

            if (processOpen)
            {

                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "GAME FOUND";
                    procOpenLabel.ForeColor = Color.Lime;
                });

            }
            else
            {
                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "N/A";
                    procOpenLabel.ForeColor = Color.Red;
                });
            }
        }





        private void Exit_Click(object sender, EventArgs e)
        {
            LoaderMain Main = new LoaderMain();
            Main.Show();
            this.Close();
        }

        private void RE5Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RE5Worker.RunWorkerAsync();
        }

        private void Ammo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RE5_Load(object sender, EventArgs e)
        {
            _listener = new KeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            if (Properties.Settings.Default.KeyboardListenerState == true)
            {
                _listener.HookKeyboard();
                GodMode.Text = "God Mode - F1";
                Ammo.Text = "Freeze Clip Ammo - F2";
                AmmoR.Text = "Freeze Reserve Ammo - F3";
                MoneyF.Text = "Freeze Money - F4";
                EatEggs.Text = "Inf Eggs (To Eat) - F5";
                ComboTimer.Text = "Freeze Combo Timer - F6";
                CountdownTimer.Text = "Freeze Countdown Timer - F7";
            }
            else
            {
                _listener.UnHookKeyboard();
            }

        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
           RE5Worker.RunWorkerAsync();
        }
    }
}
