using Siticone.Desktop.UI;

namespace xCheats
{
    partial class LoaderMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderMain));
            this.ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.xCheats = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.FormMod = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.OnOff = new System.Windows.Forms.Label();
            this.xCheatsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Infos = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AppVer = new System.Windows.Forms.Label();
            this.BWO = new System.ComponentModel.BackgroundWorker();
            this.Checking = new System.Windows.Forms.Label();
            this.OnImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.UpdateImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.OffImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyCheat = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.Admincheck = new System.Windows.Forms.Label();
            this.RDOLobby = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.DynInjBtnNM = new System.Windows.Forms.ToolStripMenuItem();
            this.RDR2InjST = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNM = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitNM = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OnImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffImg)).BeginInit();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Animated = true;
            this.ExitBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.IconColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(401, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(45, 20);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // xCheats
            // 
            this.xCheats.BackColor = System.Drawing.Color.Transparent;
            this.xCheats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.xCheats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xCheats.FillColor = System.Drawing.Color.Black;
            this.xCheats.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.xCheats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.xCheats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xCheats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.xCheats.IntegralHeight = false;
            this.xCheats.ItemHeight = 30;
            this.xCheats.Location = new System.Drawing.Point(114, 272);
            this.xCheats.Name = "xCheats";
            this.xCheats.Size = new System.Drawing.Size(225, 36);
            this.xCheats.TabIndex = 3;
            this.xCheats.Visible = false;
            // 
            // FormMod
            // 
            this.FormMod.AnimateWindow = true;
            this.FormMod.AnimationInterval = 900;
            this.FormMod.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_CENTER;
            this.FormMod.BorderRadius = 30;
            this.FormMod.ContainerControl = this;
            this.FormMod.DockForm = false;
            this.FormMod.DockIndicatorTransparencyValue = 0.6D;
            this.FormMod.TransparentWhileDrag = true;
            // 
            // OnOff
            // 
            this.OnOff.AutoSize = true;
            this.OnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff.ForeColor = System.Drawing.Color.White;
            this.OnOff.Location = new System.Drawing.Point(299, 10);
            this.OnOff.Name = "OnOff";
            this.OnOff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OnOff.Size = new System.Drawing.Size(23, 16);
            this.OnOff.TabIndex = 5;
            this.OnOff.Text = "....";
            this.OnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OnOff.UseMnemonic = false;
            // 
            // xCheatsBtn
            // 
            this.xCheatsBtn.BackColor = System.Drawing.Color.Black;
            this.xCheatsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xCheatsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xCheatsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xCheatsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xCheatsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xCheatsBtn.FillColor = System.Drawing.Color.Transparent;
            this.xCheatsBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCheatsBtn.ForeColor = System.Drawing.Color.White;
            this.xCheatsBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.xCheatsBtn.HoverState.ForeColor = System.Drawing.Color.Green;
            this.xCheatsBtn.Location = new System.Drawing.Point(0, 314);
            this.xCheatsBtn.Name = "xCheatsBtn";
            this.xCheatsBtn.Size = new System.Drawing.Size(458, 45);
            this.xCheatsBtn.TabIndex = 7;
            this.xCheatsBtn.Text = "Start";
            this.xCheatsBtn.Click += new System.EventHandler(this.xCheatsBtn_Click);
            // 
            // Infos
            // 
            this.Infos.BackColor = System.Drawing.Color.Violet;
            this.Infos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Infos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Infos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Infos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Infos.FillColor = System.Drawing.Color.Transparent;
            this.Infos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infos.ForeColor = System.Drawing.Color.White;
            this.Infos.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Infos.HoverState.ForeColor = System.Drawing.Color.Green;
            this.Infos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Infos.Location = new System.Drawing.Point(12, 6);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(96, 20);
            this.Infos.TabIndex = 14;
            this.Infos.Text = "More";
            this.Infos.TextFormatNoPrefix = true;
            this.Infos.Click += new System.EventHandler(this.Infos_Click);
            // 
            // AppVer
            // 
            this.AppVer.AutoSize = true;
            this.AppVer.ForeColor = System.Drawing.Color.Magenta;
            this.AppVer.Location = new System.Drawing.Point(12, 231);
            this.AppVer.Name = "AppVer";
            this.AppVer.Size = new System.Drawing.Size(0, 13);
            this.AppVer.TabIndex = 17;
            // 
            // BWO
            // 
            this.BWO.WorkerReportsProgress = true;
            this.BWO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWO_DoWork);
            // 
            // Checking
            // 
            this.Checking.AutoSize = true;
            this.Checking.ForeColor = System.Drawing.Color.Magenta;
            this.Checking.Location = new System.Drawing.Point(368, 39);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(78, 13);
            this.Checking.TabIndex = 18;
            this.Checking.Text = "David Jackson";
            this.Checking.DoubleClick += new System.EventHandler(this.Checking_DoubleClick);
            // 
            // OnImg
            // 
            this.OnImg.Image = ((System.Drawing.Image)(resources.GetObject("OnImg.Image")));
            this.OnImg.ImageRotate = 0F;
            this.OnImg.Location = new System.Drawing.Point(280, 8);
            this.OnImg.Name = "OnImg";
            this.OnImg.Size = new System.Drawing.Size(21, 21);
            this.OnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OnImg.TabIndex = 22;
            this.OnImg.TabStop = false;
            // 
            // UpdateImg
            // 
            this.UpdateImg.Image = ((System.Drawing.Image)(resources.GetObject("UpdateImg.Image")));
            this.UpdateImg.ImageRotate = 0F;
            this.UpdateImg.Location = new System.Drawing.Point(262, 8);
            this.UpdateImg.Name = "UpdateImg";
            this.UpdateImg.Size = new System.Drawing.Size(21, 21);
            this.UpdateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateImg.TabIndex = 23;
            this.UpdateImg.TabStop = false;
            // 
            // OffImg
            // 
            this.OffImg.Image = ((System.Drawing.Image)(resources.GetObject("OffImg.Image")));
            this.OffImg.ImageRotate = 0F;
            this.OffImg.Location = new System.Drawing.Point(280, 8);
            this.OffImg.Name = "OffImg";
            this.OffImg.Size = new System.Drawing.Size(21, 21);
            this.OffImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OffImg.TabIndex = 24;
            this.OffImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(148, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "xCheats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoneyCheat
            // 
            this.MoneyCheat.AutoSize = true;
            this.MoneyCheat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.CheckedState.BorderRadius = 0;
            this.MoneyCheat.CheckedState.BorderThickness = 0;
            this.MoneyCheat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoneyCheat.ForeColor = System.Drawing.Color.Cornsilk;
            this.MoneyCheat.Location = new System.Drawing.Point(12, 58);
            this.MoneyCheat.Name = "MoneyCheat";
            this.MoneyCheat.Size = new System.Drawing.Size(121, 17);
            this.MoneyCheat.TabIndex = 13;
            this.MoneyCheat.Text = "Show/Hide Console";
            this.MoneyCheat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoneyCheat.UncheckedState.BorderRadius = 0;
            this.MoneyCheat.UncheckedState.BorderThickness = 0;
            this.MoneyCheat.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoneyCheat.CheckedChanged += new System.EventHandler(this.MoneyCheat_CheckedChanged);
            // 
            // Admincheck
            // 
            this.Admincheck.AutoSize = true;
            this.Admincheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admincheck.ForeColor = System.Drawing.Color.Magenta;
            this.Admincheck.Location = new System.Drawing.Point(62, 279);
            this.Admincheck.Name = "Admincheck";
            this.Admincheck.Size = new System.Drawing.Size(339, 24);
            this.Admincheck.TabIndex = 25;
            this.Admincheck.Text = "Cheats Disabled(Need Admin Start)";
            this.Admincheck.Visible = false;
            // 
            // RDOLobby
            // 
            this.RDOLobby.BackColor = System.Drawing.Color.Violet;
            this.RDOLobby.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RDOLobby.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RDOLobby.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RDOLobby.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RDOLobby.FillColor = System.Drawing.Color.Transparent;
            this.RDOLobby.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDOLobby.ForeColor = System.Drawing.Color.White;
            this.RDOLobby.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.RDOLobby.HoverState.ForeColor = System.Drawing.Color.Green;
            this.RDOLobby.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RDOLobby.Location = new System.Drawing.Point(12, 32);
            this.RDOLobby.Name = "RDOLobby";
            this.RDOLobby.Size = new System.Drawing.Size(198, 20);
            this.RDOLobby.TabIndex = 26;
            this.RDOLobby.Text = "RDO Lobby Tool";
            this.RDOLobby.TextFormatNoPrefix = true;
            this.RDOLobby.Click += new System.EventHandler(this.RDOLobby_Click);
            // 
            // Notify
            // 
            this.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notify.BalloonTipText = "I running now in the background.";
            this.Notify.BalloonTipTitle = "xCheats Information";
            this.Notify.ContextMenuStrip = this.NotifyMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "xCheats";
            this.Notify.Visible = true;
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.BackColor = System.Drawing.Color.Black;
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DynInjBtnNM,
            this.OpenNM,
            this.ExitNM});
            this.NotifyMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.NotifyMenu.RenderStyle.BorderColor = System.Drawing.Color.Magenta;
            this.NotifyMenu.RenderStyle.ColorTable = null;
            this.NotifyMenu.RenderStyle.RoundedEdges = true;
            this.NotifyMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.NotifyMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NotifyMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.NotifyMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NotifyMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.NotifyMenu.Size = new System.Drawing.Size(157, 70);
            // 
            // DynInjBtnNM
            // 
            this.DynInjBtnNM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RDR2InjST});
            this.DynInjBtnNM.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.DynInjBtnNM.ForeColor = System.Drawing.Color.Magenta;
            this.DynInjBtnNM.Name = "DynInjBtnNM";
            this.DynInjBtnNM.Size = new System.Drawing.Size(156, 22);
            this.DynInjBtnNM.Text = "Injections";
            // 
            // RDR2InjST
            // 
            this.RDR2InjST.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RDR2InjST.ForeColor = System.Drawing.Color.Magenta;
            this.RDR2InjST.Name = "RDR2InjST";
            this.RDR2InjST.Size = new System.Drawing.Size(109, 22);
            this.RDR2InjST.Text = "RDR2 ";
            this.RDR2InjST.Click += new System.EventHandler(this.RDR2InjST_Click);
            // 
            // OpenNM
            // 
            this.OpenNM.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenNM.ForeColor = System.Drawing.Color.Magenta;
            this.OpenNM.Name = "OpenNM";
            this.OpenNM.Size = new System.Drawing.Size(156, 22);
            this.OpenNM.Text = "Open xCheats";
            this.OpenNM.Click += new System.EventHandler(this.OpenNM_Click);
            // 
            // ExitNM
            // 
            this.ExitNM.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitNM.ForeColor = System.Drawing.Color.Red;
            this.ExitNM.Name = "ExitNM";
            this.ExitNM.Size = new System.Drawing.Size(156, 22);
            this.ExitNM.Text = "Exit";
            this.ExitNM.ToolTipText = "Terminate the Application";
            this.ExitNM.Click += new System.EventHandler(this.ExitNM_Click);
            // 
            // LoaderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(458, 359);
            this.Controls.Add(this.RDOLobby);
            this.Controls.Add(this.Admincheck);
            this.Controls.Add(this.OffImg);
            this.Controls.Add(this.UpdateImg);
            this.Controls.Add(this.OnImg);
            this.Controls.Add(this.Checking);
            this.Controls.Add(this.AppVer);
            this.Controls.Add(this.Infos);
            this.Controls.Add(this.xCheats);
            this.Controls.Add(this.MoneyCheat);
            this.Controls.Add(this.xCheatsBtn);
            this.Controls.Add(this.OnOff);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoaderMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xCheats Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OnImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffImg)).EndInit();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox xCheats;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm FormMod;
        private System.Windows.Forms.Label OnOff;
        private Siticone.Desktop.UI.WinForms.SiticoneButton xCheatsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox MoneyCheat;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Infos;
        private System.Windows.Forms.Label AppVer;
        private System.ComponentModel.BackgroundWorker BWO;
        private System.Windows.Forms.Label Checking;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox OnImg;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox OffImg;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox UpdateImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Admincheck;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RDOLobby;
        private System.Windows.Forms.NotifyIcon Notify;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitNM;
        private System.Windows.Forms.ToolStripMenuItem OpenNM;
        private System.Windows.Forms.ToolStripMenuItem DynInjBtnNM;
        private System.Windows.Forms.ToolStripMenuItem RDR2InjST;
    }
}

