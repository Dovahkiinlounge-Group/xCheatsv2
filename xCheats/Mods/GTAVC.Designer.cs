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
            components = new System.ComponentModel.Container();
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            Health = new Label();
            MoneyLabel = new Label();
            BDWorker = new System.ComponentModel.BackgroundWorker();
            Injected = new Label();
            Exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            HealthChanger = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            Example2 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            Hbart = new Label();
            HBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            Healtht = new Label();
            label1 = new Label();
            MBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            MBarL = new Label();
            SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.AnimateWindow = true;
            siticoneBorderlessForm1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            siticoneBorderlessForm1.BorderRadius = 20;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // Health
            // 
            Health.AutoSize = true;
            Health.BackColor = Color.Transparent;
            Health.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Health.ForeColor = Color.White;
            Health.Location = new Point(273, 14);
            Health.Margin = new Padding(4, 0, 4, 0);
            Health.Name = "Health";
            Health.Size = new Size(123, 25);
            Health.TabIndex = 0;
            Health.Text = "Health: ???";
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.BackColor = Color.Transparent;
            MoneyLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoneyLabel.ForeColor = Color.White;
            MoneyLabel.Location = new Point(273, 45);
            MoneyLabel.Margin = new Padding(4, 0, 4, 0);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(126, 25);
            MoneyLabel.TabIndex = 1;
            MoneyLabel.Text = "Money: ???";
            // 
            // BDWorker
            // 
            BDWorker.WorkerReportsProgress = true;
            BDWorker.DoWork += BOWorker_DoWork;
            BDWorker.ProgressChanged += BOWorker_ProgressChanged;
            BDWorker.RunWorkerCompleted += BOWorker_RunWorkerCompleted;
            // 
            // Injected
            // 
            Injected.AutoSize = true;
            Injected.BackColor = Color.Transparent;
            Injected.ForeColor = Color.Magenta;
            Injected.Location = new Point(5, 14);
            Injected.Margin = new Padding(4, 0, 4, 0);
            Injected.Name = "Injected";
            Injected.Size = new Size(0, 20);
            Injected.TabIndex = 3;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.Animated = true;
            Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Exit.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            Exit.FillColor = Color.Red;
            Exit.IconColor = Color.Black;
            Exit.Location = new Point(537, 14);
            Exit.Margin = new Padding(4, 5, 4, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(60, 31);
            Exit.TabIndex = 4;
            Exit.Click += Exit_Click;
            // 
            // HealthChanger
            // 
            HealthChanger.AutoSize = true;
            HealthChanger.BackColor = Color.Transparent;
            HealthChanger.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            HealthChanger.CheckedState.BorderRadius = 0;
            HealthChanger.CheckedState.BorderThickness = 0;
            HealthChanger.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            HealthChanger.Enabled = false;
            HealthChanger.ForeColor = Color.White;
            HealthChanger.Location = new Point(23, 97);
            HealthChanger.Margin = new Padding(4, 5, 4, 5);
            HealthChanger.Name = "HealthChanger";
            HealthChanger.Size = new Size(280, 24);
            HealthChanger.TabIndex = 8;
            HealthChanger.Text = "Enable Health Mod(Current Disabled)";
            HealthChanger.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            HealthChanger.UncheckedState.BorderRadius = 0;
            HealthChanger.UncheckedState.BorderThickness = 0;
            HealthChanger.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            HealthChanger.UseVisualStyleBackColor = false;
            // 
            // Example2
            // 
            Example2.AutoSize = true;
            Example2.BackColor = Color.Transparent;
            Example2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Example2.CheckedState.BorderRadius = 0;
            Example2.CheckedState.BorderThickness = 0;
            Example2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Example2.ForeColor = Color.White;
            Example2.Location = new Point(23, 132);
            Example2.Margin = new Padding(4, 5, 4, 5);
            Example2.Name = "Example2";
            Example2.Size = new Size(160, 24);
            Example2.TabIndex = 12;
            Example2.Text = "Enable Money Mod";
            Example2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Example2.UncheckedState.BorderRadius = 0;
            Example2.UncheckedState.BorderThickness = 0;
            Example2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Example2.UseVisualStyleBackColor = false;
            // 
            // Hbart
            // 
            Hbart.AutoSize = true;
            Hbart.BackColor = Color.Transparent;
            Hbart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hbart.ForeColor = Color.White;
            Hbart.Location = new Point(273, 168);
            Hbart.Margin = new Padding(4, 0, 4, 0);
            Hbart.Name = "Hbart";
            Hbart.Size = new Size(0, 25);
            Hbart.TabIndex = 19;
            // 
            // HBar
            // 
            HBar.BackColor = Color.Transparent;
            HBar.Enabled = false;
            HBar.Location = new Point(123, 203);
            HBar.Margin = new Padding(4, 5, 4, 5);
            HBar.Maximum = 200;
            HBar.Name = "HBar";
            HBar.Size = new Size(400, 35);
            HBar.TabIndex = 17;
            HBar.ThumbColor = Color.FromArgb(160, 113, 255);
            HBar.Value = 100;
            // 
            // Healtht
            // 
            Healtht.AutoSize = true;
            Healtht.BackColor = Color.Transparent;
            Healtht.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Healtht.ForeColor = Color.White;
            Healtht.Location = new Point(15, 203);
            Healtht.Margin = new Padding(4, 0, 4, 0);
            Healtht.Name = "Healtht";
            Healtht.Size = new Size(81, 25);
            Healtht.TabIndex = 18;
            Healtht.Text = "Health:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 285);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 21;
            label1.Text = "Money:";
            // 
            // MBar
            // 
            MBar.BackColor = Color.Transparent;
            MBar.Enabled = false;
            MBar.Location = new Point(123, 285);
            MBar.Margin = new Padding(4, 5, 4, 5);
            MBar.Maximum = 1000000;
            MBar.Name = "MBar";
            MBar.Size = new Size(400, 35);
            MBar.TabIndex = 20;
            MBar.ThumbColor = Color.FromArgb(160, 113, 255);
            MBar.Value = 500000;
            // 
            // MBarL
            // 
            MBarL.AutoSize = true;
            MBarL.BackColor = Color.Transparent;
            MBarL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MBarL.ForeColor = Color.White;
            MBarL.Location = new Point(273, 249);
            MBarL.Margin = new Padding(4, 0, 4, 0);
            MBarL.Name = "MBarL";
            MBarL.Size = new Size(0, 25);
            MBarL.TabIndex = 22;
            // 
            // GTAVC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Vice_City;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(613, 400);
            Controls.Add(MBarL);
            Controls.Add(label1);
            Controls.Add(MBar);
            Controls.Add(Hbart);
            Controls.Add(Healtht);
            Controls.Add(HBar);
            Controls.Add(Example2);
            Controls.Add(HealthChanger);
            Controls.Add(Exit);
            Controls.Add(Injected);
            Controls.Add(MoneyLabel);
            Controls.Add(Health);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GTAVC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xCheats RE4";
            Shown += RE4_Show;
            ResumeLayout(false);
            PerformLayout();
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