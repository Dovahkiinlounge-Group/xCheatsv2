namespace xCheats
{
    partial class HFTR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFTR));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.BOWorker = new System.ComponentModel.BackgroundWorker();
            this.Injected = new System.Windows.Forms.Label();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.MoneyCheat = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.InfAmmo = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.CraftItems = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.FOVSlider = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.FOVText = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.FOVNum = new System.Windows.Forms.Label();
            this.ActivateMoneyS = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.UpdateBtN = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ChFov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoneyVText = new System.Windows.Forms.Label();
            this.MoneyVSlider = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.FOVSliderBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.AttachBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            this.Exit.Location = new System.Drawing.Point(523, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 20);
            this.Exit.TabIndex = 4;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MoneyCheat
            // 
            this.MoneyCheat.AutoSize = true;
            this.MoneyCheat.BackColor = System.Drawing.Color.Transparent;
            this.MoneyCheat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.CheckedState.BorderRadius = 0;
            this.MoneyCheat.CheckedState.BorderThickness = 0;
            this.MoneyCheat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.ForeColor = System.Drawing.Color.Cornsilk;
            this.MoneyCheat.Location = new System.Drawing.Point(12, 118);
            this.MoneyCheat.Name = "MoneyCheat";
            this.MoneyCheat.Size = new System.Drawing.Size(151, 17);
            this.MoneyCheat.TabIndex = 12;
            this.MoneyCheat.Text = "Freeze Money/KVA Points";
            this.MoneyCheat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoneyCheat.UncheckedState.BorderRadius = 0;
            this.MoneyCheat.UncheckedState.BorderThickness = 0;
            this.MoneyCheat.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoneyCheat.UseVisualStyleBackColor = false;
            // 
            // InfAmmo
            // 
            this.InfAmmo.AutoSize = true;
            this.InfAmmo.BackColor = System.Drawing.Color.Transparent;
            this.InfAmmo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InfAmmo.CheckedState.BorderRadius = 0;
            this.InfAmmo.CheckedState.BorderThickness = 0;
            this.InfAmmo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InfAmmo.ForeColor = System.Drawing.Color.Cornsilk;
            this.InfAmmo.Location = new System.Drawing.Point(12, 95);
            this.InfAmmo.Name = "InfAmmo";
            this.InfAmmo.Size = new System.Drawing.Size(89, 17);
            this.InfAmmo.TabIndex = 18;
            this.InfAmmo.Text = "Infinite Ammo";
            this.InfAmmo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.InfAmmo.UncheckedState.BorderRadius = 0;
            this.InfAmmo.UncheckedState.BorderThickness = 0;
            this.InfAmmo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.InfAmmo.UseVisualStyleBackColor = false;
            // 
            // CraftItems
            // 
            this.CraftItems.AutoSize = true;
            this.CraftItems.BackColor = System.Drawing.Color.Transparent;
            this.CraftItems.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CraftItems.CheckedState.BorderRadius = 0;
            this.CraftItems.CheckedState.BorderThickness = 0;
            this.CraftItems.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CraftItems.ForeColor = System.Drawing.Color.Cornsilk;
            this.CraftItems.Location = new System.Drawing.Point(12, 141);
            this.CraftItems.Name = "CraftItems";
            this.CraftItems.Size = new System.Drawing.Size(111, 17);
            this.CraftItems.TabIndex = 19;
            this.CraftItems.Text = "Freeze Craft Items";
            this.CraftItems.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CraftItems.UncheckedState.BorderRadius = 0;
            this.CraftItems.UncheckedState.BorderThickness = 0;
            this.CraftItems.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CraftItems.UseVisualStyleBackColor = false;
            // 
            // FOVSlider
            // 
            this.FOVSlider.BackColor = System.Drawing.Color.Transparent;
            this.FOVSlider.LargeChange = 1;
            this.FOVSlider.Location = new System.Drawing.Point(47, 271);
            this.FOVSlider.Maximum = 90;
            this.FOVSlider.Name = "FOVSlider";
            this.FOVSlider.Size = new System.Drawing.Size(151, 23);
            this.FOVSlider.TabIndex = 20;
            this.FOVSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.FOVSlider.Value = 45;
            // 
            // FOVText
            // 
            this.FOVText.AutoSize = true;
            this.FOVText.BackColor = System.Drawing.Color.Transparent;
            this.FOVText.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOVText.ForeColor = System.Drawing.Color.Magenta;
            this.FOVText.Location = new System.Drawing.Point(187, 67);
            this.FOVText.Name = "FOVText";
            this.FOVText.Size = new System.Drawing.Size(118, 22);
            this.FOVText.TabIndex = 21;
            this.FOVText.Text = "Current FOV:";
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.InfoText.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.ForeColor = System.Drawing.Color.Magenta;
            this.InfoText.Location = new System.Drawing.Point(187, 32);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(116, 22);
            this.InfoText.TabIndex = 22;
            this.InfoText.Text = "Informations";
            // 
            // FOVNum
            // 
            this.FOVNum.AutoSize = true;
            this.FOVNum.BackColor = System.Drawing.Color.Black;
            this.FOVNum.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOVNum.ForeColor = System.Drawing.Color.Magenta;
            this.FOVNum.Location = new System.Drawing.Point(311, 72);
            this.FOVNum.Name = "FOVNum";
            this.FOVNum.Size = new System.Drawing.Size(0, 22);
            this.FOVNum.TabIndex = 23;
            // 
            // ActivateMoneyS
            // 
            this.ActivateMoneyS.AutoSize = true;
            this.ActivateMoneyS.BackColor = System.Drawing.Color.Transparent;
            this.ActivateMoneyS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActivateMoneyS.CheckedState.BorderRadius = 0;
            this.ActivateMoneyS.CheckedState.BorderThickness = 0;
            this.ActivateMoneyS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActivateMoneyS.ForeColor = System.Drawing.Color.Cornsilk;
            this.ActivateMoneyS.Location = new System.Drawing.Point(12, 49);
            this.ActivateMoneyS.Name = "ActivateMoneyS";
            this.ActivateMoneyS.Size = new System.Drawing.Size(123, 17);
            this.ActivateMoneyS.TabIndex = 24;
            this.ActivateMoneyS.Text = "Activate Slider Mods";
            this.ActivateMoneyS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ActivateMoneyS.UncheckedState.BorderRadius = 0;
            this.ActivateMoneyS.UncheckedState.BorderThickness = 0;
            this.ActivateMoneyS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ActivateMoneyS.UseVisualStyleBackColor = false;
            // 
            // UpdateBtN
            // 
            this.UpdateBtN.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtN.FillColor = System.Drawing.Color.Transparent;
            this.UpdateBtN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateBtN.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtN.HoverState.FillColor = System.Drawing.Color.Black;
            this.UpdateBtN.HoverState.ForeColor = System.Drawing.Color.Green;
            this.UpdateBtN.Location = new System.Drawing.Point(485, 299);
            this.UpdateBtN.Name = "UpdateBtN";
            this.UpdateBtN.Size = new System.Drawing.Size(95, 38);
            this.UpdateBtN.TabIndex = 25;
            this.UpdateBtN.Text = "Update Sliders";
            this.UpdateBtN.Click += new System.EventHandler(this.UpdateBtN_Click);
            // 
            // ChFov
            // 
            this.ChFov.AutoSize = true;
            this.ChFov.BackColor = System.Drawing.Color.Transparent;
            this.ChFov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ChFov.ForeColor = System.Drawing.Color.Magenta;
            this.ChFov.Location = new System.Drawing.Point(204, 278);
            this.ChFov.Name = "ChFov";
            this.ChFov.Size = new System.Drawing.Size(0, 16);
            this.ChFov.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "FOV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(19, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "$$$";
            // 
            // MoneyVText
            // 
            this.MoneyVText.AutoSize = true;
            this.MoneyVText.BackColor = System.Drawing.Color.Transparent;
            this.MoneyVText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.MoneyVText.ForeColor = System.Drawing.Color.Magenta;
            this.MoneyVText.Location = new System.Drawing.Point(204, 307);
            this.MoneyVText.Name = "MoneyVText";
            this.MoneyVText.Size = new System.Drawing.Size(0, 16);
            this.MoneyVText.TabIndex = 29;
            // 
            // MoneyVSlider
            // 
            this.MoneyVSlider.BackColor = System.Drawing.Color.Transparent;
            this.MoneyVSlider.LargeChange = 1;
            this.MoneyVSlider.Location = new System.Drawing.Point(47, 296);
            this.MoneyVSlider.Maximum = 999999;
            this.MoneyVSlider.Name = "MoneyVSlider";
            this.MoneyVSlider.Size = new System.Drawing.Size(151, 23);
            this.MoneyVSlider.TabIndex = 28;
            this.MoneyVSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MoneyVSlider.Value = 45;
            // 
            // FOVSliderBox
            // 
            this.FOVSliderBox.AutoSize = true;
            this.FOVSliderBox.BackColor = System.Drawing.Color.Transparent;
            this.FOVSliderBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FOVSliderBox.CheckedState.BorderRadius = 0;
            this.FOVSliderBox.CheckedState.BorderThickness = 0;
            this.FOVSliderBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FOVSliderBox.ForeColor = System.Drawing.Color.White;
            this.FOVSliderBox.Location = new System.Drawing.Point(12, 72);
            this.FOVSliderBox.Name = "FOVSliderBox";
            this.FOVSliderBox.Size = new System.Drawing.Size(118, 17);
            this.FOVSliderBox.TabIndex = 31;
            this.FOVSliderBox.Text = "Activate FOV Slider";
            this.FOVSliderBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.FOVSliderBox.UncheckedState.BorderRadius = 0;
            this.FOVSliderBox.UncheckedState.BorderThickness = 0;
            this.FOVSliderBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.FOVSliderBox.UseVisualStyleBackColor = false;
            // 
            // AttachBtn
            // 
            this.AttachBtn.BackColor = System.Drawing.Color.Transparent;
            this.AttachBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttachBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttachBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttachBtn.FillColor = System.Drawing.Color.Transparent;
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttachBtn.ForeColor = System.Drawing.Color.Black;
            this.AttachBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.AttachBtn.HoverState.ForeColor = System.Drawing.Color.Green;
            this.AttachBtn.Location = new System.Drawing.Point(485, 256);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(95, 37);
            this.AttachBtn.TabIndex = 53;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // HFTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 336);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.FOVSliderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoneyVText);
            this.Controls.Add(this.MoneyVSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChFov);
            this.Controls.Add(this.UpdateBtN);
            this.Controls.Add(this.ActivateMoneyS);
            this.Controls.Add(this.FOVNum);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.FOVText);
            this.Controls.Add(this.FOVSlider);
            this.Controls.Add(this.CraftItems);
            this.Controls.Add(this.MoneyCheat);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Injected);
            this.Controls.Add(this.InfAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "HFTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xCheats RE4";
            this.Load += new System.EventHandler(this.HFTR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.ComponentModel.BackgroundWorker BOWorker;
        private System.Windows.Forms.Label Injected;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Exit;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox MoneyCheat;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox InfAmmo;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox CraftItems;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar FOVSlider;
        private System.Windows.Forms.Label FOVNum;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label FOVText;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ActivateMoneyS;
        private Siticone.Desktop.UI.WinForms.SiticoneButton UpdateBtN;
        private System.Windows.Forms.Label ChFov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MoneyVText;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar MoneyVSlider;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox FOVSliderBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AttachBtn;
    }
}