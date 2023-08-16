namespace xCheats_Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.zeroitChromeForm1 = new Zeroit.Framework.Form.ZeroitChromeForm();
            this.OffTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.BGTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.zeroitLollipopButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppText = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.StartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.zeroitChromeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zeroitChromeForm1
            // 
            this.zeroitChromeForm1.BackColor = System.Drawing.Color.Black;
            this.zeroitChromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.zeroitChromeForm1.ColorBackground1 = System.Drawing.Color.Violet;
            this.zeroitChromeForm1.ColorBackground2 = System.Drawing.Color.LightSeaGreen;
            this.zeroitChromeForm1.Controls.Add(this.OffTggl);
            this.zeroitChromeForm1.Controls.Add(this.BGTggl);
            this.zeroitChromeForm1.Controls.Add(this.zeroitLollipopButton1);
            this.zeroitChromeForm1.Controls.Add(this.pictureBox1);
            this.zeroitChromeForm1.Controls.Add(this.AppText);
            this.zeroitChromeForm1.Controls.Add(this.StartBtn);
            this.zeroitChromeForm1.Customization = "AAAA//////8AAP//";
            this.zeroitChromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitChromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.zeroitChromeForm1.Image = null;
            this.zeroitChromeForm1.Location = new System.Drawing.Point(0, 0);
            this.zeroitChromeForm1.Movable = false;
            this.zeroitChromeForm1.Name = "zeroitChromeForm1";
            this.zeroitChromeForm1.NoRounding = false;
            this.zeroitChromeForm1.Sizable = false;
            this.zeroitChromeForm1.Size = new System.Drawing.Size(800, 450);
            this.zeroitChromeForm1.SmartBounds = true;
            this.zeroitChromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.zeroitChromeForm1.TabIndex = 0;
            this.zeroitChromeForm1.Text = "xCheats";
            this.zeroitChromeForm1.TransparencyKey = System.Drawing.Color.Empty;
            this.zeroitChromeForm1.Transparent = false;
            // 
            // OffTggl
            // 
            this.OffTggl.AllowTransparency = true;
            this.OffTggl.Checked = false;
            this.OffTggl.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.OffTggl.ForeColor = System.Drawing.Color.Magenta;
            this.OffTggl.Location = new System.Drawing.Point(22, 75);
            this.OffTggl.Name = "OffTggl";
            this.OffTggl.RectangleWidth = 1;
            this.OffTggl.Size = new System.Drawing.Size(65, 20);
            this.OffTggl.TabIndex = 7;
            this.OffTggl.Text = "Offline";
            this.OffTggl.UncheckedColor = System.Drawing.Color.White;
            this.OffTggl.Click += new System.EventHandler(this.OffTggl_Click);
            // 
            // BGTggl
            // 
            this.BGTggl.AllowTransparency = true;
            this.BGTggl.Checked = false;
            this.BGTggl.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.BGTggl.ForeColor = System.Drawing.Color.Green;
            this.BGTggl.Location = new System.Drawing.Point(22, 101);
            this.BGTggl.Name = "BGTggl";
            this.BGTggl.RectangleWidth = 1;
            this.BGTggl.Size = new System.Drawing.Size(98, 20);
            this.BGTggl.TabIndex = 6;
            this.BGTggl.Text = "Background";
            this.BGTggl.UncheckedColor = System.Drawing.Color.White;
            // 
            // zeroitLollipopButton1
            // 
            this.zeroitLollipopButton1.AllowTransparency = true;
            this.zeroitLollipopButton1.AnimationInterval = 1;
            this.zeroitLollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitLollipopButton1.BGColor = "#508ef5";
            this.zeroitLollipopButton1.Corners = 1F;
            this.zeroitLollipopButton1.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.zeroitLollipopButton1.DoubleRipple = false;
            this.zeroitLollipopButton1.EnabledBGColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.FontColor = "#ffffff";
            this.zeroitLollipopButton1.ForeColor = System.Drawing.Color.Red;
            this.zeroitLollipopButton1.Location = new System.Drawing.Point(776, 0);
            this.zeroitLollipopButton1.Name = "zeroitLollipopButton1";
            this.zeroitLollipopButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zeroitLollipopButton1.RippleEffectColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.RippleOpacity = 25;
            this.zeroitLollipopButton1.Size = new System.Drawing.Size(24, 22);
            this.zeroitLollipopButton1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitLollipopButton1.TabIndex = 3;
            this.zeroitLollipopButton1.Text = "X";
            this.zeroitLollipopButton1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.zeroitLollipopButton1.Click += new System.EventHandler(this.zeroitLollipopButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(316, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 158);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AppText
            // 
            this.AppText.AllowTransparency = false;
            this.AppText.AutoSize = true;
            this.AppText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppText.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppText.ForeColor = System.Drawing.Color.Fuchsia;
            this.AppText.Location = new System.Drawing.Point(243, 75);
            this.AppText.Name = "AppText";
            this.AppText.Size = new System.Drawing.Size(310, 35);
            this.AppText.TabIndex = 1;
            this.AppText.Text = "xCheats Launcher";
            // 
            // StartBtn
            // 
            this.StartBtn.AllowTransparency = true;
            this.StartBtn.AnimationInterval = 1;
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.BGColor = "#fffff";
            this.StartBtn.Corners = 1F;
            this.StartBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.StartBtn.DoubleRipple = false;
            this.StartBtn.EnabledBGColor = System.Drawing.Color.Transparent;
            this.StartBtn.FontColor = "#ffffff";
            this.StartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StartBtn.Location = new System.Drawing.Point(294, 415);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.StartBtn.RippleOpacity = 25;
            this.StartBtn.Size = new System.Drawing.Size(201, 23);
            this.StartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start xCheats";
            this.StartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zeroitChromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zeroitGradientForm1";
            this.zeroitChromeForm1.ResumeLayout(false);
            this.zeroitChromeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton StartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel AppText;
        public Zeroit.Framework.Form.ZeroitChromeForm zeroitChromeForm1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton zeroitLollipopButton1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox OffTggl;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox BGTggl;
    }
}

