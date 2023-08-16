namespace xCheats
{
    partial class RE4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RE4));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.Health = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MXHealth = new System.Windows.Forms.Label();
            this.BOWorker = new System.ComponentModel.BackgroundWorker();
            this.Injected = new System.Windows.Forms.Label();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.HBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.HBar5 = new System.Windows.Forms.Label();
            this.HBar2 = new System.Windows.Forms.Label();
            this.HealthChanger = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.MoneyCheat = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.MoneyValue = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MoneyT = new System.Windows.Forms.Label();
            this.MaxVLabel = new System.Windows.Forms.Label();
            this.DeathCount = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.InfAmmo = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.SetBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.AnimateWindow = true;
            this.siticoneBorderlessForm1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.siticoneBorderlessForm1.BorderRadius = 20;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(422, 9);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(102, 20);
            this.Health.TabIndex = 0;
            this.Health.Text = "Health: ???";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.White;
            this.MoneyLabel.Location = new System.Drawing.Point(267, 9);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(101, 20);
            this.MoneyLabel.TabIndex = 1;
            this.MoneyLabel.Text = "Money: ???";
            // 
            // MXHealth
            // 
            this.MXHealth.AutoSize = true;
            this.MXHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MXHealth.ForeColor = System.Drawing.Color.White;
            this.MXHealth.Location = new System.Drawing.Point(91, 9);
            this.MXHealth.Name = "MXHealth";
            this.MXHealth.Size = new System.Drawing.Size(139, 20);
            this.MXHealth.TabIndex = 2;
            this.MXHealth.Text = "Max Health: ???";
            // 
            // BOWorker
            // 
            this.BOWorker.WorkerReportsProgress = true;
            this.BOWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BOWorker_DoWork);
            this.BOWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BOWorker_ProgressChanged);
            this.BOWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BOWorker_RunWorkerCompleted);
            // 
            // Injected
            // 
            this.Injected.AutoSize = true;
            this.Injected.ForeColor = System.Drawing.Color.White;
            this.Injected.Location = new System.Drawing.Point(12, 9);
            this.Injected.Name = "Injected";
            this.Injected.Size = new System.Drawing.Size(0, 13);
            this.Injected.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Animated = true;
            this.Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Exit.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.Exit.FillColor = System.Drawing.Color.Red;
            this.Exit.IconColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(530, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 20);
            this.Exit.TabIndex = 4;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HBar
            // 
            this.HBar.Location = new System.Drawing.Point(95, 274);
            this.HBar.Maximum = 2400;
            this.HBar.Name = "HBar";
            this.HBar.Size = new System.Drawing.Size(111, 10);
            this.HBar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.HBar.TabIndex = 5;
            this.HBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.HBar.Value = 1200;
            this.HBar.Visible = false;
            // 
            // HBar5
            // 
            this.HBar5.AutoSize = true;
            this.HBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HBar5.ForeColor = System.Drawing.Color.White;
            this.HBar5.Location = new System.Drawing.Point(12, 264);
            this.HBar5.Name = "HBar5";
            this.HBar5.Size = new System.Drawing.Size(87, 25);
            this.HBar5.TabIndex = 6;
            this.HBar5.Text = "Health:";
            this.HBar5.Visible = false;
            // 
            // HBar2
            // 
            this.HBar2.AutoSize = true;
            this.HBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HBar2.ForeColor = System.Drawing.Color.White;
            this.HBar2.Location = new System.Drawing.Point(121, 246);
            this.HBar2.Name = "HBar2";
            this.HBar2.Size = new System.Drawing.Size(64, 25);
            this.HBar2.TabIndex = 7;
            this.HBar2.Text = "1200";
            this.HBar2.Visible = false;
            // 
            // HealthChanger
            // 
            this.HealthChanger.AutoSize = true;
            this.HealthChanger.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthChanger.CheckedState.BorderRadius = 0;
            this.HealthChanger.CheckedState.BorderThickness = 0;
            this.HealthChanger.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthChanger.ForeColor = System.Drawing.Color.Cornsilk;
            this.HealthChanger.Location = new System.Drawing.Point(15, 129);
            this.HealthChanger.Name = "HealthChanger";
            this.HealthChanger.Size = new System.Drawing.Size(226, 17);
            this.HealthChanger.TabIndex = 8;
            this.HealthChanger.Text = "Activate Health Changer(Current Disabled)";
            this.HealthChanger.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HealthChanger.UncheckedState.BorderRadius = 0;
            this.HealthChanger.UncheckedState.BorderThickness = 0;
            this.HealthChanger.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // MoneyCheat
            // 
            this.MoneyCheat.AutoSize = true;
            this.MoneyCheat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.CheckedState.BorderRadius = 0;
            this.MoneyCheat.CheckedState.BorderThickness = 0;
            this.MoneyCheat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.ForeColor = System.Drawing.Color.Cornsilk;
            this.MoneyCheat.Location = new System.Drawing.Point(15, 159);
            this.MoneyCheat.Name = "MoneyCheat";
            this.MoneyCheat.Size = new System.Drawing.Size(131, 17);
            this.MoneyCheat.TabIndex = 12;
            this.MoneyCheat.Text = "Activate Money Cheat";
            this.MoneyCheat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoneyCheat.UncheckedState.BorderRadius = 0;
            this.MoneyCheat.UncheckedState.BorderThickness = 0;
            this.MoneyCheat.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // MoneyValue
            // 
            this.MoneyValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MoneyValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoneyValue.DefaultText = "";
            this.MoneyValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MoneyValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MoneyValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MoneyValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MoneyValue.FillColor = System.Drawing.Color.Black;
            this.MoneyValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MoneyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MoneyValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyValue.Location = new System.Drawing.Point(95, 293);
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.PasswordChar = '\0';
            this.MoneyValue.PlaceholderText = "Type a Value Then activate Money Cheat";
            this.MoneyValue.SelectedText = "";
            this.MoneyValue.Size = new System.Drawing.Size(231, 21);
            this.MoneyValue.TabIndex = 13;
            this.MoneyValue.Visible = false;
            // 
            // MoneyT
            // 
            this.MoneyT.AutoSize = true;
            this.MoneyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyT.ForeColor = System.Drawing.Color.White;
            this.MoneyT.Location = new System.Drawing.Point(10, 289);
            this.MoneyT.Name = "MoneyT";
            this.MoneyT.Size = new System.Drawing.Size(79, 25);
            this.MoneyT.TabIndex = 14;
            this.MoneyT.Text = "Value:";
            this.MoneyT.Visible = false;
            // 
            // MaxVLabel
            // 
            this.MaxVLabel.AutoSize = true;
            this.MaxVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxVLabel.ForeColor = System.Drawing.Color.White;
            this.MaxVLabel.Location = new System.Drawing.Point(123, 317);
            this.MaxVLabel.Name = "MaxVLabel";
            this.MaxVLabel.Size = new System.Drawing.Size(171, 18);
            this.MaxVLabel.TabIndex = 15;
            this.MaxVLabel.Text = "Max Value 999999999";
            this.MaxVLabel.Visible = false;
            // 
            // DeathCount
            // 
            this.DeathCount.AutoSize = true;
            this.DeathCount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeathCount.CheckedState.BorderRadius = 0;
            this.DeathCount.CheckedState.BorderThickness = 0;
            this.DeathCount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeathCount.ForeColor = System.Drawing.Color.Cornsilk;
            this.DeathCount.Location = new System.Drawing.Point(15, 173);
            this.DeathCount.Name = "DeathCount";
            this.DeathCount.Size = new System.Drawing.Size(146, 17);
            this.DeathCount.TabIndex = 16;
            this.DeathCount.Text = "Set Death Count to 0 (All)";
            this.DeathCount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DeathCount.UncheckedState.BorderRadius = 0;
            this.DeathCount.UncheckedState.BorderThickness = 0;
            this.DeathCount.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // InfAmmo
            // 
            this.InfAmmo.AutoSize = true;
            this.InfAmmo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InfAmmo.CheckedState.BorderRadius = 0;
            this.InfAmmo.CheckedState.BorderThickness = 0;
            this.InfAmmo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InfAmmo.ForeColor = System.Drawing.Color.Cornsilk;
            this.InfAmmo.Location = new System.Drawing.Point(15, 144);
            this.InfAmmo.Name = "InfAmmo";
            this.InfAmmo.Size = new System.Drawing.Size(89, 17);
            this.InfAmmo.TabIndex = 18;
            this.InfAmmo.Text = "Infinite Ammo";
            this.InfAmmo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.InfAmmo.UncheckedState.BorderRadius = 0;
            this.InfAmmo.UncheckedState.BorderThickness = 0;
            this.InfAmmo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // SetBtn
            // 
            this.SetBtn.AutoRoundedCorners = true;
            this.SetBtn.BorderRadius = 9;
            this.SetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetBtn.FillColor = System.Drawing.Color.Black;
            this.SetBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetBtn.ForeColor = System.Drawing.Color.White;
            this.SetBtn.Location = new System.Drawing.Point(332, 293);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(64, 21);
            this.SetBtn.TabIndex = 19;
            this.SetBtn.Text = "Set";
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // RE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(587, 341);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.DeathCount);
            this.Controls.Add(this.MaxVLabel);
            this.Controls.Add(this.MoneyT);
            this.Controls.Add(this.MoneyValue);
            this.Controls.Add(this.MoneyCheat);
            this.Controls.Add(this.HBar2);
            this.Controls.Add(this.HBar5);
            this.Controls.Add(this.HBar);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Injected);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.InfAmmo);
            this.Controls.Add(this.HealthChanger);
            this.Controls.Add(this.MXHealth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RE4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xCheats RE4";
            this.Load += new System.EventHandler(this.RE4_Load);
            this.Shown += new System.EventHandler(this.RE4_Show);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label MXHealth;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label Health;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.ComponentModel.BackgroundWorker BOWorker;
        private System.Windows.Forms.Label Injected;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Exit;
        private System.Windows.Forms.Label HBar2;
        private System.Windows.Forms.Label HBar5;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar HBar;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox HealthChanger;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox MoneyCheat;
        private System.Windows.Forms.Label MaxVLabel;
        private System.Windows.Forms.Label MoneyT;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MoneyValue;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox DeathCount;
        //private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton SetBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox InfAmmo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SetBtn;
    }
}