namespace xCheats
{
    partial class GTAVC
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.Health = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.BDWorker = new System.ComponentModel.BackgroundWorker();
            this.Injected = new System.Windows.Forms.Label();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.HealthChanger = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.Example2 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.Hbart = new System.Windows.Forms.Label();
            this.HBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.Healtht = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.MBarL = new System.Windows.Forms.Label();
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
            this.Health.BackColor = System.Drawing.Color.Transparent;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(205, 9);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(102, 20);
            this.Health.TabIndex = 0;
            this.Health.Text = "Health: ???";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.White;
            this.MoneyLabel.Location = new System.Drawing.Point(205, 29);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(101, 20);
            this.MoneyLabel.TabIndex = 1;
            this.MoneyLabel.Text = "Money: ???";
            // 
            // BDWorker
            // 
            this.BDWorker.WorkerReportsProgress = true;
            this.BDWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BOWorker_DoWork);
            this.BDWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BOWorker_ProgressChanged);
            this.BDWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BOWorker_RunWorkerCompleted);
            // 
            // Injected
            // 
            this.Injected.AutoSize = true;
            this.Injected.BackColor = System.Drawing.Color.Transparent;
            this.Injected.ForeColor = System.Drawing.Color.Magenta;
            this.Injected.Location = new System.Drawing.Point(4, 9);
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
            this.Exit.Location = new System.Drawing.Point(403, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 20);
            this.Exit.TabIndex = 4;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HealthChanger
            // 
            this.HealthChanger.AutoSize = true;
            this.HealthChanger.BackColor = System.Drawing.Color.Transparent;
            this.HealthChanger.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthChanger.CheckedState.BorderRadius = 0;
            this.HealthChanger.CheckedState.BorderThickness = 0;
            this.HealthChanger.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthChanger.ForeColor = System.Drawing.Color.White;
            this.HealthChanger.Location = new System.Drawing.Point(17, 63);
            this.HealthChanger.Name = "HealthChanger";
            this.HealthChanger.Size = new System.Drawing.Size(117, 17);
            this.HealthChanger.TabIndex = 8;
            this.HealthChanger.Text = "Enable Health Mod";
            this.HealthChanger.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HealthChanger.UncheckedState.BorderRadius = 0;
            this.HealthChanger.UncheckedState.BorderThickness = 0;
            this.HealthChanger.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HealthChanger.UseVisualStyleBackColor = false;
            // 
            // Example2
            // 
            this.Example2.AutoSize = true;
            this.Example2.BackColor = System.Drawing.Color.Transparent;
            this.Example2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Example2.CheckedState.BorderRadius = 0;
            this.Example2.CheckedState.BorderThickness = 0;
            this.Example2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Example2.ForeColor = System.Drawing.Color.White;
            this.Example2.Location = new System.Drawing.Point(17, 86);
            this.Example2.Name = "Example2";
            this.Example2.Size = new System.Drawing.Size(118, 17);
            this.Example2.TabIndex = 12;
            this.Example2.Text = "Enable Money Mod";
            this.Example2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Example2.UncheckedState.BorderRadius = 0;
            this.Example2.UncheckedState.BorderThickness = 0;
            this.Example2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Example2.UseVisualStyleBackColor = false;
            // 
            // Hbart
            // 
            this.Hbart.AutoSize = true;
            this.Hbart.BackColor = System.Drawing.Color.Transparent;
            this.Hbart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hbart.ForeColor = System.Drawing.Color.White;
            this.Hbart.Location = new System.Drawing.Point(205, 109);
            this.Hbart.Name = "Hbart";
            this.Hbart.Size = new System.Drawing.Size(0, 20);
            this.Hbart.TabIndex = 19;
            // 
            // HBar
            // 
            this.HBar.BackColor = System.Drawing.Color.Transparent;
            this.HBar.Enabled = false;
            this.HBar.Location = new System.Drawing.Point(92, 132);
            this.HBar.Maximum = 200;
            this.HBar.Name = "HBar";
            this.HBar.Size = new System.Drawing.Size(300, 23);
            this.HBar.TabIndex = 17;
            this.HBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.HBar.Value = 100;
            // 
            // Healtht
            // 
            this.Healtht.AutoSize = true;
            this.Healtht.BackColor = System.Drawing.Color.Transparent;
            this.Healtht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Healtht.ForeColor = System.Drawing.Color.White;
            this.Healtht.Location = new System.Drawing.Point(11, 132);
            this.Healtht.Name = "Healtht";
            this.Healtht.Size = new System.Drawing.Size(67, 20);
            this.Healtht.TabIndex = 18;
            this.Healtht.Text = "Health:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Money:";
            // 
            // MBar
            // 
            this.MBar.BackColor = System.Drawing.Color.Transparent;
            this.MBar.Enabled = false;
            this.MBar.Location = new System.Drawing.Point(92, 185);
            this.MBar.Maximum = 1000000;
            this.MBar.Name = "MBar";
            this.MBar.Size = new System.Drawing.Size(300, 23);
            this.MBar.TabIndex = 20;
            this.MBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MBar.Value = 500000;
            // 
            // MBarL
            // 
            this.MBarL.AutoSize = true;
            this.MBarL.BackColor = System.Drawing.Color.Transparent;
            this.MBarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBarL.ForeColor = System.Drawing.Color.White;
            this.MBarL.Location = new System.Drawing.Point(205, 162);
            this.MBarL.Name = "MBarL";
            this.MBarL.Size = new System.Drawing.Size(0, 20);
            this.MBarL.TabIndex = 22;
            // 
            // GTAVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::xCheats.Properties.Resources.Vice_City;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.MBarL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MBar);
            this.Controls.Add(this.Hbart);
            this.Controls.Add(this.Healtht);
            this.Controls.Add(this.HBar);
            this.Controls.Add(this.Example2);
            this.Controls.Add(this.HealthChanger);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Injected);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.Health);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GTAVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xCheats RE4";
            this.Shown += new System.EventHandler(this.RE4_Show);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label Health;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.ComponentModel.BackgroundWorker BDWorker;
        private System.Windows.Forms.Label Injected;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Exit;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox HealthChanger;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox Example2;
        private System.Windows.Forms.Label Hbart;
        private System.Windows.Forms.Label MBarL;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar MBar;
        private System.Windows.Forms.Label Healtht;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar HBar;
    }
}