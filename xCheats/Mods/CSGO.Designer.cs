namespace xCheats
{
    partial class CSGO
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
            this.WndName = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.AttachBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.HealthBarCheck = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.ESPCheck = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.GameStarter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.BunnyhopCheck = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.FreqV = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ESPBoxList = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.Radar = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FreqV)).BeginInit();
            this.SuspendLayout();
            // 
            // WndName
            // 
            this.WndName.ForeColor = System.Drawing.Color.Magenta;
            this.WndName.Location = new System.Drawing.Point(-10, -7);
            this.WndName.Name = "WndName";
            this.WndName.Size = new System.Drawing.Size(172, 27);
            this.WndName.TabIndex = 8;
            this.WndName.Text = "CSGO Cheat(INSECURE Only)";
            this.WndName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.Animated = true;
            this.siticoneControlBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Lime;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(294, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 20);
            this.siticoneControlBox2.TabIndex = 10;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Animated = true;
            this.ExitBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.IconColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(339, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(45, 20);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Click += new System.EventHandler(this.Application_ApplicationExit);
            // 
            // AttachBtn
            // 
            this.AttachBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttachBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttachBtn.Enabled = false;
            this.AttachBtn.FillColor = System.Drawing.Color.Black;
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttachBtn.ForeColor = System.Drawing.Color.White;
            this.AttachBtn.HoverState.ForeColor = System.Drawing.Color.Green;
            this.AttachBtn.Location = new System.Drawing.Point(294, 48);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(90, 20);
            this.AttachBtn.TabIndex = 53;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // HealthBarCheck
            // 
            this.HealthBarCheck.AutoSize = true;
            this.HealthBarCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthBarCheck.CheckedState.BorderRadius = 0;
            this.HealthBarCheck.CheckedState.BorderThickness = 0;
            this.HealthBarCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HealthBarCheck.ForeColor = System.Drawing.Color.Magenta;
            this.HealthBarCheck.Location = new System.Drawing.Point(12, 123);
            this.HealthBarCheck.Name = "HealthBarCheck";
            this.HealthBarCheck.Size = new System.Drawing.Size(73, 17);
            this.HealthBarCheck.TabIndex = 54;
            this.HealthBarCheck.Text = "HealthBar";
            this.HealthBarCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HealthBarCheck.UncheckedState.BorderRadius = 0;
            this.HealthBarCheck.UncheckedState.BorderThickness = 0;
            this.HealthBarCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ESPCheck
            // 
            this.ESPCheck.AutoSize = true;
            this.ESPCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ESPCheck.CheckedState.BorderRadius = 0;
            this.ESPCheck.CheckedState.BorderThickness = 0;
            this.ESPCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ESPCheck.ForeColor = System.Drawing.Color.Magenta;
            this.ESPCheck.Location = new System.Drawing.Point(12, 100);
            this.ESPCheck.Name = "ESPCheck";
            this.ESPCheck.Size = new System.Drawing.Size(47, 17);
            this.ESPCheck.TabIndex = 55;
            this.ESPCheck.Text = "ESP";
            this.ESPCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ESPCheck.UncheckedState.BorderRadius = 0;
            this.ESPCheck.UncheckedState.BorderThickness = 0;
            this.ESPCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // GameStarter
            // 
            this.GameStarter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GameStarter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GameStarter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GameStarter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GameStarter.FillColor = System.Drawing.Color.Black;
            this.GameStarter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GameStarter.ForeColor = System.Drawing.Color.White;
            this.GameStarter.HoverState.ForeColor = System.Drawing.Color.Green;
            this.GameStarter.Location = new System.Drawing.Point(294, 22);
            this.GameStarter.Name = "GameStarter";
            this.GameStarter.Size = new System.Drawing.Size(90, 20);
            this.GameStarter.TabIndex = 56;
            this.GameStarter.Text = "Start Game";
            this.GameStarter.Click += new System.EventHandler(this.GameStarter_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // BunnyhopCheck
            // 
            this.BunnyhopCheck.AutoSize = true;
            this.BunnyhopCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BunnyhopCheck.CheckedState.BorderRadius = 0;
            this.BunnyhopCheck.CheckedState.BorderThickness = 0;
            this.BunnyhopCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BunnyhopCheck.ForeColor = System.Drawing.Color.Magenta;
            this.BunnyhopCheck.Location = new System.Drawing.Point(12, 146);
            this.BunnyhopCheck.Name = "BunnyhopCheck";
            this.BunnyhopCheck.Size = new System.Drawing.Size(113, 17);
            this.BunnyhopCheck.TabIndex = 57;
            this.BunnyhopCheck.Text = "BunnyHop(Space)";
            this.BunnyhopCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BunnyhopCheck.UncheckedState.BorderRadius = 0;
            this.BunnyhopCheck.UncheckedState.BorderThickness = 0;
            this.BunnyhopCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // FreqV
            // 
            this.FreqV.AutoRoundedCorners = true;
            this.FreqV.BackColor = System.Drawing.Color.Transparent;
            this.FreqV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FreqV.BorderRadius = 12;
            this.FreqV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FreqV.FillColor = System.Drawing.Color.Black;
            this.FreqV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FreqV.ForeColor = System.Drawing.Color.Magenta;
            this.FreqV.Location = new System.Drawing.Point(21, 41);
            this.FreqV.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.FreqV.Name = "FreqV";
            this.FreqV.Size = new System.Drawing.Size(54, 27);
            this.FreqV.TabIndex = 58;
            this.FreqV.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FreqV.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.FreqV.Value = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.FreqV.ValueChanged += new System.EventHandler(this.FreqV_ValueChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(-13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "A function to show/hide the menu is already integrated. use Insert\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ESPBoxList
            // 
            this.ESPBoxList.BackColor = System.Drawing.Color.Transparent;
            this.ESPBoxList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ESPBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ESPBoxList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ESPBoxList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ESPBoxList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ESPBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ESPBoxList.ItemHeight = 30;
            this.ESPBoxList.Items.AddRange(new object[] {
            "Outline",
            "Filled",
            "Edge"});
            this.ESPBoxList.Location = new System.Drawing.Point(81, 41);
            this.ESPBoxList.Name = "ESPBoxList";
            this.ESPBoxList.Size = new System.Drawing.Size(140, 36);
            this.ESPBoxList.TabIndex = 59;
            this.ESPBoxList.SelectedIndexChanged += new System.EventHandler(this.ESPBoxList_SelectedIndexChanged);
            // 
            // Radar
            // 
            this.Radar.AutoSize = true;
            this.Radar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Radar.CheckedState.BorderRadius = 0;
            this.Radar.CheckedState.BorderThickness = 0;
            this.Radar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Radar.ForeColor = System.Drawing.Color.Magenta;
            this.Radar.Location = new System.Drawing.Point(131, 146);
            this.Radar.Name = "Radar";
            this.Radar.Size = new System.Drawing.Size(55, 17);
            this.Radar.TabIndex = 60;
            this.Radar.Text = "Radar";
            this.Radar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Radar.UncheckedState.BorderRadius = 0;
            this.Radar.UncheckedState.BorderThickness = 0;
            this.Radar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CSGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.Radar);
            this.Controls.Add(this.ESPBoxList);
            this.Controls.Add(this.FreqV);
            this.Controls.Add(this.BunnyhopCheck);
            this.Controls.Add(this.GameStarter);
            this.Controls.Add(this.ESPCheck);
            this.Controls.Add(this.HealthBarCheck);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.WndName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CSGO";
            this.Text = "xCheats CSGO(INSECURE)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreqV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WndName;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AttachBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox HealthBarCheck;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ESPCheck;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GameStarter;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown FreqV;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox BunnyhopCheck;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ESPBoxList;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox Radar;
    }
}

