namespace Loader
{
    partial class RE5Trainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RE5Worker = new System.ComponentModel.BackgroundWorker();
            this.money = new System.Windows.Forms.Button();
            this.GMChris = new System.Windows.Forms.CheckBox();
            this.ChrisAmmo = new System.Windows.Forms.CheckBox();
            this.tauschpunkte = new System.Windows.Forms.Button();
            this.ValueBox = new MetroFramework.Controls.MetroTextBox();
            this.mun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.GMSheva = new System.Windows.Forms.CheckBox();
            this.capacity = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.GMBoth = new System.Windows.Forms.CheckBox();
            this.AmmoSheva = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RE5Worker
            // 
            this.RE5Worker.WorkerReportsProgress = true;
            this.RE5Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BOWorker_DoWork);
            this.RE5Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BOWorker_ProgressChanged);
            this.RE5Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BOWorker_RunWorkerCompleted);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(141, 194);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(68, 23);
            this.money.TabIndex = 2;
            this.money.Text = "Set Money";
            this.money.UseVisualStyleBackColor = true;
            this.money.Click += new System.EventHandler(this.button1_Click);
            // 
            // GMChris
            // 
            this.GMChris.AutoSize = true;
            this.GMChris.Location = new System.Drawing.Point(12, 48);
            this.GMChris.Name = "GMChris";
            this.GMChris.Size = new System.Drawing.Size(105, 17);
            this.GMChris.TabIndex = 3;
            this.GMChris.Text = "God Mode(Chris)";
            this.GMChris.UseVisualStyleBackColor = true;
            // 
            // ChrisAmmo
            // 
            this.ChrisAmmo.AutoSize = true;
            this.ChrisAmmo.Enabled = false;
            this.ChrisAmmo.Location = new System.Drawing.Point(12, 104);
            this.ChrisAmmo.Name = "ChrisAmmo";
            this.ChrisAmmo.Size = new System.Drawing.Size(180, 17);
            this.ChrisAmmo.TabIndex = 4;
            this.ChrisAmmo.Text = "Inf Ammo(Chris) Current Dsiabled";
            this.ChrisAmmo.UseVisualStyleBackColor = true;
            // 
            // tauschpunkte
            // 
            this.tauschpunkte.Location = new System.Drawing.Point(208, 194);
            this.tauschpunkte.Name = "tauschpunkte";
            this.tauschpunkte.Size = new System.Drawing.Size(111, 23);
            this.tauschpunkte.TabIndex = 5;
            this.tauschpunkte.Text = "Set ExchangePoints";
            this.tauschpunkte.UseVisualStyleBackColor = true;
            this.tauschpunkte.Click += new System.EventHandler(this.button3_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.ForeColor = System.Drawing.Color.Magenta;
            this.ValueBox.Location = new System.Drawing.Point(5, 194);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(130, 23);
            this.ValueBox.TabIndex = 4;
            this.ValueBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mun
            // 
            this.mun.Location = new System.Drawing.Point(12, 141);
            this.mun.Name = "mun";
            this.mun.Size = new System.Drawing.Size(100, 23);
            this.mun.TabIndex = 3;
            this.mun.Text = "Set Ammo To 999";
            this.mun.UseVisualStyleBackColor = true;
            this.mun.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 28;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ValueLabel.Location = new System.Drawing.Point(21, 172);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(98, 19);
            this.ValueLabel.TabIndex = 30;
            this.ValueLabel.Text = "Write A Value:";
            // 
            // GMSheva
            // 
            this.GMSheva.AutoSize = true;
            this.GMSheva.Location = new System.Drawing.Point(12, 68);
            this.GMSheva.Name = "GMSheva";
            this.GMSheva.Size = new System.Drawing.Size(113, 17);
            this.GMSheva.TabIndex = 31;
            this.GMSheva.Text = "God Mode(Sheva)";
            this.GMSheva.UseVisualStyleBackColor = true;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(230, 128);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(162, 17);
            this.capacity.TabIndex = 33;
            this.capacity.Text = "Modded Capacity/Herb Heal";
            this.capacity.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(226, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 81);
            this.label3.TabIndex = 34;
            this.label3.Text = "Modding The Inventory Space Ammo Sprays Grenades etc\r\nTo 1000 And Green G+G Heal " +
    "1000 So Maximum";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderColor = System.Drawing.Color.Cyan;
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.BorderThickness = 1;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.CustomIconSize = 15F;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Cyan;
            this.siticoneControlBox2.Location = new System.Drawing.Point(376, 12);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 36;
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.Magenta;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(276, 12);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(98, 29);
            this.siticoneRoundedButton2.TabIndex = 56;
            this.siticoneRoundedButton2.Text = "Back To Loader";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // GMBoth
            // 
            this.GMBoth.AutoSize = true;
            this.GMBoth.Location = new System.Drawing.Point(12, 86);
            this.GMBoth.Name = "GMBoth";
            this.GMBoth.Size = new System.Drawing.Size(173, 17);
            this.GMBoth.TabIndex = 57;
            this.GMBoth.Text = "God Mode(Both) (Test Feature)";
            this.GMBoth.UseVisualStyleBackColor = true;
            // 
            // AmmoSheva
            // 
            this.AmmoSheva.AutoSize = true;
            this.AmmoSheva.Enabled = false;
            this.AmmoSheva.Location = new System.Drawing.Point(12, 123);
            this.AmmoSheva.Name = "AmmoSheva";
            this.AmmoSheva.Size = new System.Drawing.Size(185, 17);
            this.AmmoSheva.TabIndex = 58;
            this.AmmoSheva.Text = "Inf Ammo(Sheva) current disabled";
            this.AmmoSheva.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(520, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(537, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 60;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(570, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 61;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // RE5Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 225);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AmmoSheva);
            this.Controls.Add(this.GMBoth);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.GMSheva);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.tauschpunkte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mun);
            this.Controls.Add(this.GMChris);
            this.Controls.Add(this.ChrisAmmo);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.money);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "RE5Trainer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RE5 Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.RE5Trainer_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker RE5Worker;
        private System.Windows.Forms.Button money;
        private System.Windows.Forms.CheckBox GMChris;
        private System.Windows.Forms.CheckBox ChrisAmmo;
        private System.Windows.Forms.Button mun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tauschpunkte;
        private MetroFramework.Controls.MetroTextBox ValueBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.CheckBox GMSheva;
        private System.Windows.Forms.CheckBox capacity;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private System.Windows.Forms.CheckBox GMBoth;
        private System.Windows.Forms.CheckBox AmmoSheva;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}